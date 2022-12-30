using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SEMV_Dispencer_V1.DeviceConnection
{
    public class cSensorHeight
    {
        private static SerialPort serialPort;
        private System.Windows.Forms.Timer timerPing;
        private static bool connected;
        public static bool Connected
        {
            get { return connected; }
        }
        private static bool done;
        public static bool Done
        {
            get { return done; }
        }
        private static int sensorHeight;
        public static int SensorHeight
        {
            get 
            {
                return sensorHeight; 
            }

        }
        public static int triggerOn = 0;
        private Library.cSensorSetting _setting;
        public Library.cSensorSetting Setting
        {
            get
            {
                if (this._setting == null)
                {
                    if (File.Exists(Library.cDatabase.fileSensorSetting))
                    {
                        try
                        {
                            this._setting = JsonConvert.DeserializeObject<Library.cSensorSetting>(File.ReadAllText(Library.cDatabase.fileSensorSetting));
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        this._setting = new Library.cSensorSetting
                        {
                            PortName = "COM4"
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
                Directory.CreateDirectory(Path.GetDirectoryName(Library.cDatabase.fileSensorSetting));
                File.WriteAllText(Library.cDatabase.fileSensorSetting, JsonConvert.SerializeObject(this._setting));
            }
        }
        public cSensorHeight()
        {
            timerPing = new System.Windows.Forms.Timer();
            timerPing.Interval = 1000;
            timerPing.Tick += new EventHandler(timerPing_Tick);
            timerPing.Start();
            Connect();
        }
        void timerPing_Tick(object sender, EventArgs e)
        {
            if(serialPort != null)
            {
                if (!serialPort.IsOpen)
                    Connect();
                else if (!connected)
                {
                    serialPort.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();
                    connected = true;
                }
            }  
            else Connect();

        }
        private void Connect()
        {
            //serialPort = new SerialPort();
            serialPort = OpenPort(Setting.PortName, "38400", "8", "1", "None");
            if(serialPort != null)
            {
                if (serialPort.IsOpen) serialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                else serialPort.DataReceived -= new SerialDataReceivedEventHandler(Port_DataReceived);
            }    
            
        }
        private int bytes = 0;
        private void Port_DataReceived(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                do
                {
                    bytes = serialPort.BytesToRead;
                }
                while (bytes < 18);
                byte[] data = new byte[18];
                serialPort.Read(data, 0, data.Length);
                string value = Encoding.UTF8.GetString(data);
                HandleData(value);
            }
            catch(Exception ex)
            {
                RunProgram.LogErr("SensorHeight", "Receive", ex.Message);
            }
        }
        private void HandleData(string data)
        {
            string valueString = data.Substring(7,8);
            sensorHeight = Convert.ToInt32(valueString);
            triggerOn = 2;
            //Console.WriteLine(String.Format("{0}.{1}:{2}", DateTime.Now.Second, DateTime.Now.Millisecond, sensorHeight));
            //RunProgram.LogDeviceAction("SS Height", "Trigger Done");
            serialPort.DiscardInBuffer();
        }
        public static SerialPort OpenPort(string portName, string baudRate, string dataLength, string stopBit, string parityBit)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports != null)
            {
                if (ports.Contains(portName))
                {
                    SerialPort serialport = new SerialPort();
                    try
                    {
                        serialport.PortName = portName;
                        try
                        {
                            serialport.Dispose();
                        }
                        catch
                        { }
                        //if (serialport.IsOpen) serialport.Close();
                        serialport.BaudRate = Convert.ToInt32(baudRate);
                        if (dataLength == "7 bits") serialport.DataBits = 7;
                        else serialport.DataBits = 8;
                        switch (stopBit)
                        {
                            case "None":
                                {
                                    serialport.StopBits = StopBits.None;
                                    break;
                                }
                            case "1":
                                {
                                    serialport.StopBits = StopBits.One;
                                    break;

                                }
                            case "2":
                                {
                                    serialport.StopBits = StopBits.Two;
                                    break;
                                }

                        }
                        switch (parityBit)
                        {
                            case "None":
                                {
                                    serialport.Parity = Parity.None;
                                    break;
                                }
                            case "Odd":
                                {
                                    serialport.Parity = Parity.Odd;
                                    break;

                                }
                            case "Even":
                                {
                                    serialport.Parity = Parity.Even;
                                    break;
                                }

                        }
                        serialport.Open();
                        connected = true;
                        return serialport;
                    }
                    catch (Exception ex)
                    {
                        RunProgram.LogErr("SensorHeight", "Receive", ex.Message);
                        done = false;
                        connected = false;
                        try
                        {
                            serialport.Dispose();
                            return null;
                        }
                        catch
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    connected = false;
                    return null;
                }
            }
            else
            {
                connected = false;
                return null;
            }

        }
        public static void Trigger()
        {
            try
            {
                //RunProgram.LogDeviceAction("SS Height", "Start Trigger");
                //cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3818), 1, new int[1] { 1 }, 0);
                int[] arrayInt = new int[4];
                arrayInt[0] = 0;
                arrayInt[1] = 0;
                arrayInt[2] = 0;
                arrayInt[3] = 0;
                cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3730), arrayInt.Length, arrayInt, 0);
                serialPort.WriteLine("%01#RMD5C\r");
                //Console.WriteLine(String.Format("{0}.{1}: {2}", DateTime.Now.Second, DateTime.Now.Millisecond, "Start SS Trigger"));

            }
            catch (ArgumentNullException ex)
            {
                done = false;
                connected = false;
                RunProgram.LogErr("SS Height", "Trigger", ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                done = false;
                connected = false;
                RunProgram.LogErr("SS Height", "Trigger", ex.Message);
            }
            catch (TimeoutException ex)
            {
                done = false;
                connected = false;
                RunProgram.LogErr("SS Height", "Trigger", ex.Message);
            }
            catch (Exception ex)
            {
                done = false;
                if(serialPort != null)
                {
                    serialPort.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();
                }
                
                RunProgram.LogErr("SS Height","Trigger",ex.Message);
            }
        }
        public static void Dispose()
        {
            if (serialPort != null)
            {
                connected = false;
                serialPort.Dispose();
            }
                
        }

    }
}
