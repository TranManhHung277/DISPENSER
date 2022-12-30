using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UIPingDevice: Ping
    {
        public delegate void ExtendedPingCompleted(object sender, PingCompletedEventArgs e, string ip);
        public event ExtendedPingCompleted OnExtendedPingCompleted;

        private string _ip;

        public UIPingDevice(string ip)
        {
            _ip = ip;
            PingCompleted += ExtendedPing_PingCompleted;
        }

        void ExtendedPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (OnExtendedPingCompleted != null)
            {
                OnExtendedPingCompleted(sender, e, _ip);
            }
        }
    }
}
