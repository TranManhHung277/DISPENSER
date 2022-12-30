using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SEMV_Dispencer_V1.DeviceConnection
{
    public class cMCProtocol
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] data = new byte[2000];
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Timer timerReadData;
        private readonly object _syncRoot = new object();
        private int _sentPings;
        private int _recievedIpAddresses;
        private static bool connected = false;
        public static bool Connected
        {
            get { return connected; }
        }
        private static int deviceSize;
        private static int DeviceSize
        {
            get { return deviceSize;}
            set { deviceSize = value;}
        }
        private static int arrayPosition;
        private static int ArrayPosition
        {
            get { return arrayPosition; }
            set { arrayPosition = value; }
        }
        private Library.cPLCSetting _setting;
        public Library.cPLCSetting Setting
        {
            get
            {
                if (this._setting == null)
                {
                    if (File.Exists(Library.cDatabase.filePLCSetting))
                    {
                        try
                        {
                            this._setting = JsonConvert.DeserializeObject<Library.cPLCSetting>(File.ReadAllText(Library.cDatabase.filePLCSetting));
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        this._setting = new Library.cPLCSetting
                        {
                            Ip = "192.168.0.10",
                            Port = 5000
                        };
                        Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.filePLCSetting));
                        File.WriteAllText(Library.cDatabase.filePLCSetting, JsonConvert.SerializeObject(this._setting));
                    }
                }
                return this._setting;
            }
            set
            {
                this._setting = value;
                Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.filePLCSetting));
                File.WriteAllText(Library.cDatabase.filePLCSetting, JsonConvert.SerializeObject(this._setting));
            }
        }
        public cMCProtocol()
        {
            Ping();
            timerPing = new System.Windows.Forms.Timer();
            timerPing.Interval = 1000;
            timerPing.Tick += new EventHandler(timerPing_Tick);
            timerPing.Start();
            timerReadData = new System.Windows.Forms.Timer();
            timerReadData.Interval = 25;
            timerReadData.Tick += new EventHandler(timerCheck_Tick);
            timerReadData.Start();
        }
        private void timerPing_Tick(object sender, EventArgs e)
        {
            Ping();
            int[] onlineState = new int[3];
            onlineState[0] = DeviceConnection.cCameraIS.Connected && DeviceConnection.cCameraIS.ChangeJob == -1 ? 1 : 0; //DeviceConnection.cCameraIS.online
            onlineState[1] = DeviceConnection.cCameraAS.Connected ? 1 : 0;
            onlineState[2] = DeviceConnection.cSensorHeight.Connected ? 1 : 0;
            //if(onlineState[0] == 0 || onlineState[1] == 0 || onlineState[2] == 0 )
            //{
            //    Console.WriteLine(onlineState[0].ToString() + onlineState[1].ToString() + onlineState[2].ToString());
            //}
            //Console.WriteLine(onlineState[0].ToString() + onlineState[1].ToString() + onlineState[2].ToString());
            cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3819), 3, onlineState, 0);
        }
        private void Ping()
        {
            try
            {
                lock (_syncRoot)
                {
                    _sentPings = 0;
                    _recievedIpAddresses = 0;
                }
                PingHost(Setting.Ip); // ip addres, rows, colum show state
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("MCProtocol","Ping",ex.Message);
            }
        }
        private void timerCheck_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(String.Format("{0}.{1}: {2}", DateTime.Now.Second, DateTime.Now.Millisecond, "Start SS Read"));
            ReadDeviceBlock("D3800", 500, 3800);
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
                                break;
                        }
                    }
                    catch (System.NullReferenceException ex)
                    {
                        connected = false;
                        RunProgram.LogErr("MCProtocol", "Ping", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        connected= false;   
                        RunProgram.LogErr("MCProtocol", "Ping", ex.Message);
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
                    Connect(status);
                };
                pingdevice.SendAsync(ipAddress, 1000, 100);
            }
            catch (Exception ex)
            {
                connected = false;
                RunProgram.LogErr("MCProtocol", "Ping", ex.Message);
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
                    if (!_clientSocket.Connected)
                    {
                        try
                        {
                            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            List<byte> list = new List<byte>(12);
                            list.AddRange(BitConverter.GetBytes(1u));
                            list.AddRange(BitConverter.GetBytes(45000u));
                            list.AddRange(BitConverter.GetBytes(5000u));
                            _clientSocket.IOControl(IOControlCode.KeepAliveValues, list.ToArray(), null);
                            _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                            _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                            connected = true;
                            RunProgram.SendModelData(RunProgram.ModelActive);
                            RunProgram.SendMasterData();
                            RunProgram.SendMotorData();
                            RunProgram.SendLimitData();
                            RunProgram.SendGlueSetting(RunProgram.Settings.GlueActive);
                            RunProgram.SendWrongSetting(RunProgram.Settings.WrongActive);
                            //ReadDeviceBlock("D3800", 500, 3800);
                        }
                        catch (Exception ex)
                        {
                            connected = false;
                            RunProgram.LogErr("MCProtocol", "Connect", ex.Message);
                        }
                        //Thread _threadConnect = new Thread(() =>
                        //{
                        //    try
                        //    {
                        //        _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        //        List<byte> list = new List<byte>(12);
                        //        list.AddRange(BitConverter.GetBytes(1u));
                        //        list.AddRange(BitConverter.GetBytes(45000u));
                        //        list.AddRange(BitConverter.GetBytes(5000u));
                        //        _clientSocket.IOControl(IOControlCode.KeepAliveValues, list.ToArray(), null);
                        //        _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                        //        _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                        //        connected = true;
                        //        RunProgram.SendModelData(RunProgram.ModelActive);
                        //        RunProgram.SendMasterData();
                        //        RunProgram.SendMotorData();
                        //        RunProgram.SendGlueSetting(RunProgram.Settings.GlueActive);
                        //        RunProgram.SendWrongSetting(RunProgram.Settings.WrongActive);
                        //        //ReadDeviceBlock("D3800", 500, 3800);
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        connected = false;
                        //        RunProgram.LogErr("MCProtocol", "Connect", ex.Message);
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
                }
            }
            catch (Exception ex)
            {
                connected = false;
                RunProgram.LogErr("MCProtocol", "Connect", ex.Message);
            }
        }
        private void ReceiveData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                if (remote.Connected)
                {
                    Thread WriteData = new Thread(()=>
                        {
                            try
                            {
                                byte[] byteData = new byte[DeviceSize * 2];
                                int[] intData = new int[DeviceSize];
                                int num = SetResponse(data, out byteData);
                                if (byteData.Length >= DeviceSize * 2)
                                {
                                    for (int i = 0; i < DeviceSize; i++)
                                    {
                                        RunProgram._readPLC[i + ArrayPosition] = ((num == 0) ? BitConverter.ToInt16(byteData, i * 2) : 0);
                                    }
                                }
                                //if(DeviceSize > 0) Console.WriteLine(String.Format("{0}.{1}:{2}", DateTime.Now.Second, DateTime.Now.Millisecond, "end"));
                            }
                            catch
                            {

                            }
                        });
                    WriteData.IsBackground = true;
                    WriteData.Start();
                    _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                    //ReadDeviceBlock("D3800", 500, 3800);
                }
            }
            catch (Exception ex)
            {
                //connected = false;
                RunProgram.LogErr("MCProtocol", "Receive", ex.Message);
                //_clientSocket.Close();
            }

        }
        public int SetResponse(byte[] iResponse,out byte[] response)
        {
            int num = 11;
            if (num <= iResponse.Length)
            {
                byte[] value3 = new byte[2]
                {
                                iResponse[num - 4],
                                iResponse[num - 3]
                };
                byte[] value4 = new byte[2]
                {
                                iResponse[num - 2],
                                iResponse[num - 1]
                };
                int num3 = BitConverter.ToUInt16(value3, 0);
                var ResultCode = BitConverter.ToUInt16(value4, 0);
                response = new byte[num3 - 2];
                Buffer.BlockCopy(iResponse, num, response, 0, response.Length);
                return ResultCode;
            }
            else
            {
                response = null;
                return 0;
            }

           
        }
        public static void ReadDeviceBlock(string iDeviceName, int iSize,int arrayposition)
        {
            ArrayPosition = arrayposition;
            GetDeviceCode(iDeviceName, out PlcDeviceType oType, out int oAddress);
            ReadDeviceBlock(oType, oAddress, iSize);
            //Console.WriteLine("hello");
        }
        private static void ReadDeviceBlock(PlcDeviceType iType, int iAddress, int iSize)
        {
            byte[] iCommand;
            //int minlength;
            List<byte> list = new List<byte>(6)
                    {
                        (byte)iAddress,
                        (byte)(iAddress >> 8),
                        (byte)(iAddress >> 16),
                        (byte)iType,
                        (byte)iSize,
                        (byte)(iSize >> 8)
                    };
            iCommand = SetCommandMC3E(1025u, 0u, list.ToArray());
            DeviceSize = iSize;
            //minlength = 11;
            if (_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Send(iCommand);
                }
                catch (Exception ex)
                {
                    connected = false;
                    RunProgram.LogErr("MCProtocol", "Send", ex.Message);
                    _clientSocket.Close();
                }
            }
        }
        //private static void ReadDeviceBlock(int iAddress, int iSize)
        //{
        //    byte[] iCommand;
        //    int minlength;
        //    List<byte> list = new List<byte>(6)
        //            {
        //                (byte)iAddress,
        //                (byte)(iAddress >> 8),
        //                (byte)(iAddress >> 16),
        //                (byte)PlcDeviceType.D,
        //                (byte)iSize,
        //                (byte)(iSize >> 8)
        //            };
        //    iCommand = SetCommandMC3E(1025u, 0u, list.ToArray());
        //    minlength = 11;
        //    SendToPLC(iCommand);
        //}
        public static void WriteDeviceBlock(string iDeviceName, int iSize, int[] iData, int offsetSend)
        {
            GetDeviceCode(iDeviceName, out PlcDeviceType oType, out int oAddress);
            int[] send = new int[iSize];
            Array.Copy(iData, offsetSend, send,0,iSize);
            //Buffer.BlockCopy(iData, offsetSend, send, 200, iSize);
            WriteDeviceBlock(oType, oAddress, iSize, send);
        }
        private static void WriteDeviceBlock(PlcDeviceType iType, int iAddress, int iSize, int[] iData)
        {
            List<byte> list = new List<byte>();
            foreach (int num in iData)
            {
                list.Add((byte)num);
                list.Add((byte)(num >> 8));
            }

            byte[] iCommand;
            //int minlength;
            List<byte> list2 = new List<byte>(6)
                    {
                        (byte)iAddress,
                        (byte)(iAddress >> 8),
                        (byte)(iAddress >> 16),
                        (byte)iType,
                        (byte)iSize,
                        (byte)(iSize >> 8)
                    };
            list2.AddRange(list.ToArray());
            iCommand = SetCommandMC3E(5121u, 0u, list2.ToArray());
            //minlength = 11;
            SendToPLC(iCommand);
        }
        public static void SetBitDevice(string iDeviceName, int iSize, int[] iData)
        {
            GetDeviceCode(iDeviceName, out PlcDeviceType oType, out int oAddress);
            SetBitDevice(oType, oAddress, iSize, iData);
        }
        private static void SetBitDevice(PlcDeviceType iType, int iAddress, int iSize, int[] iData)
        {
            List<byte> list = new List<byte>(6)
                {
                    (byte)iAddress,
                    (byte)(iAddress >> 8),
                    (byte)(iAddress >> 16),
                    (byte)iType,
                    (byte)iSize,
                    (byte)(iSize >> 8)
                };
            byte b = (byte)iData[0];
            int i;
            for (i = 0; i < iData.Length; i++)
            {
                if (i % 2 == 0)
                {
                    b = (byte)iData[i];
                    b = (byte)(b << 4);
                }
                else
                {
                    b = (byte)(b | (byte)(iData[i] & 1));
                    list.Add(b);
                }
            }

            if (i % 2 != 0)
            {
                list.Add(b);
            }
            byte[] iCommand = SetCommandMC3E(5121u, 1u, list.ToArray());
            SendToPLC(iCommand);
        }
        private static byte[] SetCommandMC3E(uint iMainCommand, uint iSubCommand, byte[] iData)
        {
            uint num = (uint)(iData.Length + 6);
            List<byte> list = new List<byte>(iData.Length + 20);
            uint num2 = 80u;
            list.Add((byte)num2);
            list.Add((byte)(num2 >> 8));
            list.Add((byte)0u);
            list.Add((byte)255u);
            list.Add((byte)255u);
            list.Add((byte)3u);
            list.Add((byte)255u);
            list.Add((byte)num);
            list.Add((byte)(num >> 8));
            list.Add((byte)16u);
            list.Add((byte)(16u >> 8));
            list.Add((byte)iMainCommand);
            list.Add((byte)(iMainCommand >> 8));
            list.Add((byte)iSubCommand);
            list.Add((byte)(iSubCommand >> 8));
            list.AddRange(iData);
            return list.ToArray();
        }
        public static void GetDeviceCode(string iDeviceName, out PlcDeviceType oType, out int oAddress)
        {
            string text = iDeviceName.ToUpper();
            string text2 = text.Substring(0, 1);
            string value;
            switch (text2)
            {
                case "A":
                case "B":
                case "D":
                case "F":
                case "L":
                case "M":
                case "R":
                case "V":
                case "W":
                case "X":
                case "Y":
                    value = text.Substring(1);
                    break;
                case "Z":
                    text2 = text.Substring(0, 2);
                    value = text.Substring((!text2.Equals("ZR")) ? 1 : 2);
                    break;
                case "C":
                    text2 = text.Substring(0, 2);
                    switch (text2)
                    {
                        case "CC":
                        case "CM":
                        case "CN":
                        case "CS":
                        case "CT":
                            break;
                        default:
                            throw new Exception("Invalid format.");
                    }

                    value = text.Substring(2);
                    break;
                case "S":
                    text2 = text.Substring(0, 2);
                    if (text2 == "SD" || text2 == "SM")
                    {
                        value = text.Substring(2);
                        break;
                    }

                    throw new Exception("Invalid format.");
                case "T":
                    text2 = text.Substring(0, 2);
                    switch (text2)
                    {
                        case "TC":
                        case "TM":
                        case "TN":
                        case "TS":
                        case "TT":
                            break;
                        default:
                            throw new Exception("Invalid format.");
                    }

                    value = text.Substring(2);
                    break;
                default:
                    throw new Exception("Invalid format.");
            }

            oType = GetDeviceType(text2);
            oAddress = (IsHexDevice(oType) ? Convert.ToInt32(value, 16) : Convert.ToInt32(value));
        }
        public static PlcDeviceType GetDeviceType(string s)
        {
            switch (s)
            {
                default:
                    return PlcDeviceType.Max;
                case "A":
                    return PlcDeviceType.A;
                case "CM":
                    return PlcDeviceType.CM;
                case "CT":
                    return PlcDeviceType.CT;
                case "TM":
                    return PlcDeviceType.TM;
                case "TT":
                    return PlcDeviceType.TT;
                case "Z":
                    return PlcDeviceType.Z;
                case "SN":
                    return PlcDeviceType.SN;
                case "SS":
                    return PlcDeviceType.SS;
                case "SC":
                    return PlcDeviceType.SC;
                case "CN":
                    return PlcDeviceType.CN;
                case "CS":
                    return PlcDeviceType.CS;
                case "CC":
                    return PlcDeviceType.CC;
                case "TN":
                    return PlcDeviceType.TN;
                case "TS":
                    return PlcDeviceType.TS;
                case "TC":
                    return PlcDeviceType.TC;
                case "SW":
                    return PlcDeviceType.SW;
                case "W":
                    return PlcDeviceType.W;
                case "ZR":
                    return PlcDeviceType.ZR;
                case "R":
                    return PlcDeviceType.R;
                case "SD":
                    return PlcDeviceType.SD;
                case "D":
                    return PlcDeviceType.D;
                case "DY":
                    return PlcDeviceType.DY;
                case "DX":
                    return PlcDeviceType.DX;
                case "SB":
                    return PlcDeviceType.SB;
                case "B":
                    return PlcDeviceType.B;
                case "Y":
                    return PlcDeviceType.Y;
                case "X":
                    return PlcDeviceType.X;
                case "S":
                    return PlcDeviceType.S;
                case "V":
                    return PlcDeviceType.V;
                case "F":
                    return PlcDeviceType.F;
                case "L":
                    return PlcDeviceType.L;
                case "SM":
                    return PlcDeviceType.SM;
                case "M":
                    return PlcDeviceType.M;
            }
        }
        public static bool IsHexDevice(PlcDeviceType type)
        {
            if (type != PlcDeviceType.X && type != PlcDeviceType.Y && type != PlcDeviceType.B)
            {
                return type == PlcDeviceType.W;
            }

            return true;
        }
        private static void SendToPLC(byte[] data)
        {
            Thread ReadData = new Thread(() =>
            {
                try
                {
                    if (_clientSocket.Connected)
                    {
                        try
                        {
                            _clientSocket.Send(data);
                            //RunProgram.LogErr("MCPro","send",data.Length.ToString());
                        }
                        catch (SocketException)
                        {
                            connected = false;
                            _clientSocket.Close();
                        }
                    }
                }
                catch (Exception)
                {
                }
            });
            ReadData.IsBackground = true;
            ReadData.Start();
            
        }
        public enum McFrame
        {
            MC1E = 4,
            MC3E = 11,
            MC4E = 0xF
        }
        public enum PlcDeviceType
        {
            M = 144,
            SM = 145,
            L = 146,
            F = 147,
            V = 148,
            S = 152,
            X = 156,
            Y = 157,
            B = 160,
            SB = 161,
            DX = 162,
            DY = 163,
            D = 168,
            SD = 169,
            R = 175,
            ZR = 176,
            W = 180,
            SW = 181,
            TC = 192,
            TS = 193,
            TN = 194,
            CC = 195,
            CS = 196,
            CN = 197,
            SC = 198,
            SS = 199,
            SN = 200,
            Z = 204,
            TT = 205,
            TM = 206,
            CT = 207,
            CM = 208,
            A = 209,
            Max = 210
        }

    }
}
