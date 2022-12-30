using SEMV_Dispencer_V1.UIControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.Control
{
    public partial class ConModelControl : UserControl
    {
        public ConModelControl()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
            _timer1= new Timer();
            _timer1.Interval = 10;
            _timer1.Tick += timer1_Tick;
        }
        private Timer _timer1;
        public Timer Timer1
        {
            get
            {
                return _timer1;
            }
            set
            {
                _timer1 = value;
            }
        }    
        private async void On_Load()
        {
            await UIControl.UIButton.MaintainButton(btLightPrd, RunProgram._readPLC, 3807, 10);
            await UIControl.UIButton.MaintainButton(btLightGlue, RunProgram._readPLC, 3807, 11);

            await UIControl.UIButton.MaintainButton(btnLightOn, RunProgram._readPLC, 3807, 8);
            await UIControl.UIButton.SetButton(btnToXY, RunProgram._readPLC, 3808, 2);

        }
        private void On_Event()
        {
            UIControl.UIButton.MaintainButtonEvent(btLightPrd, RunProgram._readPLC, 3807, 10);
            UIControl.UIButton.MaintainButtonEvent(btLightGlue, RunProgram._readPLC, 3807, 11);
           // UIControl.UIButton.SetButtonEvent(btnToXY, RunProgram._readPLC, 3808, 2);
            UIControl.UINumberic.Int16Number(nudLight, 3590);
            //UIControl.UINumberic.Int16Number(nudX, 3450);
            //UIControl.UINumberic.Int16Number(nudY, 3452);

        }

        private void btnCameraTrigger_Click(object sender, EventArgs e)
        {
            if (!_timer1.Enabled)
            {
                btnCameraTrigger.BackColor = Color.Blue;
                _timer1.Enabled = true;
            }
            else
            {
                btnCameraTrigger.BackColor = Color.White;
                _timer1.Enabled = false;

            }
        }

        private void btnToXY_Click(object sender, EventArgs e)
        {
            int[] value = new int[8] { (int)nudX1.Value, 0, (int)nudY1.Value, 0,(int)nudX2.Value, 0, (int)nudY2.Value, 0 };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3470), 8, value, 0);
            var va = RunProgram._readPLC[3808] | ((int)Math.Pow(2, 2));
            int[] data = new int[1] { va };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3808), 1, data, 0);
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
            int[] value = new int[2] { (int)nudLight.Value, 0};
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3590), 2, value, 0);

            var bitvalue = RunProgram._readPLC[3807] & (int)Math.Pow(2, 8);
            bool state = bitvalue > 0;
            var state1 = state ? 1 : 0;
            var val = RunProgram._readPLC[3807];
            var value1 = val & (((int)Math.Pow(2, 16) - (int)Math.Pow(2, 8) - 1));
            var value2 = val | (int)Math.Pow(2, 8);
            int[] data1 = new int[1] { state ? value1 : value2 };
            //plcWrite[intNumber] = state ? value1 : value2;
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3807), 1, data1, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DeviceConnection.cCameraIS.TriggerOn == 0)
            {
                DeviceConnection.cCameraIS.TriggerOn = 1;
                DeviceConnection.cCameraIS.Trigger();
            }
                
        }
    }
}
