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
    public partial class ConCoordinate : UserControl
    {
        public double XCoordinate
        {
            get 
            {
                try
                {
                    return Convert.ToDouble(lbX.Text);
                }
                catch 
                { 
                    return 0;
                }
               
            }
        }
        public double YCoordinate
        {
            get
            {
                try
                {
                    return Convert.ToDouble(lbY.Text);
                }
                catch
                {
                    return 0;
                }

            }
        }
        public double ZCoordinate
        {
            get
            {
                try
                {
                    return Convert.ToDouble(lbZ.Text);
                }
                catch
                {
                    return 0;
                }

            }
        }
        public ConCoordinate()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += LabelData_Start;
        }
        private void LabelData_Start()
        {
            UIControl.UILabel.Int32Label(lbX, RunProgram._readPLC, 4016,1);
            UIControl.UILabel.Int32Label(lbY, RunProgram._readPLC, 4018,1);
            UIControl.UILabel.Int32Label(lbZ, RunProgram._readPLC, 4020,1);
            UIControl.UILabel.Int32Label(lbSpeedX, RunProgram._readPLC, 4022,1);
            UIControl.UILabel.Int32Label(lbSpeedY, RunProgram._readPLC, 4024,1);
            UIControl.UILabel.Int32Label(lbSpeedZ, RunProgram._readPLC, 4026,1);
            UIControl.UIPicture.BitPicture(pcX, RunProgram._readPLC, 4106,5,Properties.Resources.running,Properties.Resources.Stand);
            UIControl.UIPicture.BitPicture(pcY, RunProgram._readPLC, 4106,15,Properties.Resources.running,Properties.Resources.Stand);
            UIControl.UIPicture.BitPicture(pcZ, RunProgram._readPLC, 4107,5,Properties.Resources.running,Properties.Resources.Stand);
        }
        private void ConCoordinate_Load(object sender, EventArgs e)
        {
        }
    }
}
