using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Sres.Net.EEIP;
using System.Net.Sockets;
using System.Net;

namespace SEMV_Dispencer_V1.DeviceConnection
{
    public class cCameraISEIP
    {
        //private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static EEIPClient _clientEip = null;
        private byte[] data = new byte[1000000];

        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Timer timerCheckOnline;

        private readonly object _syncRoot = new object();
        private int _sentPings;
        private int _recievedIpAddresses;
        private static bool connected = false;
        public static string nowCommand = "";
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
        public cCameraISEIP()
        {
            timerPing = new System.Windows.Forms.Timer();
            timerPing.Interval = 1000;
            timerPing.Tick += new EventHandler(timerPing_Tick);
            timerPing.Start();
            timerCheckOnline = new System.Windows.Forms.Timer();
            timerCheckOnline.Interval = 50;
            timerCheckOnline.Tick += new EventHandler(timerCheckOnline_Tick);
            timerCheckOnline.Start();
        }

        private void timerCheckOnline_Tick(object sender, EventArgs e)
        {
            try
            {
                if(connected)
                {
                    byte[] data = _clientEip.GetAttributeAll(13);

                }
            }
            catch (Exception ex)
            {
                RunProgram.LogErr("cCameraIS", "Timer", ex.Message);
            }
            //PingDevice();
        }
        private void timerPing_Tick(object sender, EventArgs e)
        {
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
                                connected = true;
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
                    Connect(status);
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
                    try
                    {
                        _clientEip.IPAddress = IP;
                        //_clientEip.
                        _clientEip.RegisterSession();
                        connected = true;

                    }
                    catch (Exception ex)
                    {
                        connected = false;
                        RunProgram.LogErr("cCameraIS", "Open EIP", ex.Message);
                    }
                    //if (!_clientEip.)
                    //{
                        
                    //    //Thread _threadConnect = new Thread(() =>
                    //    //{
                    //    //    try
                    //    //    {
                    //    //        _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //    //        _clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
                    //    //        _clientSocket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);

                    //    //    }
                    //    //    catch (Exception ex)
                    //    //    {
                    //    //        RunProgram.LogErr("cCameraIS", "Open Socket", ex.Message);
                    //    //    }
                    //    //});
                    //    //_threadConnect.IsBackground = true;
                    //    //_threadConnect.Start();
                    //}
                }
                else
                {
                    connected = false;
                    //if (_clientSocket != null) _clientSocket.Close();
                    RunProgram.LogErr("cCameraIS", "Ping", "Fail");
                }
            }
            catch (Exception)
            {
                RunProgram.LogErr("cCameraIS", "Ping", "Fail");
                connected = false;
            }
        }
    }
}
