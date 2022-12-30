namespace SEMV_Dispencer_V1.Screen
{
    partial class frmMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMasterControl1 = new SEMV_Dispencer_V1.Control.ConMasterControl();
            this.conMainControl1 = new SEMV_Dispencer_V1.Control.ConMainControl();
            this.btLoad = new System.Windows.Forms.Button();
            this.conCoordinate1 = new SEMV_Dispencer_V1.Control.ConCoordinate();
            this.conAxisControl1 = new SEMV_Dispencer_V1.Control.ConAxisControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.conCoordinate1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.conAxisControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 416);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btSave, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btDelete, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btLoad, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(853, 412);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.edit;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(810, 2);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(41, 45);
            this.btAdd.TabIndex = 1;
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.save;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(810, 51);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(41, 45);
            this.btSave.TabIndex = 1;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.delete;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelete.Location = new System.Drawing.Point(810, 100);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(41, 45);
            this.btDelete.TabIndex = 1;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dgvModels, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.conMasterControl1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.conMainControl1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 7);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(804, 408);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dgvModels
            // 
            this.dgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvModels, 2);
            this.dgvModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModels.Location = new System.Drawing.Point(2, 2);
            this.dgvModels.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.RowHeadersWidth = 51;
            this.dgvModels.RowTemplate.Height = 24;
            this.dgvModels.Size = new System.Drawing.Size(800, 242);
            this.dgvModels.TabIndex = 1;
            this.dgvModels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModels_CellClick);
            // 
            // c1
            // 
            this.c1.DataPropertyName = "Id";
            this.c1.HeaderText = "Id";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c2
            // 
            this.c2.DataPropertyName = "ModelName";
            this.c2.HeaderText = "Tên Model";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c3
            // 
            this.c3.DataPropertyName = "CamISX";
            this.c3.HeaderText = "X";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "CamISY";
            this.c4.HeaderText = "Y";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "CamISZ";
            this.c5.HeaderText = "Z";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c6
            // 
            this.c6.DataPropertyName = "SpeedCamIS";
            this.c6.HeaderText = "Data 1";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            this.c6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c7
            // 
            this.c7.DataPropertyName = "OffsetZ";
            this.c7.HeaderText = "Data 2";
            this.c7.MinimumWidth = 6;
            this.c7.Name = "c7";
            this.c7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conMasterControl1
            // 
            this.conMasterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMasterControl1.Location = new System.Drawing.Point(2, 248);
            this.conMasterControl1.Margin = new System.Windows.Forms.Padding(2);
            this.conMasterControl1.Name = "conMasterControl1";
            this.conMasterControl1.Size = new System.Drawing.Size(700, 158);
            this.conMasterControl1.TabIndex = 2;
            // 
            // conMainControl1
            // 
            this.conMainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMainControl1.Location = new System.Drawing.Point(706, 248);
            this.conMainControl1.Margin = new System.Windows.Forms.Padding(2);
            this.conMainControl1.Name = "conMainControl1";
            this.conMainControl1.Size = new System.Drawing.Size(96, 158);
            this.conMainControl1.TabIndex = 3;
            // 
            // btLoad
            // 
            this.btLoad.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.timg11;
            this.btLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoad.Location = new System.Drawing.Point(810, 149);
            this.btLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(41, 45);
            this.btLoad.TabIndex = 1;
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // conCoordinate1
            // 
            this.conCoordinate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conCoordinate1.Location = new System.Drawing.Point(859, 256);
            this.conCoordinate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conCoordinate1.Name = "conCoordinate1";
            this.conCoordinate1.Size = new System.Drawing.Size(221, 158);
            this.conCoordinate1.TabIndex = 0;
            // 
            // conAxisControl1
            // 
            this.conAxisControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conAxisControl1.Location = new System.Drawing.Point(859, 2);
            this.conAxisControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conAxisControl1.Name = "conAxisControl1";
            this.conAxisControl1.Size = new System.Drawing.Size(221, 250);
            this.conAxisControl1.TabIndex = 1;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaster";
            this.Text = "Master Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeachingModel_FormClosing);
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ConCoordinate conCoordinate1;
        private Control.ConAxisControl conAxisControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvModels;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private Control.ConMasterControl conMasterControl1;
        private Control.ConMainControl conMainControl1;
    }
}