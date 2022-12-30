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
    public partial class ConTableAction : UserControl
    {
        public ConTableAction()
        {
            InitializeComponent();
            AddColumn();
            RunProgram.Instance.OnStartUp += DisplayError;
        }
        private void AddColumn()
        {
            listView1.Columns.Add("Date Time", 80);
            listView1.Columns.Add("Code", 60);
            listView1.Columns.Add("Function", 200);
            listView1.View = View.Details;

        }
        private void DisplayError()
        {
            if(listView1.Items.Count > 1000)
            {
                RunProgram.ListRecordDeviceAction.Clear();
                listView1.Items.Clear();
            }
            for(int i = listView1.Items.Count; i < RunProgram.ListRecordDeviceAction.Count; i++)
            {
                string[] data = RunProgram.ListRecordDeviceAction[i].Split(';');
                listView1.Items.Insert(0, new ListViewItem(new String[] { data[0], data[1], data[2] }));
            }
            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            RunProgram.ListRecordDeviceAction.Clear();
            listView1.Items.Clear();
        }
    }
}
