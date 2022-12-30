namespace SEMV_Dispencer_V1.Control
{
    partial class ConModelControl
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudX1 = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudY1 = new System.Windows.Forms.NumericUpDown();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudLight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLightOn = new System.Windows.Forms.Button();
            this.btnCameraTrigger = new System.Windows.Forms.Button();
            this.btnToXY = new System.Windows.Forms.Button();
            this.btLightPrd = new System.Windows.Forms.Button();
            this.btLightGlue = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLightOn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCameraTrigger, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToXY, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLightPrd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLightGlue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nudX1);
            this.panel3.Controls.Add(this.nudX2);
            this.panel3.Controls.Add(this.nudY1);
            this.panel3.Controls.Add(this.nudY2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(510, 102);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 91);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2/Y2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1/Y1";
            // 
            // nudX1
            // 
            this.nudX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX1.Location = new System.Drawing.Point(69, 7);
            this.nudX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudX1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudX1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX1.Name = "nudX1";
            this.nudX1.Size = new System.Drawing.Size(57, 27);
            this.nudX1.TabIndex = 0;
            this.nudX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudX2
            // 
            this.nudX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX2.Location = new System.Drawing.Point(69, 41);
            this.nudX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudX2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudX2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(57, 27);
            this.nudX2.TabIndex = 0;
            this.nudX2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudY1
            // 
            this.nudY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY1.Location = new System.Drawing.Point(132, 7);
            this.nudY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudY1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudY1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY1.Name = "nudY1";
            this.nudY1.Size = new System.Drawing.Size(57, 27);
            this.nudY1.TabIndex = 0;
            this.nudY1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudY2
            // 
            this.nudY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY2.Location = new System.Drawing.Point(132, 41);
            this.nudY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudY2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudY2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(57, 27);
            this.nudY2.TabIndex = 0;
            this.nudY2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudLight);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(510, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 90);
            this.panel2.TabIndex = 5;
            // 
            // nudLight
            // 
            this.nudLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLight.Location = new System.Drawing.Point(69, 23);
            this.nudLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLight.Name = "nudLight";
            this.nudLight.Size = new System.Drawing.Size(120, 27);
            this.nudLight.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Level";
            // 
            // btnLightOn
            // 
            this.btnLightOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLightOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOn.Location = new System.Drawing.Point(374, 5);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(127, 90);
            this.btnLightOn.TabIndex = 1;
            this.btnLightOn.Text = "Light On";
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnCameraTrigger
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCameraTrigger, 2);
            this.btnCameraTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCameraTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraTrigger.Location = new System.Drawing.Point(6, 5);
            this.btnCameraTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCameraTrigger.Name = "btnCameraTrigger";
            this.btnCameraTrigger.Size = new System.Drawing.Size(359, 90);
            this.btnCameraTrigger.TabIndex = 0;
            this.btnCameraTrigger.Text = "Camera Trigger";
            this.btnCameraTrigger.UseVisualStyleBackColor = true;
            this.btnCameraTrigger.Click += new System.EventHandler(this.btnCameraTrigger_Click);
            // 
            // btnToXY
            // 
            this.btnToXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToXY.Location = new System.Drawing.Point(374, 102);
            this.btnToXY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToXY.Name = "btnToXY";
            this.btnToXY.Size = new System.Drawing.Size(127, 91);
            this.btnToXY.TabIndex = 2;
            this.btnToXY.Text = "To Product Row/Col";
            this.btnToXY.UseVisualStyleBackColor = true;
            this.btnToXY.Click += new System.EventHandler(this.btnToXY_Click);
            // 
            // btLightPrd
            // 
            this.btLightPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLightPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLightPrd.Location = new System.Drawing.Point(6, 102);
            this.btLightPrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLightPrd.Name = "btLightPrd";
            this.btLightPrd.Size = new System.Drawing.Size(175, 91);
            this.btLightPrd.TabIndex = 2;
            this.btLightPrd.Text = "Light Check Prd";
            this.btLightPrd.UseVisualStyleBackColor = true;
            // 
            // btLightGlue
            // 
            this.btLightGlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLightGlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLightGlue.Location = new System.Drawing.Point(190, 102);
            this.btLightGlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLightGlue.Name = "btLightGlue";
            this.btLightGlue.Size = new System.Drawing.Size(175, 91);
            this.btLightGlue.TabIndex = 2;
            this.btLightGlue.Text = "Light Check Glue";
            this.btLightGlue.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ConModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConModelControl";
            this.Size = new System.Drawing.Size(731, 198);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Button btnCameraTrigger;
        private System.Windows.Forms.Button btnToXY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudY2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudLight;
        private System.Windows.Forms.Button btLightPrd;
        private System.Windows.Forms.Button btLightGlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudX1;
        private System.Windows.Forms.NumericUpDown nudY1;
    }
}
