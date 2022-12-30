using LiteDB;
using SEMV_Dispencer_V1.Control;
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
    public partial class frmTeachingData : Form
    {
        public frmTeachingData()
        {
            InitializeComponent();
        }
        private int _index;
        private void frmMaster_Load(object sender, EventArgs e)
        {
            //LoadData();
            LoadDataTable();
            dgvModels.AutoGenerateColumns = false;
            dgvModels.AllowUserToAddRows = false;
            btAdd.Enabled = RunProgram.AccessLevel == 2 ? true : false;
            btDelete.Enabled = RunProgram.AccessLevel == 2 ? true : false;
        }
        private void LoadDataTable()
        {
            dgvModels.Rows.Clear();
            var masters = RunProgram.MotorDatas;
            for (int i = 0; i < masters.Count; i++)
            {
                dgvModels.Rows.Add(
                        masters[i].Id,
                        masters[i].Name,
                        masters[i].OriginSpeed,
                        masters[i].Home,
                        masters[i].JogLow,
                        masters[i].JogHigh,
                        masters[i].Acc,
                        masters[i].Dec
                    );
            }
            _index = 0;
        }

        private void dgvModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvModels.RowCount)
            {
                _index = e.RowIndex;
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want add data?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMotorData>("motordatas");
                    var master = new Library.cDatabase.TMotorData()
                    {
                        Name = "Hello",
                        OriginSpeed = 50,
                        Home = 0,
                        JogLow = 20,
                        JogHigh = 40,
                        Acc = 0.5,
                        Dec = 0.5
                    };
                    masters.Insert(master);
                    dgvModels.Rows.Add(
                            master.Id,
                            master.Name,
                            master.OriginSpeed,
                            master.Home,
                            master.JogLow,
                            master.JogHigh,
                            master.Acc,
                            master.Dec
                        );
                }
            }
                
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want save data?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMotorData>("motordatas");
                    for (int i = 0; i < dgvModels.Rows.Count; i++)
                    {
                        try
                        {
                            var master = masters.FindById((int)dgvModels.Rows[i].Cells[0].Value);

                            master.Name = (string)dgvModels.Rows[i].Cells[1].Value;
                            master.OriginSpeed = Convert.ToDouble(dgvModels.Rows[i].Cells[2].Value);
                            master.Home = Convert.ToDouble(dgvModels.Rows[i].Cells[3].Value);
                            master.JogLow = Convert.ToDouble(dgvModels.Rows[i].Cells[4].Value);
                            master.JogHigh = Convert.ToDouble(dgvModels.Rows[i].Cells[5].Value);
                            master.Acc = Convert.ToDouble(dgvModels.Rows[i].Cells[6].Value);
                            master.Dec = Convert.ToDouble(dgvModels.Rows[i].Cells[7].Value);
                            masters.Update(master);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Check Value Type in Row "+ (i+1).ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                }
                //RunProgram.SendMotorData();
            }
                

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want add data?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMotorData>("motordatas");
                    if (masters.Count() > 1)
                    {
                        masters.Delete((int)dgvModels.Rows[_index].Cells[0].Value);
                    }
                    else MessageBox.Show("Khong The Xoa Model nay");
                }
                LoadDataTable();
            }
                
        }
        private void frmTeachingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMotorData>("motordatas");
                    for (int i = 0; i < dgvModels.Rows.Count; i++)
                    {
                        try
                        {
                            var master = masters.FindById((int)dgvModels.Rows[i].Cells[0].Value);

                            master.Name = (string)dgvModels.Rows[i].Cells[1].Value;
                            master.OriginSpeed = Convert.ToDouble(dgvModels.Rows[i].Cells[2].Value);
                            master.Home = Convert.ToDouble(dgvModels.Rows[i].Cells[3].Value);
                            master.JogLow = Convert.ToDouble(dgvModels.Rows[i].Cells[4].Value);
                            master.JogHigh = Convert.ToDouble(dgvModels.Rows[i].Cells[5].Value);
                            master.Acc = Convert.ToDouble(dgvModels.Rows[i].Cells[6].Value);
                            master.Dec = Convert.ToDouble(dgvModels.Rows[i].Cells[7].Value);
                            masters.Update(master);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Check Value Type in Row " + (i + 1).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                            return;
                        }

                    }
                }
                RunProgram.SendMotorData();
            }
            else if (result == DialogResult.No)
            {

            }
            else e.Cancel = true;
        }
    }
}
