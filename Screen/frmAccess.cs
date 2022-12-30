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
    public partial class frmAccess : Form
    {
        public frmAccess()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "tadames")
                {
                    RunProgram.AccessLevel = 2;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (textBox1.Text == RunProgram.Password)
                {
                    RunProgram.AccessLevel = 1;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show("Password Wrong!","Access Fail",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
