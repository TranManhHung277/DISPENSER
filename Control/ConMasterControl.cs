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
    public partial class ConMasterControl : UserControl
    {
        public ConMasterControl()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private async void On_Load()
        {
            await UIControl.UIButton.MaintainButton(btLightPrd, RunProgram._readPLC, 3807, 8);
            await UIControl.UIButton.MaintainButton(btLightNeedle, RunProgram._readPLC, 3807, 9);//3590

            await UIControl.UIButton.SetButton(btCamUp, RunProgram._readPLC, 3807, 0);//3590
            await UIControl.UIButton.SetButton(btToNozzle, RunProgram._readPLC, 3807, 1);//3590
            await UIControl.UIButton.SetButton(btToSensor, RunProgram._readPLC, 3807, 2);//3590
            await UIControl.UIButton.SetButton(btZNozzle, RunProgram._readPLC, 3807, 4);//3590
            await UIControl.UIButton.SetButton(btXYNozzle, RunProgram._readPLC, 3807, 5);//3590
            await UIControl.UIButton.SetButton(btChangeNozzle, RunProgram._readPLC, 3807, 6);//3590
            await UIControl.UIButton.SetButton(btChangeTray, RunProgram._readPLC, 3807, 7);//3590

            await UIControl.UIButton.SetButton(btSetZMaster, RunProgram._readPLC, 3811, 4);//3590
            await UIControl.UIButton.SetButton(btSetXYMaster, RunProgram._readPLC, 3811, 5);//3590
            await UIControl.UIButton.SetButton(btSetMasterSensor, RunProgram._readPLC, 3811, 6);//3590


        }
        private void On_Event()
        {

            UIControl.UIButton.MaintainButtonEvent(btLightPrd, RunProgram._readPLC, 3807, 8);
            UIControl.UIButton.MaintainButtonEvent(btLightNeedle, RunProgram._readPLC, 3807, 9);
            UIControl.UINumberic.Int16Number(numericUpDown1, 3590);

            UIControl.UIButton.SetButtonEvent(btCamUp, RunProgram._readPLC, 3807, 0);//3590
            UIControl.UIButton.SetButtonEvent(btToNozzle, RunProgram._readPLC, 3807, 1);//3590
            UIControl.UIButton.SetButtonEvent(btToSensor, RunProgram._readPLC, 3807, 2);//3590
            UIControl.UIButton.SetButtonEvent(btZNozzle, RunProgram._readPLC, 3807, 4);//3590
            UIControl.UIButton.SetButtonEvent(btXYNozzle, RunProgram._readPLC, 3807, 5);//3590
            UIControl.UIButton.SetButtonEvent(btChangeNozzle, RunProgram._readPLC, 3807, 6);//3590
            UIControl.UIButton.SetButtonEvent(btChangeTray, RunProgram._readPLC, 3807, 7);//3590

            UIControl.UIButton.SetButtonEvent(btSetZMaster, RunProgram._readPLC, 3811, 4);//3590
            UIControl.UIButton.SetButtonEvent(btSetXYMaster, RunProgram._readPLC, 3811, 5);//3590
            UIControl.UIButton.SetButtonEvent(btSetMasterSensor, RunProgram._readPLC, 3811, 6);//3590

        }

        private void btnCamPrd_Click(object sender, EventArgs e)
        {
            
           DeviceConnection.cCameraIS.TriggerOn = 1;
            DeviceConnection.cCameraIS.Trigger();
        }

        private void btCamNeedle_Click(object sender, EventArgs e)
        {
            DeviceConnection.cCameraAS.Trigger();
            //DeviceConnection.cCameraAS.CalibCamAS();
        }

        private void btSensor_Click(object sender, EventArgs e)
        {
            DeviceConnection.cSensorHeight.Trigger();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
