using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.Screen
{
    public partial class frmProduct1 : Form
    {
        private delegate void UpdateButton();
        private event UpdateButton Check;
        private int x1=-1, x2=-1, y1=-1, y2=-1;
        private int _Width = 50,_Height = 50;
        private Button[] arrayButton;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x1 != (int)RunProgram.ModelActive.ArrayX1 || x2 != (int)RunProgram.ModelActive.ArrayX2 || y1 != (int)RunProgram.ModelActive.ArrayY1 || y2 != (int)RunProgram.ModelActive.ArrayY2)
                Create_Table();
            if (Check != null)
            {
                Check();
            }
        }

        private void frmProduct1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void frmProduct1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.ChoosePrdForm = false;
        }

        private static int PLCDevice = 3830;
        public frmProduct1()
        {
            InitializeComponent();
            Create_Table();
        }
        public void Create_Table()
        {
            x1 = (int)RunProgram.ModelActive.ArrayX1;
            x2 = (int)RunProgram.ModelActive.ArrayX2;
            y1 = (int)RunProgram.ModelActive.ArrayY1;
            y2 = (int)RunProgram.ModelActive.ArrayY2;
            Check = null;
            this.Controls.Clear();
            int index = 0;
            arrayButton = new Button[x1 * x2 * y1 * y2];
            for (int i = 0; i < x1*x2 + 1; i++)
            {

                for(int j = 0; j< y1*y2+1;j++)
                {
                    Button bt = new Button();
                   
                    bt.Width = _Width;
                    bt.Height = _Height;
                    bt.Location = new Point(j * _Width, i * _Height);

                    if(i==0 && j ==0)
                    {
                        bt.Text = "All";
                        UIControl.UIButton.MaintainButton_N_WordEvent(bt, RunProgram._readPLC, PLCDevice,x1*x2);
                    }
                    else if (i == 0 && j != 0) // Row 0 =>  N bit
                    {
                        bt.Text = j.ToString();
                        UIControl.UIButton.MaintainButton_N_BitEvent(bt, RunProgram._readPLC, PLCDevice, j - 1,x1*x2);
                    }
                    else if(i != 0 && j == 0) // Colum 0 => Device
                    {
                        bt.Text = i.ToString();
                        UIControl.UIButton.MaintainButton16BitEvent(bt, RunProgram._readPLC, PLCDevice+i-1);
                    }
                    else
                    {
                        //bt.Text = String.Format("{0}{1}", i, j);
                        UIControl.UIButton.MaintainButtonEvent(bt, RunProgram._readPLC, PLCDevice + i - 1, j-1);
                        arrayButton[index] = bt;
                        index++;
                    }
                    Controls.Add(bt);
                }
            }
            Check = CheckButton;
        }
        private void CheckButton()
        {
            int index = 0;
            for (int i = 0; i < x1 * x2; i++)
            {

                for (int j = 0; j < y1 * y2; j++)
                {
                    MaintainButton(arrayButton[index], RunProgram._readPLC, PLCDevice + i, j);
                    index++;
                }
            }
        }
        private static async void MaintainButton(Button button, int[] plcRead, int intNumber, int bitNumber)
        {
            await Task.Delay(1);
            var bitvalue = plcRead[intNumber] & (int)Math.Pow(2, bitNumber);
            bool state = bitvalue > 0;
            button.BackColor = state ? Color.Blue : Color.White;
        }
    }
}
