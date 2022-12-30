using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace SEMV_Dispencer_V1.Library
{
    public class cDatabase
    {
        public const string ConStr = @"data.db";
        public const string fileISSetting = @"data/ISSetting.json";
        public const string fileASSetting = @"data/ASSetting.json";
        public const string fileSensorSetting = @"data/SensorSetting.json";
        public const string filePLCSetting = @"data/PLCSetting.json";
        public const string fileErrorList = @"data/ErrorList.json";
        public const string filePassword = @"data/Password.json";
        public const string fileAsApp = @"data/AsApp.json";
        public class TSetting
        {
            public int Id { get; set; }
            public int GlueActive { get; set; }
            public int WrongActive { get; set; }
            public double ISMasterX { get; set; }
            public double ISMasterY { get; set; }
            public string Password_Admin { get; set; }
        }
        public class TModel
        {
            public int Id { get; set; }
            public int CamId { get; set; }
            public string ModelName { get; set; }
            public bool Active { get; set; }
            public double CamISX { get; set; }
            public double CamISY { get; set; }
            public double CamISZ { get; set; }
            public double ArrayX1 { get; set; }
            public double ArrayY1 { get; set; }
            public double DistanceX1 { get; set; }
            public double DistanceY1 { get; set; }
            public double ArrayX2 { get; set; }
            public double ArrayY2 { get; set; }
            public double DistanceX2 { get; set; }
            public double DistanceY2 { get; set; }
            public int LightPrd { get; set; }
            public int LightGlue { get; set; }
            public double SpeedCamIS { get; set; }

        }
        public class TMaster
        {
            public int Id { get; set; }
            public string PositionName { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public double Data1 { get; set; }
            public double Data2 { get; set; }

        }
        public class TMotorData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double OriginSpeed { get; set; }
            public double Home { get; set; }
            public double JogLow { get; set; }
            public double JogHigh { get; set; }
            public double Acc { get; set; }
            public double Dec { get; set; }

        }
        public class TData
        {
            public int Id { get; set; }
            public double OffsetZ { get; set; }
            public double OffsetX { get; set; }
            public double OffsetY { get; set; }
            public double LimitNeedleZ1 { get; set; }
            public double LimitNeedleZ2 { get; set; }
            public double LimitNeedleX1 { get; set; }
            public double LimitNeedleX2 { get; set; }
            public double LimitNeedleY1 { get; set; }
            public double LimitNeedleY2 { get; set; }
            public double LimitISZ1 { get; set; }
            public double LimitISZ2 { get; set; }
            public double LimitISX1 { get; set; }
            public double LimitISX2 { get; set; }
            public double LimitISY1 { get; set; }
            public double LimitISY2 { get; set; }
            public double LimitISA1 { get; set; }
            public double LimitISA2 { get; set; }

        }
    }
    public class cCameraISSetting
    {
        private string _ip = "";
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private int _port;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
    }
    public class cCameraASSetting
    {
        private string _ip = "";
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private int _port;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
    }
    public class cSensorSetting
    {
        private string _portName = "";
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }
    }
    public class cPLCSetting
    {
        private string _ip = "";
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private int _port;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
    }
    public class cAppSetting
    {
        private string _fileName = "";
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
    }
}
