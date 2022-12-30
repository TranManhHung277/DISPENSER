using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.UIControl
{
    public class UIButton
    {
        public static async Task MomenteryButton(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            button.BackColor = (state > 0) ? Color.Blue : Color.White;
        }
        public static async Task MomenteryLabel(Label label, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            label.BackColor = (state > 0) ? Color.Blue : Color.White;
        }
        public static async Task SetButton(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            button.BackColor = (state > 0) ? Color.Blue : Color.White;
        }
        public static async Task ResetButton(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            button.BackColor = (state > 0) ? Color.Blue : Color.White;
        }
        public static async Task MaintainButton(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var bitvalue = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            bool state = bitvalue > 0;
            button.BackColor = state  ? Color.Blue : Color.White;
        }
        public static async Task MaintainButton16Bit(Button button, int[] plcRead, int intNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber];
        }
        public static async Task MaintainButton4Bit(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var state1 = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            var state2 = plcRead[intNumber+1] & (int)Math.Pow(2, bitNumber);
            var state3 = plcRead[intNumber+2] & (int)Math.Pow(2, bitNumber);
            var state4 = plcRead[intNumber+3] & (int)Math.Pow(2, bitNumber);
            var state = state1 | state2 | state3 | state4;
        }
        public static async Task MaintainButton4Word(Button button, int[] plcRead, int intNumber)
        {
            await Task.Delay(1);
            var state = plcRead[intNumber] + plcRead[intNumber+1] + plcRead[intNumber+2] + plcRead[intNumber+3];
        }
        public static void MomenteryButtonEvent(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            button.MouseDown += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                button.BackColor = (state > 0) ? Color.Blue : Color.White;
                var va = plcRead[intNumber] | ((int)Math.Pow(2, bitNumber));
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
                button.BackColor = Color.Blue;
            };
            button.MouseUp += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                button.BackColor = (state > 0) ? Color.Blue : Color.White;
                var va = plcRead[intNumber] & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1);
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
                button.BackColor = Color.White;
            };
        }
        public static void MomenteryLabelEvent(Label label, int[] plcRead, int intNumber, int bitNumber)
        {
            label.MouseDown += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                label.BackColor = (state > 0) ? Color.Blue : Color.White;
                var va = plcRead[intNumber] | ((int)Math.Pow(2, bitNumber));
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
                label.BackColor = Color.Blue;
            };
            label.MouseUp += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                label.BackColor = (state > 0) ? Color.Blue : Color.White;
                var va = plcRead[intNumber] & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1);
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
                label.BackColor = Color.White;
            };
        }
        public static void SetButtonEvent(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var va = plcRead[intNumber] | ((int)Math.Pow(2, bitNumber));
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };
        }
        public static void ResetButtonEvent(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                // Console.WriteLine(String.Format("{0}.{1} OFF: PLC[{2}].[{3}].[{4}]", DateTime.Now.Second, DateTime.Now.Millisecond, plcData, intNumber, bitNumber));
                var va = plcRead[intNumber] & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1);
                int[] data = new int[1] { va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };
        }
        public static void MaintainButtonEvent(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var bitvalue = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                bool state = bitvalue > 0;
                var state1 = state ? 1 : 0;
                var value = plcRead[intNumber];
                var value1 = value & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1);
                var value2 = value | (int)Math.Pow(2, bitNumber);
                int[] data = new int[1] { state ? value1 : value2 };
                //plcWrite[intNumber] = state ? value1 : value2;
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };

        }
        public static void MaintainButton16BitEvent(Button button, int[] plcRead, int intNumber)
        {
            
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state = (uint)plcRead[intNumber];
                int[] data = new int[1] { (state > 0) ? 0 : 65535 };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };

        }
        public static void MaintainButton4BitEvent(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state1 = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
                var state2 = plcRead[intNumber + 1] & (int)Math.Pow(2, bitNumber);
                var state3 = plcRead[intNumber + 2] & (int)Math.Pow(2, bitNumber);
                var state4 = plcRead[intNumber + 3] & (int)Math.Pow(2, bitNumber);
                var state = state1 | state2 | state3 | state4;
                for (int i = 0; i < 4; i++)
                {
                    int[] data = new int[1] { (state == 0) ? plcRead[intNumber + i] | (int)Math.Pow(2, bitNumber) : plcRead[intNumber + i] & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1) };
                    DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber + i), 1, data, 0);
                }
            };

        }
        public static void MaintainButton_N_BitEvent(Button button, int[] plcRead, int intNumber, int bitNumber, int n)
        {
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state = 0;
                for(int i = 0; i< n; i++)
                {
                    state |= plcRead[intNumber+i] & (int)Math.Pow(2, bitNumber);
                }
                for (int i = 0; i < n; i++)
                {
                    int[] data = new int[1] { (state == 0) ? plcRead[intNumber + i] | (int)Math.Pow(2, bitNumber) : plcRead[intNumber + i] & ((int)Math.Pow(2, 16) - (int)Math.Pow(2, bitNumber) - 1) };
                    DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber + i), 1, data, 0);
                }
            };

        }
        public static void MaintainButton4WordEvent(Button button, int[] plcRead, int intNumber)
        {
            
            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state = plcRead[intNumber] + plcRead[intNumber + 1] + plcRead[intNumber + 2] + plcRead[intNumber + 3];
                var va = (int)((state == 0) ? 65535u : 0);
                int[] data = new int[4] { va, va, va, va };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 4, data, 0);
            };
            button.MouseDown += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                button.BackColor = Color.Blue;
            };
            button.MouseUp += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                button.BackColor = Color.White;
            };
        }
        public static void MaintainButton_N_WordEvent(Button button, int[] plcRead, int intNumber,int n)
        {

            button.Click += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                var state = 0;
                for (int i = 0; i < n; i++) state += plcRead[intNumber + i];
                var va = (int)((state == 0) ? 65535u : 0);
                int[] data = new int[n];
                for (int i = 0; i < n; i++)
                {
                    data[i] = va;
                }
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), n, data, 0);
            };
            button.MouseDown += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                button.BackColor = Color.Blue;
            };
            button.MouseUp += async (object sender, MouseEventArgs e) =>
            {
                await Task.Delay(1);
                button.BackColor = Color.White;
            };
        }
        public static void ChangeNumberEvent(NumericUpDown Numeric, int[] plcRead, int intNumber)
        {

            Numeric.ValueChanged += async (object sender, EventArgs e) =>
            {
                await Task.Delay(1);
                int[] data = new int[1] { Convert.ToInt32(Numeric.Value) };
                DeviceConnection.cMCProtocol.WriteDeviceBlock(String.Format("D{0}", intNumber), 1, data, 0);
            };

        }
    }
}
