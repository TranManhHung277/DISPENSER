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
    public partial class ConMainControlAuto : UserControl
    {
        public ConMainControlAuto()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private async void On_Load()
        {
            await UIControl.UIButton.MaintainButton(btCheckGlue, RunProgram._readPLC, 3800, 7);
            await UIControl.UIButton.SetButton(btEnd, RunProgram._readPLC, 3800, 3);
            await UIControl.UIButton.SetButton(btNextPrd, RunProgram._readPLC, 3800, 6);
            await UIControl.UIButton.SetButton(btNextProcess, RunProgram._readPLC, 3800, 5);
            await UIControl.UIButton.SetButton(btRunToChangePrd, RunProgram._readPLC, 3800, 9);
            await UIControl.UIButton.SetButton(btRunToChangeGlue, RunProgram._readPLC, 3800, 8);//chay tiep tuc

            await UIControl.UIButton.MaintainButton(btLightNeedle, RunProgram._readPLC, 3807, 9);//3590

        }
        private void On_Event()
        {
            UIControl.UIButton.MaintainButtonEvent(btCheckGlue, RunProgram._readPLC, 3800, 7);
            UIControl.UIButton.SetButtonEvent(btEnd, RunProgram._readPLC, 3800, 3);
            UIControl.UIButton.SetButtonEvent(btNextPrd, RunProgram._readPLC, 3800, 6);
            UIControl.UIButton.SetButtonEvent(btNextProcess, RunProgram._readPLC, 3800, 5);
            UIControl.UIButton.SetButtonEvent(btRunToChangePrd, RunProgram._readPLC, 3800, 9);
            UIControl.UIButton.SetButtonEvent(btRunToChangeGlue, RunProgram._readPLC, 3800, 8);//chay tiep tuc

            UIControl.UIButton.MaintainButtonEvent(btLightNeedle, RunProgram._readPLC, 3807, 9);//3590

        }

        private void btRunToChangeGlue_Click(object sender, EventArgs e)
        {

        }
    }
}
