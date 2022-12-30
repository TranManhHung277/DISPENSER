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
    public partial class ConAxisControl : UserControl
    {
        public ConAxisControl()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private async void On_Load()
        {
            await UIControl.UIButton.MomenteryButton(btX1, RunProgram._readPLC, 3805, 0);
            await UIControl.UIButton.MomenteryButton(btX2, RunProgram._readPLC, 3805, 1);
            await UIControl.UIButton.MomenteryButton(btY1, RunProgram._readPLC, 3805, 2);
            await UIControl.UIButton.MomenteryButton(btY2, RunProgram._readPLC, 3805, 3);
            await UIControl.UIButton.MomenteryButton(btZ1, RunProgram._readPLC, 3805, 4);
            await UIControl.UIButton.MomenteryButton(btZ2, RunProgram._readPLC, 3805, 5);

            await UIControl.UIButton.MaintainButton(bt001, RunProgram._readPLC, 3805, 7);
            await UIControl.UIButton.MaintainButton(bt01, RunProgram._readPLC, 3805, 8);
            await UIControl.UIButton.MaintainButton(bt1, RunProgram._readPLC, 3805, 9);
            await UIControl.UIButton.MaintainButton(btMode, RunProgram._readPLC, 3805, 6);
            await UIControl.UIButton.MaintainButton(btSpeed, RunProgram._readPLC, 3805, 10);
        }
        private void On_Event()
        {
            UIControl.UIButton.MomenteryButtonEvent(btX1, RunProgram._readPLC, 3805, 0);
            UIControl.UIButton.MomenteryButtonEvent(btX2, RunProgram._readPLC, 3805, 1);
            UIControl.UIButton.MomenteryButtonEvent(btY1, RunProgram._readPLC, 3805, 2);
            UIControl.UIButton.MomenteryButtonEvent(btY2, RunProgram._readPLC, 3805, 3);
            UIControl.UIButton.MomenteryButtonEvent(btZ1, RunProgram._readPLC, 3805, 4);
            UIControl.UIButton.MomenteryButtonEvent(btZ2, RunProgram._readPLC, 3805, 5);

            UIControl.UIButton.MaintainButtonEvent(bt001, RunProgram._readPLC, 3805, 7);
            UIControl.UIButton.MaintainButtonEvent(bt01, RunProgram._readPLC, 3805, 8);
            UIControl.UIButton.MaintainButtonEvent(bt1, RunProgram._readPLC, 3805, 9);
            UIControl.UIButton.MaintainButtonEvent(btMode, RunProgram._readPLC, 3805, 6);
            UIControl.UIButton.MaintainButtonEvent(btSpeed, RunProgram._readPLC, 3805, 10);
        }

    }
}
