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

namespace SEMV_Dispencer_V1.DeviceConnection
{
    public class cCameraAS
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] data = new byte[1024];
        private System.Windows.Forms.Timer timerPing;
        private readonly object _syncRoot = new object();
        private int _sentPings;
        private int _recievedIpAddresses;
        private static bool connected = false;
        public static bool Connected
        {
            get { return connected; }
            set { connected = value; }
        }
        public static bool isCalib = false;
        public static string[] NeedleData;
        public static int TriggerOn = 0;
        private static cCameraAS _instance;
        public static cCameraAS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new cCameraAS();
                }
                return _instance;
            }
        }
        private Library.cCameraASSetting _setting;
        public Library.cCameraASSetting Setting
        {
            get
            {
                if (this._setting == null)
                {
                    if (File.Exists(Library.cDatabase.fileASSetting))
                    {
                        try
                        {
                            this._setting = JsonConvert.DeserializeObject<Library.cCameraASSetting>(File.ReadAllText(Library.cDatabase.fileASSetting));
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        this._setting = new Library.cCameraASSetting
                        {
                            Ip = "192.168.0.13",
                            Port = 7890
                        };
                        Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileASSetting));
                        File.WriteAllText(Library.cDatabase.fileASSetting, JsonConvert.SerializeObject(this._setting));
                    }
                }
                return this._setting;
            }
            set
            {
                this._setting = value;
                Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileASSetting));
                File.WriteAllText(Library.cDatabase.fileASSetting, JsonConvert.SerializeObject(this._setting));
            }
        }
        public cCameraAS()
        {
            timerPing = new System.Windows.Forms.Timer();
            timerPing.Interval = 1000;
            timerPing.Tick += new EventHandler(timerPing_Tick);
            timerPing.Start();
            
        }
        void timerPing_Tick(object sender, EventArgs e)
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
                RunProgram.LogErr("CameraAS", "Ping", ex.Message);
            }
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
                        RunProgram.LogErr("CameraAS", "Ping", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        RunProgram.LogErr("CameraAS", "Ping", ex.Message);
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
                RunProgram.LogErr("CameraAS", "Ping", ex.Message);
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
                            _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                            _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                            connected = true;
                            // CalibCamAS();
                        }
                        catch (Exception ex)
                        {
                            connected = false;
                            RunProgram.LogErr("CameraAS", "Ping", ex.Message);
                        }
                        //Thread _threadConnect = new Thread(() =>
                        //{
                        //    try
                        //    {
                        //        _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        //        _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                        //        _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                        //        connected = true;
                        //       // CalibCamAS();
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        connected = false;
                        //        RunProgram.LogErr("CameraAS", "Ping", ex.Message);
                        //    }
                        //});
                        //_threadConnect.IsBackground = true;
                        //_threadConnect.Start();
                    }
                }
                else
                {
                    connected = false;
                    if(_clientSocket != null) _clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                connected = false;
                RunProgram.LogErr("CameraAS", "Connect", ex.Message);
            }
        }
        private void ReceiveData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                if (remote.Connected)
                {
                    int recv = remote.EndReceive(iar);
                    if(recv > 2)
                    {
                        string stringData = Encoding.ASCII.GetString(data, 0, recv);
                        string stringSeparators = stringData.Substring(0, stringData.Length - 2);
                        string[] lines = stringSeparators.Split(',');
                        if (lines.Length > 1)
                        {
                            if (lines[0] == "TA" && lines[1] == "1")
                            {
                                SendToServer(Encoding.ASCII.GetBytes("XA,1,Abs,0,0,0,0,0,0" + "\r\n"));
                            }
                            else if (lines[0] == "XA" && lines[1] == "1")
                            {
                                SendToServer(Encoding.ASCII.GetBytes("SGP,1,Cam2D,0,0,0" + "\r\n"));
                            }
                            else if (lines[0] == "SGP" && lines[1] == "1")
                            {
                                SendToServer(Encoding.ASCII.GetBytes("GGP,1,Cam2D" + "\r\n"));
                            }
                            else if (lines[0] == "GGP" && lines[1] == "1")
                            {
                                SendToServer(Encoding.ASCII.GetBytes("GCP,1,Cam2D,0,0,0,0,0,0" + "\r\n"));
                            }
                            if (lines[0] == "GCP")
                            {
                                isCalib = false;
                                HandleData(lines);
                            }

                        }
                    }
                    
                    _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                }
            }
            catch (SocketException ex)
            {
                connected = false;
                _clientSocket.Close();
                RunProgram.LogErr("CameraAS", "Receive", ex.Message);
            }

        }
        private static void SendToServer(byte[] data)
        {
            if (_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Send(data);
                }
                catch (SocketException ex)
                {
                    RunProgram.LogErr("CameraAS", "Send", ex.Message);
                    connected = false;
                    _clientSocket.Close();
                }
            }
        }
        private void HandleData(string[] data)
        {
            NeedleData = data;
            TriggerOn = 2;
            //RunProgram.LogDeviceAction("Cam AS", "Trigger Done");
        }
        public static void Trigger()
        {
            RunProgram.LogDeviceAction("Cam AS", "Trigger");
            //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3817), 1, new int[1] { 1 }, 0);
            //int[] arrayInt = new int[8];
            //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3720), arrayInt.Length, arrayInt, 0);
            SendToServer(Encoding.ASCII.GetBytes("GCP,1,Cam2D,0,0,0,0,0,0" + "\r\n"));
        }
        public static void CalibCamAS()
        {
            isCalib = true;
            SendToServer(Encoding.ASCII.GetBytes("TA,1" + "\r\n"));
        }
    }
}
