using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.Control
{
    public partial class ConDeviceConnection : UserControl
    {
        public ConDeviceConnection()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += LabelData_Start;
        }
        private void LabelData_Start()
        {
            UIControl.UIPicture.StatePicture(pictureBox1,DeviceConnection.cCameraIS.Connected, Properties.Resources.connect, Properties.Resources.disconnect);
            UIControl.UIPicture.StatePicture(pictureBox2,DeviceConnection.cCameraAS.Connected, Properties.Resources.connect, Properties.Resources.disconnect);
            UIControl.UIPicture.StatePicture(pictureBox3,DeviceConnection.cSensorHeight.Connected, Properties.Resources.connect, Properties.Resources.disconnect);
            UIControl.UIPicture.StatePicture(pictureBox4,DeviceConnection.cMCProtocol.Connected, Properties.Resources.connect, Properties.Resources.disconnect);
            if(DeviceConnection.cCameraIS.TriggerOn != 0) label1.BackColor = Color.Green;
            else label1.BackColor = Color.White;
            if (DeviceConnection.cCameraAS.TriggerOn != 0) label2.BackColor = Color.Green;
            else label2.BackColor = Color.White;
            if (DeviceConnection.cSensorHeight.triggerOn != 0) label3.BackColor = Color.Green;
            else label3.BackColor = Color.White;
        }
    }
}
