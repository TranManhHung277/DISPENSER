namespace SEMV_Dispencer_V1.Screen
{
    partial class frmModelTest
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
            this.conAxisControl1 = new SEMV_Dispencer_V1.Control.ConAxisControl();
            this.conCoordinate1 = new SEMV_Dispencer_V1.Control.ConCoordinate();
            this.conModelTest1 = new SEMV_Dispencer_V1.Control.ConModelTest();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.conAxisControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.conCoordinate1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.conModelTest1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // conAxisControl1
            // 
            this.conAxisControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conAxisControl1.Location = new System.Drawing.Point(685, 2);
            this.conAxisControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conAxisControl1.Name = "conAxisControl1";
            this.conAxisControl1.Size = new System.Drawing.Size(266, 272);
            this.conAxisControl1.TabIndex = 0;
            // 
            // conCoordinate1
            // 
            this.conCoordinate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conCoordinate1.Location = new System.Drawing.Point(685, 278);
            this.conCoordinate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conCoordinate1.Name = "conCoordinate1";
            this.conCoordinate1.Size = new System.Drawing.Size(266, 196);
            this.conCoordinate1.TabIndex = 1;
            // 
            // conModelTest1
            // 
            this.conModelTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conModelTest1.Location = new System.Drawing.Point(3, 279);
            this.conModelTest1.Name = "conModelTest1";
            this.conModelTest1.Size = new System.Drawing.Size(677, 194);
            this.conModelTest1.TabIndex = 2;
            // 
            // frmModelTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(969, 515);
            this.MinimumSize = new System.Drawing.Size(969, 515);
            this.Name = "frmModelTest";
            this.Text = "Test Mode";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Control.ConAxisControl conAxisControl1;
        private Control.ConCoordinate conCoordinate1;
        private Control.ConModelTest conModelTest1;
    }
}