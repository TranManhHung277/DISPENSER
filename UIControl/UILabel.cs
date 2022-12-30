using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UILabel
    {
        public static void BitLabel(Label label, int[] plcData, int intNumber, int bitNumber,string trueText, string falseText)
        {
            var state = plcData[intNumber] & (int)Math.Pow(2, bitNumber);
            label.Text = (state > 0) ? trueText: falseText;
        }

        public static void Int32Label(Label label, int[] plcData, int intNumber, int scale)
        {
            //if(label.Name == "lbX")
           label.Text = UIControl.UIValueTranform.Int32ToDoubleString(plcData[intNumber], plcData[intNumber+1],scale);
        }
        public static string Int16String(int data, string[] display)
        {
            string value = "";
            for(int i = 0; i < display.Length; i++)
            {
                if(data == i) value = display[i];
            }
            return value;
        }
    }
}
