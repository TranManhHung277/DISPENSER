using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LiteDB;
using SEMV_Dispencer_V1.Control;

namespace SEMV_Dispencer_V1.Screen
{
    public partial class frmTeachingModel : Form
    {
        private int _index = 0;
        private int _id = -1;
        public static bool _open = false; 
        public static bool _change = false; 
        public frmTeachingModel()
        {
            InitializeComponent();
        }

        private void frmTeachingModel_Load(object sender, EventArgs e)
        {
            //LoadData();
            LoadDataTable();
            LoadListModelName();
            dgvModels.AutoGenerateColumns = false;
            dgvModels.AllowUserToAddRows = false;
            //btAdd.Enabled = RunProgram.AccessLevel == 2 ? true : false;
            //btDelete.Enabled = RunProgram.AccessLevel == 2 ? true : false;
            _open = true;
        }
        private void LoadDataTable()
        {
            dgvModels.Rows.Clear();
            var models = RunProgram.Models;
            for(int i =0; i< models.Count; i++)
            {
                dgvModels.Rows.Add(
                        models[i].Id,
                        models[i].CamId,
                        models[i].ModelName,
                        models[i].CamISX,
                        models[i].CamISY,
                        models[i].CamISZ,
                        models[i].ArrayX1,
                        models[i].ArrayY1,
                        models[i].DistanceX1,
                        models[i].DistanceY1,
                        models[i].ArrayX2,
                        models[i].ArrayY2,
                        models[i].DistanceX2,
                        models[i].DistanceY2,
                        models[i].SpeedCamIS,
                        models[i].LightPrd,
                        models[i].LightGlue,
                        models[i].Active
                    );
            }
            _index = 0;
            dgvModels.Columns[0].Visible = false;
        }

        private void dgvModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvModels.RowCount)
            {
                _index = e.RowIndex;
                if(e.ColumnIndex == 17)
                {
                    for(int i = 0; i < dgvModels.RowCount; i++)
                    {
                        dgvModels.Rows[i].Cells[17].Value = false;
                    }
                    dgvModels.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm dữ liệu?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    var models = db.GetCollection<Library.cDatabase.TModel>("models");
                    if(tabControl1.SelectedIndex == 0)
                    {
                        var model = new Library.cDatabase.TModel()
                        {
                            CamId = (int)nudCamID.Value,
                            ModelName = cbxModel.Text,
                            Active = false,
                            CamISX = (double)nudStartX.Value,
                            CamISY = (double)nudStartY.Value,
                            CamISZ = (double)nudStartZ.Value,
                            ArrayX1 = (double)nudX1.Value,
                            ArrayY1 = (double)nudY1.Value,
                            DistanceX1 = (double)nudDisX1.Value,
                            DistanceY1 = (double)nudDisY1.Value,
                            ArrayX2 = (double)nudX2.Value,
                            ArrayY2 = (double)nudY2.Value,
                            DistanceX2 = (double)nudDisX2.Value,
                            DistanceY2 = (double)nudDisY2.Value,
                            SpeedCamIS = (double)nudSpeed.Value,
                            LightPrd = (int)nudLightPrd.Value,
                            LightGlue = (int)nudLightGlue.Value,
                        };
                        models.Insert(model);
                        dgvModels.Rows.Add(
                                model.Id,
                                model.CamId,
                                model.ModelName,
                                model.CamISX,
                                model.CamISY,
                                model.CamISZ,
                                model.ArrayX1,
                                model.ArrayY1,
                                model.DistanceX1,
                                model.DistanceY1,
                                model.ArrayX2,
                                model.ArrayY2,
                                model.DistanceX2,
                                model.DistanceY2,
                                model.SpeedCamIS,
                                model.LightPrd,
                                model.LightGlue,
                                model.Active
                            );
                    }    
                    else
                    {
                        var model = new Library.cDatabase.TModel()
                        {
                            CamId = 0,
                            ModelName = "Hello",
                            Active = false,
                            CamISX = 54.62,
                            CamISY = 216.62,
                            CamISZ = 1.86,
                            ArrayX1 = 2,
                            ArrayY1 = 2,
                            DistanceX1 = 5,
                            DistanceY1 = 5,
                            ArrayX2 = 2,
                            ArrayY2 = 2,
                            DistanceX2 = 26,
                            DistanceY2 = 42,
                            SpeedCamIS = 50,
                            LightPrd = 0,
                            LightGlue = 0
                        };
                        models.Insert(model);
                        dgvModels.Rows.Add(
                                model.Id,
                                model.CamId,
                                model.ModelName,
                                model.CamISX,
                                model.CamISY,
                                model.CamISZ,
                                model.ArrayX1,
                                model.ArrayY1,
                                model.DistanceX1,
                                model.DistanceY1,
                                model.ArrayX2,
                                model.ArrayY2,
                                model.DistanceX2,
                                model.DistanceY2,
                                model.SpeedCamIS,
                                model.LightPrd,
                                model.LightGlue,
                                model.Active
                            );
                    }    
                }
                LoadListModelName();

            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                {
                    
                    var models = db.GetCollection<Library.cDatabase.TModel>("models");
                    if(tabControl1.SelectedIndex == 1)
                    {
                        for (int i = 0; i < dgvModels.Rows.Count; i++)
                        {
                            try
                            {
                                var model = models.FindById((int)dgvModels.Rows[i].Cells[0].Value);
                                model.CamId = Convert.ToInt32(dgvModels.Rows[i].Cells[1].Value);
                                model.ModelName = (string)dgvModels.Rows[i].Cells[2].Value;
                                model.CamISX = Convert.ToDouble(dgvModels.Rows[i].Cells[3].Value);
                                model.CamISY = Convert.ToDouble(dgvModels.Rows[i].Cells[4].Value);
                                model.CamISZ = Convert.ToDouble(dgvModels.Rows[i].Cells[5].Value);
                                model.ArrayX1 = Convert.ToDouble(dgvModels.Rows[i].Cells[6].Value);
                                model.ArrayY1 = Convert.ToDouble(dgvModels.Rows[i].Cells[7].Value);
                                model.DistanceX1 = Convert.ToDouble(dgvModels.Rows[i].Cells[8].Value);
                                model.DistanceY1 = Convert.ToDouble(dgvModels.Rows[i].Cells[9].Value);
                                model.ArrayX2 = Convert.ToDouble(dgvModels.Rows[i].Cells[10].Value);
                                model.ArrayY2 = Convert.ToDouble(dgvModels.Rows[i].Cells[11].Value);
                                model.DistanceX2 = Convert.ToDouble(dgvModels.Rows[i].Cells[12].Value);
                                model.DistanceY2 = Convert.ToDouble(dgvModels.Rows[i].Cells[13].Value);
                                model.SpeedCamIS = Convert.ToDouble(dgvModels.Rows[i].Cells[14].Value);
                                model.LightPrd = Convert.ToInt32(dgvModels.Rows[i].Cells[15].Value);
                                model.LightGlue = Convert.ToInt32(dgvModels.Rows[i].Cells[16].Value);
                                model.Active = Convert.ToBoolean(dgvModels.Rows[i].Cells[17].Value);
                                models.Update(model);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Kiểm tra giá trị ở dòng" + (i + 1).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        var model = models.FindById(_id);
                        model.CamId = (int)nudCamID.Value;
                        model.ModelName = cbxModel.Text;
                        model.CamISX = (double)nudStartX.Value;
                        model.CamISY = (double)nudStartY.Value;
                        model.CamISZ = (double)nudStartZ.Value;
                        model.ArrayX1 = (double)nudX1.Value;
                        model.ArrayY1 = (double)nudY1.Value;
                        model.DistanceX1 = (double)nudDisX1.Value;
                        model.DistanceY1 = (double)nudDisY1.Value;
                        model.ArrayX2 = (double)nudX2.Value;
                        model.ArrayY2 = (double)nudY2.Value;
                        model.DistanceX2 = (double)nudDisX2.Value;
                        model.DistanceY2 = (double)nudDisY2.Value;
                        model.SpeedCamIS = (double)nudSpeed.Value;
                        model.LightPrd = (int)nudLightPrd.Value;
                        model.LightGlue = (int)nudLightGlue.Value;
                        models.Update(model);
                       
                    } 
                }
                if (tabControl1.SelectedIndex == 1)  LoadListModelName();
                else LoadDataTable();
                RunProgram.SendModelData(RunProgram.ModelActive);
                _change = true;
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var db = new LiteDatabase(Library.cDatabase.ConStr))
                    {
                        var models = db.GetCollection<Library.cDatabase.TModel>("models");
                        if (models.Count() > 1)
                        {
                            models.Delete((int)dgvModels.Rows[_index].Cells[0].Value);

                        }
                        else MessageBox.Show("Không thể xóa Model này!");
                    }
                    LoadDataTable();
                    LoadListModelName();
                }
            }    
            
            
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 1)
                {
                    DialogResult result = MessageBox.Show(String.Format("Bạn có muốn cập nhật tọa độ vào dòng {0}?", dgvModels.Rows[_index].Cells[1].Value), "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvModels.Rows[_index].Cells[2].Value = conCoordinate1.XCoordinate;
                        dgvModels.Rows[_index].Cells[3].Value = conCoordinate1.YCoordinate;
                        dgvModels.Rows[_index].Cells[4].Value = conCoordinate1.ZCoordinate;
                    }
                }
                else
                {
                    nudStartX.Value = (decimal)conCoordinate1.XCoordinate;
                    nudStartY.Value = (decimal)conCoordinate1.YCoordinate;
                    nudStartZ.Value = (decimal)conCoordinate1.ZCoordinate;
                }
            }   
            catch
            {

            }
            
                
        }

        private void frmTeachingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (conModelControl3.Timer1.Enabled) conModelControl3.Timer1.Enabled = false;
                RunProgram.LoadModelData();
                _open = false;
            }
            else if (result == DialogResult.No)
            {
                if (conModelControl3.Timer1.Enabled) conModelControl3.Timer1.Enabled = false;
                _open = false;
            }
            else e.Cancel = true;
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModel(cbxModel.Text);
        }
        private void LoadModel(string name)
        {
            using (var db = new LiteDatabase(Library.cDatabase.ConStr))
            {
                var models = db.GetCollection<Library.cDatabase.TModel>("models");
                var model = models.Find(Query.EQ("ModelName",name)).FirstOrDefault();
                nudCamID.Value = model.CamId;
                nudStartX.Value = (decimal)model.CamISX;
                nudStartY.Value = (decimal)model.CamISY;
                nudStartZ.Value = (decimal)model.CamISZ;
                nudX1.Value = (decimal)model.ArrayX1;
                nudY1.Value = (decimal)model.ArrayY1;
                nudDisX1.Value = (decimal)model.DistanceX1;
                nudDisY1.Value = (decimal)model.DistanceY1;
                nudX2.Value = (decimal)model.ArrayX2;
                nudY2.Value = (decimal)model.ArrayY2;
                nudDisX2.Value = (decimal)model.DistanceX2;
                nudDisY2.Value = (decimal)model.DistanceY2;
                nudSpeed.Value = (decimal)model.SpeedCamIS;
                nudLightPrd.Value = (decimal)model.LightPrd;
                nudLightGlue.Value = (decimal)model.LightGlue;
                _id = model.Id;
            }
        }
        private void LoadListModelName()
        {
            cbxModel.Items.Clear();
            int activeModel = 0;
            var models = RunProgram.Models;
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].Active) activeModel = i;
                cbxModel.Items.Add(models[i].ModelName);
            }
            cbxModel.SelectedIndex = activeModel;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            RunProgram.ActiveModel(cbxModel.SelectedIndex);
            LoadDataTable();
            MessageBox.Show("Kích hoạt model thành công!");
        }
    }
}
