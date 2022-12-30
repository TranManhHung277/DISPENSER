namespace SEMV_Dispencer_V1.Control
{
    partial class ConModelTest
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
            this.nudX1 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.nudY1 = new System.Windows.Forms.NumericUpDown();
            this.btnCheckZNozze = new System.Windows.Forms.Button();
            this.btnCheckXYPrd = new System.Windows.Forms.Button();
            this.btnCheckZPrd = new System.Windows.Forms.Button();
            this.btnToBondPoint = new System.Windows.Forms.Button();
            this.btnCheckXYNozzle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudOffsetZ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetX = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudX1
            // 
            this.nudX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX1.Location = new System.Drawing.Point(69, 25);
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
            this.nudX1.Size = new System.Drawing.Size(59, 27);
            this.nudX1.TabIndex = 0;
            this.nudX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckZNozze, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckXYPrd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckZPrd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnToBondPoint, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckXYNozzle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 236);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nudX2);
            this.panel3.Controls.Add(this.nudX1);
            this.panel3.Controls.Add(this.nudY2);
            this.panel3.Controls.Add(this.nudY1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(672, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 108);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 62);
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
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1/Y1";
            // 
            // nudX2
            // 
            this.nudX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX2.Location = new System.Drawing.Point(69, 58);
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
            this.nudX2.Size = new System.Drawing.Size(59, 27);
            this.nudX2.TabIndex = 0;
            this.nudX2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudY2
            // 
            this.nudY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY2.Location = new System.Drawing.Point(133, 58);
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
            this.nudY2.Size = new System.Drawing.Size(59, 27);
            this.nudY2.TabIndex = 0;
            this.nudY2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudY1
            // 
            this.nudY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY1.Location = new System.Drawing.Point(133, 25);
            this.nudY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudY1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudY1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY1.Name = "nudY1";
            this.nudY1.Size = new System.Drawing.Size(59, 27);
            this.nudY1.TabIndex = 0;
            this.nudY1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCheckZNozze
            // 
            this.btnCheckZNozze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckZNozze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckZNozze.Location = new System.Drawing.Point(6, 5);
            this.btnCheckZNozze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckZNozze.Name = "btnCheckZNozze";
            this.btnCheckZNozze.Size = new System.Drawing.Size(256, 108);
            this.btnCheckZNozze.TabIndex = 0;
            this.btnCheckZNozze.Text = "Check Z Nozzle";
            this.btnCheckZNozze.UseVisualStyleBackColor = true;
            // 
            // btnCheckXYPrd
            // 
            this.btnCheckXYPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckXYPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckXYPrd.Location = new System.Drawing.Point(536, 5);
            this.btnCheckXYPrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckXYPrd.Name = "btnCheckXYPrd";
            this.btnCheckXYPrd.Size = new System.Drawing.Size(127, 108);
            this.btnCheckXYPrd.TabIndex = 2;
            this.btnCheckXYPrd.Text = "Check XY Prd no";
            this.btnCheckXYPrd.UseVisualStyleBackColor = true;
            this.btnCheckXYPrd.Click += new System.EventHandler(this.btnCheckXYPrd_Click);
            // 
            // btnCheckZPrd
            // 
            this.btnCheckZPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckZPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckZPrd.Location = new System.Drawing.Point(6, 120);
            this.btnCheckZPrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckZPrd.Name = "btnCheckZPrd";
            this.tableLayoutPanel1.SetRowSpan(this.btnCheckZPrd, 2);
            this.btnCheckZPrd.Size = new System.Drawing.Size(256, 111);
            this.btnCheckZPrd.TabIndex = 2;
            this.btnCheckZPrd.Text = "Check Z Prd Point No";
            this.btnCheckZPrd.UseVisualStyleBackColor = true;
            this.btnCheckZPrd.Click += new System.EventHandler(this.btnCheckZPrd_Click);
            // 
            // btnToBondPoint
            // 
            this.btnToBondPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToBondPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBondPoint.Location = new System.Drawing.Point(536, 120);
            this.btnToBondPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToBondPoint.Name = "btnToBondPoint";
            this.tableLayoutPanel1.SetRowSpan(this.btnToBondPoint, 2);
            this.btnToBondPoint.Size = new System.Drawing.Size(127, 111);
            this.btnToBondPoint.TabIndex = 2;
            this.btnToBondPoint.Text = "To Bond Point No";
            this.btnToBondPoint.UseVisualStyleBackColor = true;
            this.btnToBondPoint.Click += new System.EventHandler(this.btnToBondPoint_Click);
            // 
            // btnCheckXYNozzle
            // 
            this.btnCheckXYNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckXYNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckXYNozzle.Location = new System.Drawing.Point(271, 5);
            this.btnCheckXYNozzle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckXYNozzle.Name = "btnCheckXYNozzle";
            this.btnCheckXYNozzle.Size = new System.Drawing.Size(256, 108);
            this.btnCheckXYNozzle.TabIndex = 0;
            this.btnCheckXYNozzle.Text = "Check XY Nozzle";
            this.btnCheckXYNozzle.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nudOffsetZ);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudOffsetY);
            this.panel2.Controls.Add(this.nudOffsetX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(271, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(256, 111);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Offset Z";
            // 
            // nudOffsetZ
            // 
            this.nudOffsetZ.DecimalPlaces = 2;
            this.nudOffsetZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffsetZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudOffsetZ.Location = new System.Drawing.Point(97, 71);
            this.nudOffsetZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOffsetZ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOffsetZ.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudOffsetZ.Name = "nudOffsetZ";
            this.nudOffsetZ.Size = new System.Drawing.Size(125, 27);
            this.nudOffsetZ.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Offset Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Offset X";
            // 
            // nudOffsetY
            // 
            this.nudOffsetY.DecimalPlaces = 2;
            this.nudOffsetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudOffsetY.Location = new System.Drawing.Point(97, 38);
            this.nudOffsetY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOffsetY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOffsetY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudOffsetY.Name = "nudOffsetY";
            this.nudOffsetY.Size = new System.Drawing.Size(125, 27);
            this.nudOffsetY.TabIndex = 0;
            // 
            // nudOffsetX
            // 
            this.nudOffsetX.DecimalPlaces = 2;
            this.nudOffsetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudOffsetX.Location = new System.Drawing.Point(97, 5);
            this.nudOffsetX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOffsetX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOffsetX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudOffsetX.Name = "nudOffsetX";
            this.nudOffsetX.Size = new System.Drawing.Size(125, 27);
            this.nudOffsetX.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(672, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(215, 111);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "No";
            // 
            // nudCount
            // 
            this.nudCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCount.Location = new System.Drawing.Point(69, 38);
            this.nudCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(123, 27);
            this.nudCount.TabIndex = 0;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // ConModelTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConModelTest";
            this.Size = new System.Drawing.Size(893, 236);
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudX1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudY1;
        private System.Windows.Forms.Button btnCheckZNozze;
        private System.Windows.Forms.Button btnCheckXYPrd;
        private System.Windows.Forms.Button btnCheckZPrd;
        private System.Windows.Forms.Button btnToBondPoint;
        private System.Windows.Forms.Button btnCheckXYNozzle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudOffsetY;
        private System.Windows.Forms.NumericUpDown nudOffsetX;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.NumericUpDown nudY2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudOffsetZ;
    }
}
