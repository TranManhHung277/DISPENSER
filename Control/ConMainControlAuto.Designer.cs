namespace SEMV_Dispencer_V1.Control
{
    partial class ConMainControlAuto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btNextProcess = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btNextPrd = new System.Windows.Forms.Button();
            this.btCheckGlue = new System.Windows.Forms.Button();
            this.btRunToChangeGlue = new System.Windows.Forms.Button();
            this.btRunToChangePrd = new System.Windows.Forms.Button();
            this.btLightNeedle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btNextProcess, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btNextPrd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCheckGlue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btEnd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btRunToChangeGlue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRunToChangePrd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLightNeedle, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btNextProcess
            // 
            this.btNextProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNextProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextProcess.Location = new System.Drawing.Point(5, 5);
            this.btNextProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNextProcess.Name = "btNextProcess";
            this.btNextProcess.Size = new System.Drawing.Size(266, 47);
            this.btNextProcess.TabIndex = 0;
            this.btNextProcess.Text = "Chạy Tiếp Quy Trình";
            this.btNextProcess.UseVisualStyleBackColor = true;
            // 
            // btEnd
            // 
            this.btEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(5, 113);
            this.btEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(266, 49);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "Kết Thúc";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // btNextPrd
            // 
            this.btNextPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNextPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextPrd.Location = new System.Drawing.Point(5, 59);
            this.btNextPrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNextPrd.Name = "btNextPrd";
            this.btNextPrd.Size = new System.Drawing.Size(266, 47);
            this.btNextPrd.TabIndex = 0;
            this.btNextPrd.Text = "Chạy Sản Phẩm Tiếp Theo";
            this.btNextPrd.UseVisualStyleBackColor = true;
            // 
            // btCheckGlue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btCheckGlue, 2);
            this.btCheckGlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCheckGlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckGlue.Location = new System.Drawing.Point(278, 113);
            this.btCheckGlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCheckGlue.Name = "btCheckGlue";
            this.btCheckGlue.Size = new System.Drawing.Size(270, 49);
            this.btCheckGlue.TabIndex = 0;
            this.btCheckGlue.Text = "Kiểm tra Keo";
            this.btCheckGlue.UseVisualStyleBackColor = true;
            // 
            // btRunToChangeGlue
            // 
            this.btRunToChangeGlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRunToChangeGlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunToChangeGlue.Location = new System.Drawing.Point(278, 5);
            this.btRunToChangeGlue.Margin = new System.Windows.Forms.Padding(2);
            this.btRunToChangeGlue.Name = "btRunToChangeGlue";
            this.btRunToChangeGlue.Size = new System.Drawing.Size(131, 47);
            this.btRunToChangeGlue.TabIndex = 2;
            this.btRunToChangeGlue.Text = "Đến Vị Trí Thay Keo/Kim";
            this.btRunToChangeGlue.UseVisualStyleBackColor = true;
            this.btRunToChangeGlue.Click += new System.EventHandler(this.btRunToChangeGlue_Click);
            // 
            // btRunToChangePrd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btRunToChangePrd, 2);
            this.btRunToChangePrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRunToChangePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunToChangePrd.Location = new System.Drawing.Point(278, 59);
            this.btRunToChangePrd.Margin = new System.Windows.Forms.Padding(2);
            this.btRunToChangePrd.Name = "btRunToChangePrd";
            this.btRunToChangePrd.Size = new System.Drawing.Size(270, 47);
            this.btRunToChangePrd.TabIndex = 3;
            this.btRunToChangePrd.Text = "Đến Vị Trí Thay Tray";
            this.btRunToChangePrd.UseVisualStyleBackColor = true;
            // 
            // btLightNeedle
            // 
            this.btLightNeedle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLightNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLightNeedle.Location = new System.Drawing.Point(416, 5);
            this.btLightNeedle.Margin = new System.Windows.Forms.Padding(2);
            this.btLightNeedle.Name = "btLightNeedle";
            this.btLightNeedle.Size = new System.Drawing.Size(132, 47);
            this.btLightNeedle.TabIndex = 2;
            this.btLightNeedle.Text = "Đèn Kiểm Tra Kim";
            this.btLightNeedle.UseVisualStyleBackColor = true;
            this.btLightNeedle.Click += new System.EventHandler(this.btRunToChangeGlue_Click);
            // 
            // ConMainControlAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConMainControlAuto";
            this.Size = new System.Drawing.Size(553, 167);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btNextProcess;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btNextPrd;
        private System.Windows.Forms.Button btCheckGlue;
        private System.Windows.Forms.Button btRunToChangePrd;
        private System.Windows.Forms.Button btRunToChangeGlue;
        private System.Windows.Forms.Button btLightNeedle;
    }
}
