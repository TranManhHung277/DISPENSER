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
    public partial class ConModelTest : UserControl
    {
        public ConModelTest()
        {
            InitializeComponent();
            RunProgram.Instance.OnStartUp += On_Load;
            On_Event();
        }
        private  void On_Load()
        {
             UIControl.UIButton.SetButton(btnCheckZNozze, RunProgram._readPLC, 3807, 4);//3690
             UIControl.UIButton.SetButton(btnCheckXYNozzle, RunProgram._readPLC, 3807, 5);//3690

        }
        private void On_Event()
        {

            UIControl.UIButton.SetButtonEvent(btnCheckZNozze, RunProgram._readPLC, 3807, 4);//3690
            UIControl.UIButton.SetButtonEvent(btnCheckXYNozzle, RunProgram._readPLC, 3807, 5);//3690

        }
        private void btnCheckXYPrd_Click(object sender, EventArgs e)
        {
            // Send X Y
            int[] value = new int[8] { (int)nudX1.Value, 0, (int)nudY1.Value, 0 , (int)nudX2.Value, 0, (int)nudY2.Value, 0, };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3470), 8, value, 0);
            // Set to Start
            var va = RunProgram._readPLC[3808] | ((int)Math.Pow(2, 12));
            int[] data = new int[1] { va };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3808), 1, data, 0);
        }

        private void btnCheckZPrd_Click(object sender, EventArgs e)
        {
            //// Send X Y
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;
            int value6 = 0;
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetX.Value, out value1, out value2, 100);
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetY.Value, out value3, out value4, 100);
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetZ.Value, out value5, out value6, 100);
            int[] value = new int[8] { (int)nudCount.Value, 0, value1, value2, value3, value4, value5, value6 };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3480), 8, value, 0);
            var va = RunProgram._readPLC[3808] | ((int)Math.Pow(2, 13));
            int[] data = new int[1] { va };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3808), 1, data, 0);
        }

        private void btnToBondPoint_Click(object sender, EventArgs e)
        {
            
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;
            int value6 = 0;
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetX.Value, out value1, out value2, 100);
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetY.Value, out value3, out value4, 100);
            UIControl.UIValueTranform.DoubleToInt32((double)nudOffsetZ.Value, out value5, out value6, 100);
            int[] value = new int[8] { (int)nudCount.Value, 0, value1,value2,value3,value4,value5,value6 };

            // Send X Y
            
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3480), 8, value, 0);
            var va = RunProgram._readPLC[3808] | ((int)Math.Pow(2, 14));
            int[] data = new int[1] { va };
            DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", 3808), 1, data, 0);
        }
    }
}
