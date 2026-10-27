using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UIComboBox
    {
        public static async Task BitCombobox(ComboBox box, int[] plcRead, int intNumber, int bitNumber)
        {
            //await Task.Delay(1);
            var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            box.SelectedIndex = (state > 0) ? 1 : 0;
        }
        public static void BitComboboxEvent(ComboBox box, int[] plcRead, int intNumber, int bitNumber)//3800.11
        {
            box.SelectedIndexChanged += async (object sender, EventArgs e) =>
            {
                //await Task.Delay(1);
                int[] data = new int[1];
                if (box.SelectedIndex == 0) 
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };
        }
    }
}
