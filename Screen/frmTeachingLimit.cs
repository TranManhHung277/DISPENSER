using LiteDB;
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
    public partial class frmTeachingLimit : Form
    {
        public frmTeachingLimit()
        {
            InitializeComponent();
        }
        
        private void frmTeachingLimit_Load(object sender, EventArgs e)
        {
            var data = RunProgram.Data;
            nudNeedleX1.Value =(decimal)data.LimitNeedleX1;
            nudNeedleX2.Value =(decimal)data.LimitNeedleX2;
            nudNeedleY1.Value =(decimal)data.LimitNeedleY1;
            nudNeedleY2.Value =(decimal)data.LimitNeedleY2;
            nudNeedleZ1.Value =(decimal)data.LimitNeedleZ1;
            nudNeedleZ2.Value =(decimal)data.LimitNeedleZ2;
            nudPrdX1.Value =(decimal)data.LimitISX1;
            nudPrdX2.Value =(decimal)data.LimitISX2;
            nudPrdY1.Value =(decimal)data.LimitISY1;
            nudPrdY2.Value =(decimal)data.LimitISY2;
            nudPrdA1.Value =(decimal)data.LimitISA1;
            nudPrdA2.Value =(decimal)data.LimitISA2;
            nudPrdZ1.Value =(decimal)data.LimitISZ1;
            nudPrdZ2.Value =(decimal)data.LimitISZ2;
        }

        private void frmTeachingLimit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var d = db.GetCollection<Library.cDatabase.TData>("data");
                    var data = d.FindById(1);
                    data.LimitNeedleX1 = (double)nudNeedleX1.Value;
                    data.LimitNeedleX2 = (double)nudNeedleX2.Value;
                    data.LimitNeedleY1 = (double)nudNeedleY1.Value;
                    data.LimitNeedleY2 = (double)nudNeedleY2.Value;
                    data.LimitNeedleZ1 = (double)nudNeedleZ1.Value;
                    data.LimitNeedleZ2 = (double)nudNeedleZ2.Value;

                    data.LimitISX1 = (double)nudPrdX1.Value;
                    data.LimitISX2 = (double)nudPrdX2.Value;
                    data.LimitISY1 = (double)nudPrdY1.Value;
                    data.LimitISY2 = (double)nudPrdY2.Value;
                    data.LimitISA1 = (double)nudPrdA1.Value;
                    data.LimitISA2 = (double)nudPrdA2.Value;
                    data.LimitISZ1 = (double)nudPrdZ1.Value;
                    data.LimitISZ2 = (double)nudPrdZ2.Value;
                    d.Update(data);
                }
                RunProgram.SendLimitData();

            }
            else if (result == DialogResult.No)
            {
               
            }
            else e.Cancel = true;
        }
    }
}
