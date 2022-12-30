using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UIValueTranform
    {
        public static double Int32ToDouble(int value1,int value2,int scale)
        {
            int value = 0;
            UInt16 udata1 = (UInt16)value1;
            UInt16 udata2 = (UInt16)value2;
            uint uvalue = ((uint)udata2 << 16) + (uint)udata1;
            if (uvalue > Math.Pow(2, 32))
            {
                value = (int)(-1 * (Math.Pow(2, 32) - uvalue)*scale);
            }
            else value = (int)uvalue*scale;
            return (double)value / 100;
        }
        public static void DoubleRound(double invalue,int round, out double outvalue)
        {
            double va = invalue/ Math.Pow(10, round);
            double va1 = Math.Round(va, 0);
            outvalue = va1 * Math.Pow(10, round);
        }
        public static void DoubleToInt32(double value, out int valueInt1, out int valueInt2, int mul)
        {
            int intValue = Convert.ToInt32(value * mul);
            valueInt2 = intValue >> 16;
            valueInt1 = intValue - valueInt2 * (int)Math.Pow(2, 16);
        }
        public static int DoubleToInt16(double value)
        {
            return Convert.ToInt32(value);
        }
        public static bool Int32ToBool(int value, int trueValue = 1)
        {
            return value == trueValue;
        }


        public static string DisplayInt32(int value)
        {
            return value.ToString();
        }

        public static string Int32ToDoubleString(int value1, int value2,int scale)
        {
            return Int32ToDouble((int)value1,(int)value2,scale).ToString();
        }

        public static string Int32ToBoolString(int value, string trueText = "OK", string falseText = "NG", int trueValue = 1)
        {
            if (Int32ToBool(value, trueValue))
            {
                return trueText;
            }
            return falseText;
        }
        public static bool Int32ToBoolenValue(int valueInt, int bitposition)
        {
            if (RunProgram._readPLC[4103] > 0)
            {

            }
            var bitvalue = valueInt & (int)Math.Pow(2, bitposition);
            return bitvalue > 0 ? true :false;
        }
    }
}
