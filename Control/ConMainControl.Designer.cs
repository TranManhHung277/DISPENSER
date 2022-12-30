namespace SEMV_Dispencer_V1.Control
{
    partial class ConMainControl
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
            this.btReturn = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btAuto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btReturn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btReset, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAuto, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(5, 5);
            this.btReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(170, 56);
            this.btReturn.TabIndex = 0;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(5, 68);
            this.btReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(170, 56);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btAuto
            // 
            this.btAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAuto.Location = new System.Drawing.Point(5, 131);
            this.btAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(170, 57);
            this.btAuto.TabIndex = 1;
            this.btAuto.Text = "Auto/Manual";
            this.btAuto.UseVisualStyleBackColor = true;
            // 
            // ConMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConMainControl";
            this.Size = new System.Drawing.Size(180, 193);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btAuto;
    }
}
