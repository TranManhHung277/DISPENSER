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
    public partial class ConMainControl : UserControl
    {
        public ConMainControl()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private async void On_Load()
        {
            await UIControl.UIButton.SetButton(btReturn, RunProgram._readPLC, 3800, 0);
            await UIControl.UIButton.MomenteryButton(btReset, RunProgram._readPLC, 3800, 2);
            await UIControl.UIButton.MaintainButton(btAuto, RunProgram._readPLC, 3800, 1);

        }
        private void On_Event()
        {
            UIControl.UIButton.SetButtonEvent(btReturn, RunProgram._readPLC, 3800, 0);
            UIControl.UIButton.MomenteryButtonEvent(btReset, RunProgram._readPLC, 3800, 2);
            UIControl.UIButton.MaintainButtonEvent(btAuto, RunProgram._readPLC, 3800, 1);

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            DeviceConnection.cCameraAS.TriggerOn = 0;
            DeviceConnection.cCameraIS.TriggerOn = 0;
            DeviceConnection.cCameraIS.nowCommand = DeviceConnection.ISCommand.None;
            DeviceConnection.cSensorHeight.triggerOn = 0;

        }
    }
}
