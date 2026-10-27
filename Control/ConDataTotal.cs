using LiteDB;
using Newtonsoft.Json.Linq;
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
    public partial class ConDataTotal : UserControl
    {
        public ConDataTotal()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private void On_Load()
        {
            UIControl.UILabel.Int32Label(lbZ, RunProgram._readPLC, 4036, 1);
            UIControl.UILabel.Int32Label(lbX, RunProgram._readPLC, 4038, 1);
            UIControl.UILabel.Int32Label(lbY, RunProgram._readPLC, 4040, 1);

            UIControl.UILabel.Int32Label(lbOK, RunProgram._readPLC, 4012,100);
            UIControl.UILabel.Int32Label(lbTotal, RunProgram._readPLC, 4014, 100);
            UIControl.UILabel.Int32Label(lbPrdX1 , RunProgram._readPLC, 4078,100);
            UIControl.UILabel.Int32Label(lbPrdY1, RunProgram._readPLC, 4080,100);
            UIControl.UILabel.Int32Label(lbPrdX2, RunProgram._readPLC, 4008, 100);
            UIControl.UILabel.Int32Label(lbPrdY2, RunProgram._readPLC, 4010, 100);
            nudOffsetZ.Value = Convert.ToDecimal(RunProgram.Data.OffsetZ);
            UIControl.UIButton.MomenteryLabel(lbClear, RunProgram._readPLC, 3800,10);
          

        }
        private void On_Event()
        {
            UIControl.UIButton.MomenteryLabelEvent(lbClear, RunProgram._readPLC, 3800, 10);
        }

        private void lbClear_Click(object sender, EventArgs e)
        {

        }

        private void nudOffsetZ_ValueChanged(object sender, EventArgs e)
        {
            //RunProgram.Data.OffsetZ =  (double)nudOffsetZ.Value;
            RunProgram.SendOffsetZ((double)nudOffsetZ.Value);
        }
    }
}
