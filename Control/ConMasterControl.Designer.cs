namespace SEMV_Dispencer_V1.Control
{
    partial class ConMasterControl
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
            this.btnCamPrd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btLightNeedle = new System.Windows.Forms.Button();
            this.btLightPrd = new System.Windows.Forms.Button();
            this.btSensor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btCamNeedle = new System.Windows.Forms.Button();
            this.btCamUp = new System.Windows.Forms.Button();
            this.btZNozzle = new System.Windows.Forms.Button();
            this.btSetZMaster = new System.Windows.Forms.Button();
            this.btXYNozzle = new System.Windows.Forms.Button();
            this.btSetXYMaster = new System.Windows.Forms.Button();
            this.btToNozzle = new System.Windows.Forms.Button();
            this.btToSensor = new System.Windows.Forms.Button();
            this.btSetMasterSensor = new System.Windows.Forms.Button();
            this.btChangeNozzle = new System.Windows.Forms.Button();
            this.btChangeTray = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCamPrd
            // 
            this.btnCamPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCamPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamPrd.Location = new System.Drawing.Point(94, 5);
            this.btnCamPrd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCamPrd.Name = "btnCamPrd";
            this.btnCamPrd.Size = new System.Drawing.Size(82, 83);
            this.btnCamPrd.TabIndex = 0;
            this.btnCamPrd.Text = "Camera Product Trigger";
            this.btnCamPrd.UseVisualStyleBackColor = true;
            this.btnCamPrd.Click += new System.EventHandler(this.btnCamPrd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btLightNeedle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLightPrd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btSensor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCamPrd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCamNeedle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCamUp, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.btZNozzle, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSetZMaster, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btXYNozzle, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSetXYMaster, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btToNozzle, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.btToSensor, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSetMasterSensor, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.btChangeNozzle, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.btChangeTray, 12, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 183);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btLightNeedle
            // 
            this.btLightNeedle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLightNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLightNeedle.Location = new System.Drawing.Point(5, 95);
            this.btLightNeedle.Margin = new System.Windows.Forms.Padding(2);
            this.btLightNeedle.Name = "btLightNeedle";
            this.btLightNeedle.Size = new System.Drawing.Size(82, 83);
            this.btLightNeedle.TabIndex = 4;
            this.btLightNeedle.Text = "Light Needle";
            this.btLightNeedle.UseVisualStyleBackColor = true;
            // 
            // btLightPrd
            // 
            this.btLightPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLightPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLightPrd.Location = new System.Drawing.Point(94, 95);
            this.btLightPrd.Margin = new System.Windows.Forms.Padding(2);
            this.btLightPrd.Name = "btLightPrd";
            this.btLightPrd.Size = new System.Drawing.Size(82, 83);
            this.btLightPrd.TabIndex = 2;
            this.btLightPrd.Text = "Light Prd";
            this.btLightPrd.UseVisualStyleBackColor = true;
            // 
            // btSensor
            // 
            this.btSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensor.Location = new System.Drawing.Point(183, 5);
            this.btSensor.Margin = new System.Windows.Forms.Padding(2);
            this.btSensor.Name = "btSensor";
            this.btSensor.Size = new System.Drawing.Size(82, 83);
            this.btSensor.TabIndex = 0;
            this.btSensor.Text = "Sensor Trigger";
            this.btSensor.UseVisualStyleBackColor = true;
            this.btSensor.Click += new System.EventHandler(this.btSensor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(183, 95);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(82, 83);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(2, 31);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btCamNeedle
            // 
            this.btCamNeedle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCamNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCamNeedle.Location = new System.Drawing.Point(5, 5);
            this.btCamNeedle.Margin = new System.Windows.Forms.Padding(2);
            this.btCamNeedle.Name = "btCamNeedle";
            this.btCamNeedle.Size = new System.Drawing.Size(82, 83);
            this.btCamNeedle.TabIndex = 0;
            this.btCamNeedle.Text = "CAM Needle Trigger";
            this.btCamNeedle.UseVisualStyleBackColor = true;
            this.btCamNeedle.Click += new System.EventHandler(this.btCamNeedle_Click);
            // 
            // btCamUp
            // 
            this.btCamUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCamUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCamUp.Location = new System.Drawing.Point(683, 5);
            this.btCamUp.Margin = new System.Windows.Forms.Padding(2);
            this.btCamUp.Name = "btCamUp";
            this.btCamUp.Size = new System.Drawing.Size(88, 83);
            this.btCamUp.TabIndex = 0;
            this.btCamUp.Text = "To Cam Up Master";
            this.btCamUp.UseVisualStyleBackColor = true;
            // 
            // btZNozzle
            // 
            this.btZNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btZNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZNozzle.Location = new System.Drawing.Point(295, 5);
            this.btZNozzle.Margin = new System.Windows.Forms.Padding(2);
            this.btZNozzle.Name = "btZNozzle";
            this.btZNozzle.Size = new System.Drawing.Size(82, 83);
            this.btZNozzle.TabIndex = 0;
            this.btZNozzle.Text = "To Check Z Nozzle";
            this.btZNozzle.UseVisualStyleBackColor = true;
            // 
            // btSetZMaster
            // 
            this.btSetZMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSetZMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetZMaster.Location = new System.Drawing.Point(295, 95);
            this.btSetZMaster.Margin = new System.Windows.Forms.Padding(2);
            this.btSetZMaster.Name = "btSetZMaster";
            this.btSetZMaster.Size = new System.Drawing.Size(82, 83);
            this.btSetZMaster.TabIndex = 0;
            this.btSetZMaster.Text = "Set Z Nozzle";
            this.btSetZMaster.UseVisualStyleBackColor = true;
            // 
            // btXYNozzle
            // 
            this.btXYNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXYNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXYNozzle.Location = new System.Drawing.Point(392, 5);
            this.btXYNozzle.Margin = new System.Windows.Forms.Padding(2);
            this.btXYNozzle.Name = "btXYNozzle";
            this.btXYNozzle.Size = new System.Drawing.Size(82, 83);
            this.btXYNozzle.TabIndex = 0;
            this.btXYNozzle.Text = "To Check XY Nozzle";
            this.btXYNozzle.UseVisualStyleBackColor = true;
            // 
            // btSetXYMaster
            // 
            this.btSetXYMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSetXYMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetXYMaster.Location = new System.Drawing.Point(392, 95);
            this.btSetXYMaster.Margin = new System.Windows.Forms.Padding(2);
            this.btSetXYMaster.Name = "btSetXYMaster";
            this.btSetXYMaster.Size = new System.Drawing.Size(82, 83);
            this.btSetXYMaster.TabIndex = 0;
            this.btSetXYMaster.Text = "Set XY Nozzle";
            this.btSetXYMaster.UseVisualStyleBackColor = true;
            // 
            // btToNozzle
            // 
            this.btToNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btToNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToNozzle.Location = new System.Drawing.Point(586, 5);
            this.btToNozzle.Margin = new System.Windows.Forms.Padding(2);
            this.btToNozzle.Name = "btToNozzle";
            this.btToNozzle.Size = new System.Drawing.Size(82, 83);
            this.btToNozzle.TabIndex = 0;
            this.btToNozzle.Text = "To Nozzle Master";
            this.btToNozzle.UseVisualStyleBackColor = true;
            // 
            // btToSensor
            // 
            this.btToSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btToSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToSensor.Location = new System.Drawing.Point(489, 5);
            this.btToSensor.Margin = new System.Windows.Forms.Padding(2);
            this.btToSensor.Name = "btToSensor";
            this.btToSensor.Size = new System.Drawing.Size(82, 83);
            this.btToSensor.TabIndex = 0;
            this.btToSensor.Text = "To Sensor Master";
            this.btToSensor.UseVisualStyleBackColor = true;
            // 
            // btSetMasterSensor
            // 
            this.btSetMasterSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSetMasterSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetMasterSensor.Location = new System.Drawing.Point(489, 95);
            this.btSetMasterSensor.Margin = new System.Windows.Forms.Padding(2);
            this.btSetMasterSensor.Name = "btSetMasterSensor";
            this.btSetMasterSensor.Size = new System.Drawing.Size(82, 83);
            this.btSetMasterSensor.TabIndex = 0;
            this.btSetMasterSensor.Text = "Set Sensor Master";
            this.btSetMasterSensor.UseVisualStyleBackColor = true;
            // 
            // btChangeNozzle
            // 
            this.btChangeNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChangeNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeNozzle.Location = new System.Drawing.Point(586, 95);
            this.btChangeNozzle.Margin = new System.Windows.Forms.Padding(2);
            this.btChangeNozzle.Name = "btChangeNozzle";
            this.btChangeNozzle.Size = new System.Drawing.Size(82, 83);
            this.btChangeNozzle.TabIndex = 0;
            this.btChangeNozzle.Text = "To Change Nozzle";
            this.btChangeNozzle.UseVisualStyleBackColor = true;
            // 
            // btChangeTray
            // 
            this.btChangeTray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChangeTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeTray.Location = new System.Drawing.Point(683, 95);
            this.btChangeTray.Margin = new System.Windows.Forms.Padding(2);
            this.btChangeTray.Name = "btChangeTray";
            this.btChangeTray.Size = new System.Drawing.Size(88, 83);
            this.btChangeTray.TabIndex = 0;
            this.btChangeTray.Text = "To Change Tray";
            this.btChangeTray.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ConMasterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConMasterControl";
            this.Size = new System.Drawing.Size(776, 183);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamPrd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btLightPrd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btCamNeedle;
        private System.Windows.Forms.Button btSensor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btLightNeedle;
        private System.Windows.Forms.Button btCamUp;
        private System.Windows.Forms.Button btToNozzle;
        private System.Windows.Forms.Button btZNozzle;
        private System.Windows.Forms.Button btChangeNozzle;
        private System.Windows.Forms.Button btChangeTray;
        private System.Windows.Forms.Button btXYNozzle;
        private System.Windows.Forms.Button btToSensor;
        private System.Windows.Forms.Button btSetZMaster;
        private System.Windows.Forms.Button btSetXYMaster;
        private System.Windows.Forms.Button btSetMasterSensor;
    }
}
