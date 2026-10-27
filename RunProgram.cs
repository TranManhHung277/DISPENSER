using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using LiteDB;
using System.IO;
using System.Windows.Forms;
using SEMV_Dispencer_V1.UIControl;
using SEMV_Dispencer_V1.DeviceConnection;
using System.Collections;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;

namespace SEMV_Dispencer_V1
{
    public delegate void VoidEventHandler();
    //public delegate void StringEventHandler(string value);
    public delegate void BitEventHandler();
    public class RunProgram
    {
        #region Event
        public event VoidEventHandler OnStartUp;
        public event BitEventHandler CheckPLCEvent;
        #endregion
        #region Public Variable
        public DeviceConnection.cCameraIS CamIS;
        public DeviceConnection.cCameraAS CamAS;
        public DeviceConnection.cSensorHeight SensorHeight;
        public DeviceConnection.cMCProtocol PLC;

        public static int nowArrayX2;
        public static int nowArrayY2;
        public static int nowArrayX1;
        public static int nowArrayY1;

        public static int[] _writePLC = new int[5000];
        public static int[] _readPLC = new int[5000];
        public static string Password = "";
        public static int AccessLevel = 0;
        public static bool ChangeModel = false;
        public static List<string> ListRecordDeviceAction = new List<string>();
        public static string[] ListError;
        public static Library.cDatabase.TSetting Settings
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var setting = db.GetCollection<Library.cDatabase.TSetting>("settings").FindById(1);
                    return setting;
                }
            }
        }
        public static List<Library.cDatabase.TMaster> Masters
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    return db.GetCollection<Library.cDatabase.TMaster>("masters").FindAll().ToList();
                }
            }
        }
        public static List<Library.cDatabase.TMotorData> MotorDatas
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    return db.GetCollection<Library.cDatabase.TMotorData>("motordatas").FindAll().ToList();
                }
            }
        }
        public static List<Library.cDatabase.TModel> Models
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    return db.GetCollection<Library.cDatabase.TModel>("models").FindAll().ToList();
                }
            }
        }
        public static Library.cDatabase.TModel ModelActive
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    return db.GetCollection<Library.cDatabase.TModel>("models").Find(Query.EQ("Active", true)).FirstOrDefault();
                }
            }
        }
        public static Library.cDatabase.TData Data
        {
            get
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var d = db.GetCollection<Library.cDatabase.TData>("data");
                    
                    if(d.Count() > 0)
                    {
                        return db.GetCollection<Library.cDatabase.TData>("data").FindById(1);
                    }   
                    else
                    {
                        var data = new Library.cDatabase.TData
                        {
                            LimitNeedleZ1 = 0.5,
                            LimitNeedleZ2 = -0.5,
                            LimitNeedleX1 = 0.35,
                            LimitNeedleX2= -0.35,
                            LimitNeedleY1= 0.35,
                            LimitNeedleY2= -0.35,
                            LimitISA1= 20,
                            LimitISA2= -20,
                            LimitISX1= 10,
                            LimitISX2= -10,
                            LimitISY1= 10,
                            LimitISY2= -10,
                            LimitISZ1= 3,
                            LimitISZ2= -3,
                            OffsetX=0,
                            OffsetY=0,
                            OffsetZ=0,
                        };
                        d.Insert(data);
                        return data;
                    }    
                }
            }
            set
            {
                //using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                //{
                //    var d = db.GetCollection<Library.cDatabase.TData>("data");
                //    d.Update(value);
                //}
            }
        }
        #endregion
        #region Private Variable
        public System.Windows.Forms.Timer _timerAsynce;
        public System.Windows.Forms.Timer _timerCheckPLCSignal;
        private static ReaderWriterLockSlim _readwriteFile = new ReaderWriterLockSlim();
        private static RunProgram _instance;
        public static RunProgram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RunProgram();
                }
                return _instance;
            }
        }
        private static string _asApp;
        public static string AsApp
        {
            get
            {
                if (_asApp == null)
                {
                    if (File.Exists(Library.cDatabase.fileAsApp))
                    {
                        try
                        {
                            _asApp = JsonConvert.DeserializeObject<Library.cAppSetting>(File.ReadAllText(Library.cDatabase.fileAsApp)).FileName;
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        Library.cAppSetting _ = new Library.cAppSetting
                        {
                            FileName = ""
                        };
                        _asApp = _.FileName;
                        Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileAsApp));
                        File.WriteAllText(Library.cDatabase.fileAsApp, JsonConvert.SerializeObject(_));
                    }
                }
                return _asApp;
            }
            set
            {
                _asApp = value;
                Library.cAppSetting _ = new Library.cAppSetting
                {
                    FileName = _asApp
                };
                if (!File.Exists(Library.cDatabase.fileAsApp)) Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileAsApp));
                File.WriteAllText(Library.cDatabase.fileAsApp, JsonConvert.SerializeObject(_));
            }
        }
        #endregion
        public RunProgram()
        {
            LoadModelData();
            LoadErrorList();
            LoadPassword();
            LoadSetting();
            PLC = new DeviceConnection.cMCProtocol();
            CamIS = new DeviceConnection.cCameraIS();
            SensorHeight = new DeviceConnection.cSensorHeight();
            CamAS = new DeviceConnection.cCameraAS();
            CheckPLCEvent += PLCEvent;
            _timerAsynce = new System.Windows.Forms.Timer();
            _timerAsynce.Interval = 100;
            _timerAsynce.Tick += new EventHandler(timerAsynce_Tick);
            //_timerAsynce.Start();
            _timerCheckPLCSignal = new System.Windows.Forms.Timer();
            _timerCheckPLCSignal.Interval = 10;
            _timerCheckPLCSignal.Tick += new EventHandler(timerCheckPLCSignal_Tick);
            //_timerCheckPLCSignal.Start();
        }
        private void timerAsynce_Tick(object sender, EventArgs e)
        {
            StartAsync();
        }
        private void timerCheckPLCSignal_Tick(object sender, EventArgs e)
        {
            StartCheck();
        }
        public async void StartAsync()
        {
            await Task.Delay(1);
            if (this.OnStartUp != null)
            {
                this.OnStartUp();
            }
        }
        public async void StartCheck()
        {
            await Task.Delay(1);
            if (this.CheckPLCEvent != null)
            {
               this.CheckPLCEvent();
            }
        }
        private void PLCEvent()
        {
            if (UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 2))
            {
                if (DeviceConnection.cCameraIS.TriggerOn == 0)
                {
                    DeviceConnection.cCameraIS.TriggerOn = 1;
                    DeviceConnection.cCameraIS.Trigger();
                }
            }
            if (UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 3))
            {
                if (DeviceConnection.cCameraIS.TriggerOn == 0)
                {
                    DeviceConnection.cCameraIS.TriggerOn = 1;
                    DeviceConnection.cCameraIS.Trigger();
                }
            }
            if (DeviceConnection.cCameraIS.TriggerOn == 2)
            {
                //RunProgram.LogDeviceAction("Cam IS", "Reset Trigger");
                DeviceConnection.cCameraIS.TriggerOn = 3;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 4103), 1, new int[1] { 0 }, 0);
            }
            if (DeviceConnection.cCameraIS.TriggerOn == 3 & _readPLC[4103] == 0)
            {
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3700), DeviceConnection.cCameraIS.ProductResult.Length, DeviceConnection.cCameraIS.ProductResult, 0);
                DeviceConnection.cCameraIS.TriggerOn = 0;
                string logValue = "";
                foreach(var v in DeviceConnection.cCameraIS.ProductResult)
                {
                    logValue += v.ToString() + ",";
                }    
                RunProgram.LogDeviceAction("Cam IS", logValue);
            }
            // Camera AS
            if (UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 4))
            {
                if (DeviceConnection.cCameraAS.TriggerOn == 0)
                {
                    DeviceConnection.cCameraAS.TriggerOn = 1;
                    DeviceConnection.cCameraAS.Trigger();
                } 
            }
            if (DeviceConnection.cCameraAS.TriggerOn == 2)
            {
                DeviceConnection.cCameraAS.TriggerOn = 3;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 4103), 1, new int[1] { 0 }, 0);
                //RunProgram.LogDeviceAction("Cam AS", "Reset Trigger");
            }
            if (DeviceConnection.cCameraAS.TriggerOn == 3 & !UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 4))
            {
                int[] arrayInt = new int[8];
                int value1;
                int value2;
                string logValue = "";
                for (int i = 1; i < DeviceConnection.cCameraAS.NeedleData.Length; i++)
                {
                    UIControl.UIValueTranform.DoubleToInt32(Convert.ToDouble(DeviceConnection.cCameraAS.NeedleData[i]), out value1, out value2, 100);
                    arrayInt[(i - 1) * 2] = value1;
                    arrayInt[(i - 1) * 2 + 1] = value2;
                    logValue += DeviceConnection.cCameraAS.NeedleData[i] + ",";
                }
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3720), arrayInt.Length, arrayInt, 0);
                DeviceConnection.cCameraAS.TriggerOn = 0;
                RunProgram.LogDeviceAction("Cam AS", logValue) ;
            }
            // Sensor height check
            if (UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 5))
            {
                if (DeviceConnection.cSensorHeight.triggerOn == 0)
                {
                    DeviceConnection.cSensorHeight.triggerOn = 1;
                    DeviceConnection.cSensorHeight.Trigger();
                }    
            }
            if (DeviceConnection.cSensorHeight.triggerOn == 2)
            {
                DeviceConnection.cSensorHeight.triggerOn = 3;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 4103), 1, new int[1] { 0 }, 0);
                //RunProgram.LogDeviceAction("SS Height", "Reset Trigger");
            }
            if(DeviceConnection.cSensorHeight.triggerOn == 3 && !UIControl.UIValueTranform.Int32ToBoolenValue(_readPLC[4103], 5))
            {
                DeviceConnection.cSensorHeight.triggerOn = 0;
                int[] arrayInt = new int[4];
                int value1 = 0;
                int value2 = 0;
                double roundvalue = 0;
                UIControl.UIValueTranform.DoubleRound(DeviceConnection.cSensorHeight.SensorHeight, 2, out roundvalue);
                UIControl.UIValueTranform.DoubleToInt32(roundvalue, out value1, out value2, 1);
                arrayInt[0] = 1;
                arrayInt[1] = 0;
                arrayInt[2] = value1;
                arrayInt[3] = value2;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3730), arrayInt.Length, arrayInt, 0);
                RunProgram.LogDeviceAction("Sensor", (roundvalue / 10000).ToString());
                //RunProgram.LogDeviceAction("SS Height", "Reset Done");
            }    
        }
        public static void LoadSetting()
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TSetting>("settings");
                if (models.Count() == 0)
                {
                    var model = new Library.cDatabase.TSetting()
                    {
                        GlueActive = 0,
                        WrongActive = 0
                    };
                    models.Insert(model);
                }
            }
        }
        public static void LoadModelData()
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TModel>("models");
                if (models.Count() == 0)
                {
                    var model = new Library.cDatabase.TModel()
                    {
                        ModelName = "Hello",
                        CamISX = 54.62,
                        CamISY = 216.62,
                        CamISZ = 1.86,
                        ArrayX1 = 2,
                        ArrayY1 = 2,
                        DistanceX1 = 5,
                        DistanceY1 = 5,
                        ArrayX2 = 2,
                        ArrayY2 = 2,
                        DistanceX2 = 26,
                        DistanceY2 = 42,
                        SpeedCamIS = 50,
                        LightPrd = 40,
                        LightGlue = 40,
                        Active = true
                    };
                    models.Insert(model);
                }
            }
        }
        public static void LoadErrorList()
        {
            if (File.Exists(Library.cDatabase.fileErrorList))
            {
                try
                {
                    ListError = File.ReadAllLines(Library.cDatabase.fileErrorList);
                }
                catch (Exception ex)
                {
                    LogErr("Run Program", "Read Error List File", ex.Message);
                }
            };
        }
        public static void LoadPassword()
        {
            if (File.Exists(Library.cDatabase.fileErrorList))
            {
                try
                {
                    Password = File.ReadAllLines(Library.cDatabase.filePassword)[0];
                }
                catch (Exception ex)
                {
                    LogErr("Run Program", "Read Password File", ex.Message);
                }
            };
        }
        public static bool CheckNeedleApp()
        {
            if(File.Exists(AsApp)) return true;
            else
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Application Files (*.exe)|*.exe";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    AsApp = openFileDialog1.FileName;
                    return true;
                }
                else return false;
            }
            
        }
        public static void SaveSetting(int glue, int wrong)
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TSetting>("settings");
                var setting = models.FindById(1);
                setting.WrongActive = wrong; 
                setting.GlueActive = glue;
                models.Update(setting);
            }
        }
        public static void ActiveModel(int index)
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models  = db.GetCollection<Library.cDatabase.TModel>("models");
                var modellist = models.FindAll().ToList();
                foreach(var m in modellist)
                {
                    m.Active = false;
                    models.Update(m);
                }
                var model = modellist[index];
                model.Active = true;
                models.Update(model);
                SendModelData(model);
            }
        }
        public static void SendModelData(Library.cDatabase.TModel m)
        {
            if(m != null)
            {
                double[] arrayDouble = new double[14]
                {
                    m.CamISX * 100,
                    m.CamISY * 100,
                    m.CamISZ * 100,
                    m.ArrayX1,
                    m.ArrayY1,
                    m.DistanceX1 * 100,
                    m.DistanceY1 * 100,
                    m.ArrayX2,
                    m.ArrayY2,
                    m.DistanceX2 * 100,
                    m.DistanceY2 * 100,
                    m.SpeedCamIS * 100,
                    m.LightPrd,
                    m.LightGlue
                };
                int[] arrayInt = new int[arrayDouble.Length * 2];
                for (int i = 0; i < arrayDouble.Length; i++)
                {
                    int value1 = 0;
                    int value2 = 0;
                    UIControl.UIValueTranform.DoubleToInt32(arrayDouble[i], out value1, out value2,1);
                    arrayInt[i * 2] = value1;
                    arrayInt[i * 2 + 1] = value2;
                }
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3400), arrayInt.Length, arrayInt, 0);
                nowArrayX2 = Convert.ToInt32(m.ArrayX2);
                nowArrayY2 = Convert.ToInt32(m.ArrayY2);
                ChangeModel = true;
            }
        }
        public static void SendMasterData()
        {
            var masters = Masters;
            if (masters != null)
            {
                List<double> arrayDouble = new List<double>();
                foreach(var m in masters)
                {
                    List<double> array = new List<double>
                    {
                        m.X,
                        m.Y,
                        m.Z,
                        m.Data1,
                        m.Data2
                    };
                    arrayDouble.AddRange(array);
                }
                
                int[] arrayInt = new int[arrayDouble.Count * 2];
                for (int i = 0; i < arrayDouble.Count; i++)
                {
                    int value1 = 0;
                    int value2 = 0;
                    UIControl.UIValueTranform.DoubleToInt32(arrayDouble[i], out value1, out value2,100);
                    arrayInt[i * 2] = value1;
                    arrayInt[i * 2 + 1] = value2;
                }
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3500), arrayInt.Length, arrayInt, 0);
            }
        }
        public static void SendMotorData()
        {
            var motordatas = MotorDatas;
            if (motordatas != null)
            {
                List<double> arrayDouble = new List<double>();
                foreach (var m in motordatas)
                {
                    List<double> array = new List<double>
                    {
                        m.OriginSpeed,
                        m.Home,
                        m.JogLow,
                        m.JogHigh,
                        0,
                        0,
                        0,
                        0,
                        m.Acc,
                        m.Dec
                    };
                    arrayDouble.AddRange(array);
                }

                int[] arrayInt = new int[arrayDouble.Count * 2];
                for (int i = 0; i < arrayDouble.Count; i++)
                {
                    int value1 = 0;
                    int value2 = 0;
                    UIControl.UIValueTranform.DoubleToInt32(arrayDouble[i], out value1, out value2, 100);
                    arrayInt[i * 2] = value1;
                    arrayInt[i * 2 + 1] = value2;
                }
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3600), arrayInt.Length, arrayInt, 0);
            }
        }
        public static void SendLimitData()
        {
            var data = Data;
            if (data != null)
            {
                List<double> array = new List<double>
                    {
                        data.OffsetX,
                        data.OffsetY,
                        data.OffsetZ,
                        data.LimitNeedleX1,
                        data.LimitNeedleX2,
                        data.LimitNeedleY1,
                        data.LimitNeedleY2,
                        data.LimitNeedleZ1,
                        data.LimitNeedleZ2,
                        data.LimitISX1,
                        data.LimitISX2,
                        data.LimitISY1,
                        data.LimitISY2,
                        data.LimitISZ1,
                        data.LimitISZ2,
                        data.LimitISA1,
                        data.LimitISA2,
                        data.LimitISZ1,
                        data.LimitISZ2
                    };
                int[] arrayInt = new int[array.Count * 2];
                for (int i = 0; i < array.Count; i++)
                {
                    int value1 = 0;
                    int value2 = 0;
                    UIControl.UIValueTranform.DoubleToInt32(array[i], out value1, out value2, 100);
                    arrayInt[i * 2] = value1;
                    arrayInt[i * 2 + 1] = value2;
                }
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3430), arrayInt.Length, arrayInt, 0);
            }
        }
        public static void SendOffsetZ(double value)
        {
            int value1 = 0;
            int value2 = 0;
            UIControl.UIValueTranform.DoubleToInt32(value, out value1, out value2, 100);
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3434), 2, new int[2] { value1,value2}, 0);
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var d = db.GetCollection<Library.cDatabase.TData>("data");
                var _ = d.FindById(1);
                _.OffsetZ = value;
                d.Update(_);
            }
        }
        public static void SendGlueSetting(int glue)
        {
            int[] data = new int[1] { glue};
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3680), 1, data, 0);
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TSetting>("settings");
                var setting = models.FindById(1);
                setting.GlueActive = glue;
                models.Update(setting);
            }
        }

        public static void SendWrongSetting(int wrong)
        {
            int[] data = new int[1] { wrong };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3681), 1, data, 0);
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TSetting>("settings");
                var setting = models.FindById(1);
                setting.WrongActive = wrong;
                models.Update(setting);
            }
        }
        public static void SaveMasterX(double value)
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var settings = db.GetCollection<Library.cDatabase.TSetting>("settings");
                var setting = settings.FindById(1);
                setting.ISMasterX = value;
                settings.Update(setting);
            }
        }
        public static void SaveMasterY(double value)
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var settings = db.GetCollection<Library.cDatabase.TSetting>("settings");
                var setting = settings.FindById(1);
                setting.ISMasterY = value;
                settings.Update(setting);
            }
        }
        public static void LogErr(string position, string ErrType, string err)
        {
            _readwriteFile.EnterWriteLock();
            try
            {
                string path = Path.Combine(Application.StartupPath, "logfile.txt");
                if (!File.Exists(path))
                    File.Create(path);
                using (System.IO.StreamWriter file = File.AppendText(path))
                {
                    string text =String.Format("{0} {1}.{2}.{3}.{4}: {5}/{6}/{7}", DateTime.Now.ToLongDateString(), DateTime.Now.Hour,DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond,position,ErrType,err);
                    file.WriteLine(text);
                    file.Close();
                }
            }
            catch (Exception )
            {

            }
            finally
            {
                _readwriteFile.ExitWriteLock();
            }

        }
        public static void LogIS(string type, string position)
        {
            _readwriteFile.EnterWriteLock();
            try
            {
                string path = Path.Combine(Application.StartupPath, "logISCMD.txt");
                if (!File.Exists(path))
                    File.Create(path);
                using (System.IO.StreamWriter file = File.AppendText(path))
                {
                    string text = String.Format("{0} {1}.{2}.{3}.{4}: {5}/{6}", DateTime.Now.ToLongDateString(), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, type,position);
                    file.WriteLine(text);
                    file.Close();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _readwriteFile.ExitWriteLock();
            }

        }
        public static void LogDeviceAction(string device, string action)
        {
            string text = String.Format("{0}.{1}.{2}.{3};{4};{5}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, device, action);
            ListRecordDeviceAction.Add(text);
        }
    }
}
