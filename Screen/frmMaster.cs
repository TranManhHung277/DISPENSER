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
    public partial class frmMaster : Form
    {
        public frmMaster()
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
            var masters = RunProgram.Masters;
            for (int i = 0; i < masters.Count; i++)
            {
                dgvModels.Rows.Add(
                        masters[i].Id,
                        masters[i].PositionName,
                        masters[i].X,
                        masters[i].Y,
                        masters[i].Z,
                        masters[i].Data1,
                        masters[i].Data2
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
            DialogResult result = MessageBox.Show("Bạn muốn thêm dữ liệu?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMaster>("masters");
                    var master = new Library.cDatabase.TMaster()
                    {
                        PositionName = "Hello",
                        X = 0,
                        Y = 0,
                        Z = 0,
                        Data1 = 0,
                        Data2 = 0
                    };
                    masters.Insert(master);
                    dgvModels.Rows.Add(
                            master.Id,
                            master.PositionName,
                            master.X,
                            master.Y,
                            master.Z,
                            master.Data1,
                            master.Data2
                        );
                }
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMaster>("masters");
                    for (int i = 0; i < dgvModels.Rows.Count; i++)
                    {
                        try
                        {
                            var master = masters.FindById((int)dgvModels.Rows[i].Cells[0].Value);

                            master.PositionName = (string)dgvModels.Rows[i].Cells[1].Value;
                            master.X = Convert.ToDouble(dgvModels.Rows[i].Cells[2].Value);
                            master.Y = Convert.ToDouble(dgvModels.Rows[i].Cells[3].Value);
                            master.Z = Convert.ToDouble(dgvModels.Rows[i].Cells[4].Value);
                            master.Data1 = Convert.ToDouble(dgvModels.Rows[i].Cells[5].Value);
                            master.Data2 = Convert.ToDouble(dgvModels.Rows[i].Cells[6].Value);
                            masters.Update(master);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Kiểm tra giá trị ở dòng " + (i + 1).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                }
                RunProgram.SendMasterData();
            }
            

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMaster>("masters");
                    if (masters.Count() > 1)
                    {
                        masters.Delete((int)dgvModels.Rows[_index].Cells[0].Value);
                    }
                    else MessageBox.Show("Không thể xóa Model này!");
                }
                LoadDataTable();

            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(String.Format("Bạn có muốn cập nhật dữ liệu tọa độ vào dòng {0}?", dgvModels.Rows[_index].Cells[1].Value), "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgvModels.Rows[_index].Cells[2].Value = conCoordinate1.XCoordinate;
                dgvModels.Rows[_index].Cells[3].Value = conCoordinate1.YCoordinate;
                dgvModels.Rows[_index].Cells[4].Value = conCoordinate1.ZCoordinate;

            }
        }
        private void frmTeachingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var masters = db.GetCollection<Library.cDatabase.TMaster>("masters");
                    for (int i = 0; i < dgvModels.Rows.Count; i++)
                    {
                        try
                        {
                            var master = masters.FindById((int)dgvModels.Rows[i].Cells[0].Value);

                            master.PositionName = (string)dgvModels.Rows[i].Cells[1].Value;
                            master.X = Convert.ToDouble(dgvModels.Rows[i].Cells[2].Value);
                            master.Y = Convert.ToDouble(dgvModels.Rows[i].Cells[3].Value);
                            master.Z = Convert.ToDouble(dgvModels.Rows[i].Cells[4].Value);
                            master.Data1 = Convert.ToDouble(dgvModels.Rows[i].Cells[5].Value);
                            master.Data2 = Convert.ToDouble(dgvModels.Rows[i].Cells[6].Value);
                            masters.Update(master);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Kiểm tra giá trị ở dòng " + (i + 1).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                            return;
                        }

                    }
                }
                RunProgram.SendMasterData();
                
            }
            else if (result == DialogResult.No)
            {

            }
            else e.Cancel = true;
        }
    }
}
