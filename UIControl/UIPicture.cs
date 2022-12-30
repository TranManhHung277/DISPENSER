using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UIPicture
    {
        public static void BitPicture(PictureBox picture, int[] plcData, int intNumber, int bitNumber, Bitmap truepic, Bitmap falsepic)
        {
            var state = plcData[intNumber] & (int)Math.Pow(2, bitNumber);
            picture.BackgroundImage = (state > 0) ? truepic : falsepic;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static void StatePicture(PictureBox picture, bool state, Bitmap truepic, Bitmap falsepic)
        {
            picture.BackgroundImage = state ? truepic : falsepic;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
