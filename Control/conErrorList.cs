using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.Control
{
    public partial class conErrorList : UserControl
    {
        public conErrorList()
        {
            InitializeComponent();
            AddColumn();
            RunProgram.Instance.OnStartUp += DisplayError;
            RunProgram.Instance.OnStartUp += ClearError;
        }
        private void AddColumn()
        {
            listView1.Columns.Add("Date Time", 80);
            listView1.Columns.Add("Code", 60);
            listView1.Columns.Add("Function", 200);
            listView1.Columns.Add("Handle", 200);
            listView1.View = View.Details;

        }
        private int address = 4060;
        private void DisplayError()
        {
            int index = 0;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    index = i * 16 + j;
                    var bitValue = RunProgram._readPLC[address + i] & (int)Math.Pow(2, j);
                    if(bitValue != 0)
                    {
                        bool add = true;
                        foreach(var item in listView1.Items)
                        {
                            if (((ListViewItem)item).SubItems[1].Text == String.Format("D{0}.{1}", address + i, j)) add = false;
                        }
                        if (RunProgram.ListError.Length > index && add)
                        {
                            string[] data = RunProgram.ListError[index].Split(',');
                            if(data.Length > 1)
                                listView1.Items.Add(new ListViewItem(new String[] { DateTime.Now.ToShortTimeString(), String.Format("D{0}.{1}", address + i, j), data[0], data[1] }));
                            else
                                listView1.Items.Add(new ListViewItem(new String[] { DateTime.Now.ToShortTimeString(), String.Format("D{0}.{1}", address + i, j), data[0], "" }));
                        }
                    }
                }
            }

        }
        private void ClearError()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    var bitValue = RunProgram._readPLC[address + i] & (int)Math.Pow(2, j);
                    if (bitValue == 0)
                    {
                        string name = String.Format("D{0}.{1}", address + i, j);
                        foreach (var item in listView1.Items)
                        {

                            if (((ListViewItem)item).SubItems[1].Text == name)
                            {
                                int m = ((ListViewItem)item).Index;
                                listView1.Items[m].Remove();
                            }
                        }
                    }
                    //label.Text = (state > 0) ? trueText : falseText;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
