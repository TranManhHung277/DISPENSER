using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UINumberic
    {
        public static void Int16Number(NumericUpDown Numberic, int Address)
        {
            Numberic.ValueChanged += async (object sender, EventArgs e) =>
                {
                    await Task.Delay(1);
                    DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", Address), 1, new int[] {((int)Numberic.Value)} , 0);
                };
        }



    }
}
