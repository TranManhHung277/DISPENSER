using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Collections;
using LiteDB;

namespace SEMV_Dispencer_V1.DeviceConnection
{
    public class cCameraIS
    {
        //public delegate void invokeDelegate();
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] data = new byte[1000000];

        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Timer timerCheckOnline;
        private readonly object _syncRoot = new object();
        private int _sentPings;
        private int _recievedIpAddresses;
        private static bool connected = false;
        public static string nowCommand = "";
        public static bool Connected
        {
            get { return connected; }
            set { connected = value; }
        }
        private static cCameraIS _instance;
        public static cCameraIS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new cCameraIS();
                }
                return _instance;
            }
        }
        private static int startReadValue = 0;
        public static bool online = false;
        public static int jobID = 1;
        public static int TriggerOn = 0;
        public static int[] ProductResult;
        private static Library.cDatabase.TSetting _programsetting;
        private Library.cCameraISSetting _setting;
        public Library.cCameraISSetting Setting
        {
            get
            {
                if (this._setting == null)
                {
                    if (File.Exists(Library.cDatabase.fileISSetting))
                    {
                        try
                        {
                            this._setting = JsonConvert.DeserializeObject<Library.cCameraISSetting>(File.ReadAllText(Library.cDatabase.fileISSetting));
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        this._setting = new Library.cCameraISSetting
                        {
                            Ip = "192.168.0.12",
                            Port = 23
                        };
                        Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileISSetting));
                        File.WriteAllText(Library.cDatabase.fileISSetting, JsonConvert.SerializeObject(this._setting));
                    }
                }
                return this._setting;
            }
            set
            {
                this._setting = value;
                Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileISSetting));
                File.WriteAllText(Library.cDatabase.fileISSetting, JsonConvert.SerializeObject(this._setting));
            }
        }
        public cCameraIS()
        {
            timerPing = new System.Windows.Forms.Timer();
            timerPing.Interval = 1000;
            timerPing.Tick += new EventHandler(timerPing_Tick);
            timerPing.Start();
            timerCheckOnline = new System.Windows.Forms.Timer();
            timerCheckOnline.Interval = 500;
            timerCheckOnline.Tick += new EventHandler(timerCheckOnline_Tick);
            timerCheckOnline.Start();
        }
        private void timerCheckOnline_Tick(object sender, EventArgs e)
        {
            try
            {
                //GetOnline();
                //if(TriggerOn == 0)
                //TriggerOn = 1;
                //Trigger();
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("cCameraIS", "Timer", ex.Message);
            }
            //PingDevice();
        }
        private void timerPing_Tick(object sender, EventArgs e)
        {
            if(!connected)
            {
                
            }
            try
            {

                lock (_syncRoot)
                {
                    _sentPings = 0;
                    _recievedIpAddresses = 0;
                }
                PingHost(this.Setting.Ip); // ip addres, rows, colum show state
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("cCameraIS", "Timer", ex.Message);
            }
            //PingDevice();
        }
        private void PingHost(string ipAddress)
        {
            try
            {
                UIControl.UIPingDevice pingdevice = new UIControl.UIPingDevice(ipAddress);
                pingdevice.OnExtendedPingCompleted += (sender, eventArgs, ip) =>
                {
                    lock (_syncRoot)
                    {
                        _recievedIpAddresses++;
                    }
                    string status = "Disconnected";
                    try
                    {
                        switch (eventArgs.Reply.Status)
                        {
                            case IPStatus.Success:
                                status = "Connected";
                                //connected = true;
                                break;
                        }
                    }
                    catch (System.NullReferenceException ex)
                    {
                        connected = false;
                        RunProgram.LogErr("cCameraIS", "Ping", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        connected = false;
                        RunProgram.LogErr("cCameraIS", "Ping", ex.Message);
                    }

                    lock (_syncRoot)
                    {
                        if (_recievedIpAddresses == _sentPings)
                        {

                        }
                    }
                    /* save database*/
                    if (DateTime.Now.Second % 2 == 0)
                    {
                        /// Thread backgroundThread = new Thread(() => { UpdataState(theCell.Value, status); });  dave to database
                       // backgroundThread.Start();
                    }
                    if(!connected) Connect(status);
                };
                pingdevice.SendAsync(ipAddress, 1000, 100);
            }
            catch (Exception ex)
            {
                connected = false;
                RunProgram.LogErr("cCameraIS", "Ping", ex.Message);
            }
        }
        private void Connect(string status)
        {
            try
            {
                string IP = Setting.Ip;
                int Port = Setting.Port;
                if (status == "Connected")
                {
                    if (!_clientSocket.Connected )
                    {
                        try
                        {
                            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                            _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                            connected = true;
                        }
                        catch (Exception ex)
                        {
                            connected= false;
                            RunProgram.LogErr("cCameraIS", "Open Socket", ex.Message);
                        }
                        //Thread _threadConnect = new Thread(() =>
                        //{
                        //    try
                        //    {
                        //        _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        //        _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                        //        _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                                
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        RunProgram.LogErr("cCameraIS", "Open Socket", ex.Message);
                        //    }
                        //});
                        //_threadConnect.IsBackground = true;
                        //_threadConnect.Start();
                    }
                }
                else
                {
                    connected = false;
                    if (_clientSocket != null) _clientSocket.Close();
                    RunProgram.LogErr("cCameraIS", "Ping", "Fail");
                }
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("cCameraIS", "Ping",ex.Message);
                connected = false;
            }
        }
        private static void SendToServer(byte[] data,string cmd)
        {
            if (_clientSocket.Connected)
            {
                try
                {
                    Thread.Sleep(2);
                    nowCommand = cmd;
                    _clientSocket.Send(data);
                    RunProgram.LogIS("Send",Encoding.ASCII.GetString(data));
                }
                catch (SocketException ex)
                {
                    connected = false;
                    RunProgram.LogErr("cCameraIS", "Send Data", ex.Message);
                    _clientSocket.Close();
                }
            }
        }
        private void LoadSetting()
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                _programsetting = db.GetCollection<Library.cDatabase.TSetting>("settings").FindById(1);
            }
        }
        public static int ChangeJob = 0;
        public static string ImageBMP = "";
        public static int byteCount = 0;
        private void ReceiveData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                if (remote.Connected)
                {
                    int recv = remote.EndReceive(iar);
                    string stringData = Encoding.ASCII.GetString(data, 0, recv);
                    RunProgram.LogIS("Received",stringData);
                    if (stringData == "Welcome to In-Sight(tm)  2001-353 Session 0\r\n")
                    {

                    }
                    else if (stringData == "User: ")
                    {
                        SendToServer(Encoding.ASCII.GetBytes("admin\r\n"),"admin");
                    }
                    else if (stringData == "Password: ")
                    {
                        SendToServer(Encoding.ASCII.GetBytes("\r\n"),"password");
                    }
                    else if (stringData == "User Logged In\r\n")
                    {
                        nowCommand = ISCommand.None;
                    }
                    else
                    {
                        string[] stringSeparators = new string[] { "\r\n" };
                        string[] lines = stringData.Split(stringSeparators, StringSplitOptions.None);
                        if(lines.Length > 0)
                        {
                            switch (nowCommand)
                            {
                                case ISCommand.GetOnline:
                                    {
                                        if (lines[0] == "1")
                                        {
                                            //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3999), 1, new int[1] {1}, 0);
                                            online = true;
                                        }
                                        else
                                        {
                                            online = false;
                                            //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3999), 1, new int[1] { 0 }, 0);
                                        }
                                        nowCommand = ISCommand.None;
                                        break;
                                    }
                                case ISCommand.SetOnline:
                                    {
                                        nowCommand = ISCommand.None;
                                        break;
                                    }
                                case ISCommand.SetOffline:
                                    {
                                        if (jobID < 10)
                                            SendToServer(Encoding.ASCII.GetBytes(String.Format("{0}0{1}", ISCommand.ChangeJob, jobID) + "\r\n"), ISCommand.ChangeJob);
                                        else SendToServer(Encoding.ASCII.GetBytes(String.Format("{0}{1}", ISCommand.ChangeJob, jobID) + "\r\n"), ISCommand.ChangeJob);
                                        break;
                                    }
                                case ISCommand.ChangeJob:
                                    {
                                        if (lines[0] == "1")
                                        {
                                            ChangeJob = 1;
                                        }
                                        else
                                        {
                                            ChangeJob = 2;
                                        }
                                        nowCommand = ISCommand.None;
                                        SetOnline();
                                        break;
                                    }
                                case ISCommand.Trigger:
                                    {
                                        if (lines[0] == "1")
                                        {
                                            SendToServer(Encoding.ASCII.GetBytes(String.Format("GVZ{0}", 165 + startReadValue) + "\r\n"), ISCommand.GetValue);
                                        }
                                        else
                                        {
                                            nowCommand = ISCommand.None;
                                            //TriggerOn = false;
                                        }
                                        break;
                                    }
                                case ISCommand.ReadBMP:
                                    {
                                        if(byteCount > 0)
                                        {
                                            string dataM = "";
                                            foreach(string b in lines)
                                            {
                                                ImageBMP += b;
                                                dataM += b;
                                            }    
                                            Console.WriteLine(dataM);
                                            if(ImageBMP.Length >= byteCount + 4)
                                            {
                                                RunProgram.LogDeviceAction("Cam IS", "Read BMP Done");
                                            }
                                        }    
                                        if (lines[0] == "1")
                                        {
                                            byteCount = Convert.ToInt32(lines[1]);
                                        }
                                        break;
                                    }
                                case ISCommand.GetValue:
                                    {
                                        if (lines[0] == "1" && startReadValue < 21)
                                        {
                                            //RunProgram.LogDeviceAction(startReadValue.ToString(), lines[1]);
                                            HandleData(lines[1], startReadValue);
                                            startReadValue++;
                                            if (startReadValue < 21)
                                            {
                                                SendToServer(Encoding.ASCII.GetBytes(String.Format("GVZ{0}", 165 + startReadValue) + "\r\n"), ISCommand.GetValue);
                                            }
                                            else
                                            {
                                                TriggerOn = 2;
                                                nowCommand = ISCommand.None;
                                            }
                                        }
                                        else nowCommand = ISCommand.None;
                                        break;
                                    }
                                case ISCommand.SaveMaster:
                                    {
                                        if (lines[0] == "1")
                                        {

                                            if (startReadValue == 0)
                                            {
                                                RunProgram.SaveMasterX(Convert.ToDouble(lines[1]));
                                                startReadValue++;
                                                SendToServer(Encoding.ASCII.GetBytes("GVS106" + "\r\n"), ISCommand.SaveMaster);
                                            }
                                            else
                                            {
                                                RunProgram.SaveMasterY(Convert.ToDouble(lines[1]));
                                                nowCommand = ISCommand.None;
                                                startReadValue = 0;
                                            }
                                        }
                                        else
                                        {
                                            nowCommand = ISCommand.None;
                                            startReadValue = 0;
                                        }
                                        break;
                                    }
                            }
                        }
                    }

                    _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                }
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("cCameraIS", "Received", ex.Message);
                _clientSocket.Close();
                connected = false;
            }

        }
        private void HandleData(string data, int index)
        {
            //Console.WriteLine(data);
            string[] arrayString = data.Split(',').ToArray();
            double[] arrayDouble  = Array.ConvertAll(arrayString, s => double.Parse(s));
            int[] arrayInt = new int[arrayDouble.Length*2-2];
            arrayInt[0] = (int)arrayDouble[0];
            for(int i = 1; i < arrayDouble.Length-2; i++)
            {
                int value1 = 0;
                int value2 = 0;
                UIControl.UIValueTranform.DoubleToInt32(arrayDouble[i], out value1, out value2,1);
                arrayInt[i * 2] = value1;
                arrayInt[i * 2 + 1] = value2;
            }
            arrayInt[arrayInt.Length-2] = (int)arrayDouble[arrayDouble.Length-2];
            arrayInt[arrayInt.Length-1] = (int)arrayDouble[arrayDouble.Length-1];
            int indexCal = 0;
            if (index <= 0)
            {
                //RunProgram.LogDeviceAction("Cam IS", "Trigger Done");
                ProductResult = arrayInt;
                //indexCal = 3700;
                //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", indexCal), arrayInt.Length, arrayInt, 0);
            }
            else
            {
                indexCal = 3000 + (index-1) * 14;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", indexCal), arrayInt.Length, arrayInt, 0);
            }  
        }
        public static async void Trigger()
        {
            while (nowCommand != ISCommand.None && TriggerOn != 0)
            {
                await Task.Delay(10);
            }
            if (TriggerOn == 0) return;
            startReadValue = 0;
            RunProgram.LogDeviceAction("Cam IS", "Start Trigger");
            cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3815), 1, new int[1] { 1 }, 0);
            SendToServer(Encoding.ASCII.GetBytes(ISCommand.Trigger + "\r\n"), ISCommand.Trigger);

        }
        public static async void SaveMaster()
        {
            while (nowCommand != ISCommand.None && TriggerOn != 0)
            {
                await Task.Delay(10);
            }
            if (TriggerOn == 0) return;
            RunProgram.LogDeviceAction("Cam IS", "Save Master");
            startReadValue = 0;
            SendToServer(Encoding.ASCII.GetBytes("GVR106" + "\r\n"), ISCommand.SaveMaster);

        }
        public static async void ReadBMP()
        {
            while (nowCommand != ISCommand.None)
            {
                await Task.Delay(10);
            }
            RunProgram.LogDeviceAction("Cam IS", "Read BMP");
            int count = ImageBMP.Length;
            ImageBMP = "";
            byteCount = 0;
            SendToServer(Encoding.ASCII.GetBytes(ISCommand.ReadBMP + "\r\n"), ISCommand.ReadBMP);
        }
        public static void ChangeISJob(int id)
        {
            
            if (nowCommand == ISCommand.None)
            {
                SetOffline();
                jobID = id;
            }
               
        }
        public static void GetOnline()
        {
            if (nowCommand == ISCommand.None)
            {
                SendToServer(Encoding.ASCII.GetBytes(String.Format("{0}", ISCommand.GetOnline) + "\r\n"), ISCommand.GetOnline);
                startReadValue = 0;
            }
            
        }
        public static void SetOnline()
        {
            if (nowCommand == ISCommand.None)
            {
                SendToServer(Encoding.ASCII.GetBytes(String.Format("{0}", ISCommand.SetOnline) + "\r\n"), ISCommand.SetOnline);
                startReadValue = 0;
            }
            
        }
        public static void SetOffline()
        {
            if (nowCommand == ISCommand.None)
            {
                SendToServer(Encoding.ASCII.GetBytes(String.Format("{0}", ISCommand.SetOffline) + "\r\n"), ISCommand.SetOffline);
                startReadValue = 0;
            }

        }
    }
    public class ISCommand
    {
        public const string None = "None";
        public const string Trigger = "SW8";
        public const string GetOnline = "GO";
        public const string GetValue = "GV";
        public const string SetOnline = "SO1";
        public const string SetOffline = "SO0";
        public const string ChangeJob = "SJ";
        public const string ReadBMP = "RI";
        public const string SaveMaster = "SetMaster";
    }
}
