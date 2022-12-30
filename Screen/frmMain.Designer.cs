namespace SEMV_Dispencer_V1.Screen
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSettingModel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSettingMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.tsData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTestMode = new System.Windows.Forms.ToolStripMenuItem();
            this.frmLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCheckGlue = new System.Windows.Forms.ToolStripComboBox();
            this.tsWrongprd = new System.Windows.Forms.ToolStripComboBox();
            this.tsChoosePrf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNeedleDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChooseModel = new System.Windows.Forms.ToolStripComboBox();
            this.tsAccess = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.conDeviceConnection1 = new SEMV_Dispencer_V1.Control.ConDeviceConnection();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btRotateLeft = new System.Windows.Forms.Button();
            this.btRotateRight = new System.Windows.Forms.Button();
            this.cvsInSightDisplay = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.panelASCamera = new System.Windows.Forms.Panel();
            this.conErrorList1 = new SEMV_Dispencer_V1.Control.conErrorList();
            this.conTableAction1 = new SEMV_Dispencer_V1.Control.ConTableAction();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.conDataTotal1 = new SEMV_Dispencer_V1.Control.ConDataTotal();
            this.conTableState1 = new SEMV_Dispencer_V1.Control.ConTableState();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.conMainControl1 = new SEMV_Dispencer_V1.Control.ConMainControl();
            this.conCoordinate1 = new SEMV_Dispencer_V1.Control.ConCoordinate();
            this.conMainControlAuto1 = new SEMV_Dispencer_V1.Control.ConMainControlAuto();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelASCamera.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.tsChoosePrf,
            this.tsNeedleDisplay,
            this.tsChooseModel,
            this.tsAccess});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1013, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSettingModel,
            this.tsSettingMachine,
            this.chếĐộHoạtĐộngToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // tsSettingModel
            // 
            this.tsSettingModel.Name = "tsSettingModel";
            this.tsSettingModel.Size = new System.Drawing.Size(174, 22);
            this.tsSettingModel.Text = "Model";
            this.tsSettingModel.Click += new System.EventHandler(this.tsSettingModel_Click);
            // 
            // tsSettingMachine
            // 
            this.tsSettingMachine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMaster,
            this.tsData,
            this.tsTestMode,
            this.frmLimit});
            this.tsSettingMachine.Name = "tsSettingMachine";
            this.tsSettingMachine.Size = new System.Drawing.Size(174, 22);
            this.tsSettingMachine.Text = "Thông Số Máy";
            // 
            // tsMaster
            // 
            this.tsMaster.Name = "tsMaster";
            this.tsMaster.Size = new System.Drawing.Size(164, 22);
            this.tsMaster.Text = "Master";
            this.tsMaster.Click += new System.EventHandler(this.tsMaster_Click);
            // 
            // tsData
            // 
            this.tsData.Name = "tsData";
            this.tsData.Size = new System.Drawing.Size(164, 22);
            this.tsData.Text = "Dữ Liệu Động Cơ";
            this.tsData.Click += new System.EventHandler(this.tsData_Click);
            // 
            // tsTestMode
            // 
            this.tsTestMode.Name = "tsTestMode";
            this.tsTestMode.Size = new System.Drawing.Size(164, 22);
            this.tsTestMode.Text = "Test Mode";
            this.tsTestMode.Click += new System.EventHandler(this.tsTestMode_Click);
            // 
            // frmLimit
            // 
            this.frmLimit.Name = "frmLimit";
            this.frmLimit.Size = new System.Drawing.Size(164, 22);
            this.frmLimit.Text = "Giới Hạn";
            this.frmLimit.Click += new System.EventHandler(this.frmLimit_Click);
            // 
            // chếĐộHoạtĐộngToolStripMenuItem
            // 
            this.chếĐộHoạtĐộngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCheckGlue,
            this.tsWrongprd});
            this.chếĐộHoạtĐộngToolStripMenuItem.Name = "chếĐộHoạtĐộngToolStripMenuItem";
            this.chếĐộHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chếĐộHoạtĐộngToolStripMenuItem.Text = "Chế Độ Hoạt Động";
            // 
            // tsCheckGlue
            // 
            this.tsCheckGlue.Items.AddRange(new object[] {
            "Kiểm tra keo",
            "Bỏ qua kiểm tra keo"});
            this.tsCheckGlue.Name = "tsCheckGlue";
            this.tsCheckGlue.Size = new System.Drawing.Size(121, 23);
            this.tsCheckGlue.SelectedIndexChanged += new System.EventHandler(this.tsGlueCheck_SelectedIndexChanged);
            // 
            // tsWrongprd
            // 
            this.tsWrongprd.Items.AddRange(new object[] {
            "Dừng khi gặp lỗi",
            "Chạy sản phẩm tiếp khi gặp lỗi"});
            this.tsWrongprd.Name = "tsWrongprd";
            this.tsWrongprd.Size = new System.Drawing.Size(121, 23);
            this.tsWrongprd.SelectedIndexChanged += new System.EventHandler(this.tsWrongprd_SelectedIndexChanged);
            // 
            // tsChoosePrf
            // 
            this.tsChoosePrf.Name = "tsChoosePrf";
            this.tsChoosePrf.Size = new System.Drawing.Size(154, 26);
            this.tsChoosePrf.Text = "Lựa Chọn Vị Trí Sản Phẩm";
            this.tsChoosePrf.Click += new System.EventHandler(this.tsChooseProduct_Click);
            // 
            // tsNeedleDisplay
            // 
            this.tsNeedleDisplay.Name = "tsNeedleDisplay";
            this.tsNeedleDisplay.Size = new System.Drawing.Size(139, 26);
            this.tsNeedleDisplay.Text = "Màn hình kiểm tra kim";
            this.tsNeedleDisplay.Click += new System.EventHandler(this.tsNeedleDisplay_Click);
            // 
            // tsChooseModel
            // 
            this.tsChooseModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsChooseModel.Name = "tsChooseModel";
            this.tsChooseModel.Size = new System.Drawing.Size(114, 26);
            this.tsChooseModel.SelectedIndexChanged += new System.EventHandler(this.tsChooseModel_SelectedIndexChanged);
            // 
            // tsAccess
            // 
            this.tsAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsAccess.Items.AddRange(new object[] {
            "User",
            "Admin",
            "Master"});
            this.tsAccess.Name = "tsAccess";
            this.tsAccess.Size = new System.Drawing.Size(121, 26);
            this.tsAccess.SelectedIndexChanged += new System.EventHandler(this.tsAccess_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.conDeviceConnection1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelASCamera, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.conTableAction1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1009, 340);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // conDeviceConnection1
            // 
            this.conDeviceConnection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conDeviceConnection1.Location = new System.Drawing.Point(861, 2);
            this.conDeviceConnection1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conDeviceConnection1.Name = "conDeviceConnection1";
            this.conDeviceConnection1.Size = new System.Drawing.Size(146, 166);
            this.conDeviceConnection1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnConnect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnZoomIn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnZoomOut, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnMax, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnMin, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btRotateLeft, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.btRotateRight, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.cvsInSightDisplay, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 336);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.live_Off;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(34, 34);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.Zoom_In;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.Location = new System.Drawing.Point(43, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(34, 34);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.Zoom_Out;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(83, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(34, 34);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.Fit;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMax.Location = new System.Drawing.Point(123, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 34);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.Zoom;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMin.Location = new System.Drawing.Point(163, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 34);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btRotateLeft
            // 
            this.btRotateLeft.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.undo;
            this.btRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRotateLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRotateLeft.Location = new System.Drawing.Point(203, 3);
            this.btRotateLeft.Name = "btRotateLeft";
            this.btRotateLeft.Size = new System.Drawing.Size(34, 34);
            this.btRotateLeft.TabIndex = 3;
            this.btRotateLeft.UseVisualStyleBackColor = true;
            this.btRotateLeft.Click += new System.EventHandler(this.btRotateLeft_Click);
            // 
            // btRotateRight
            // 
            this.btRotateRight.BackgroundImage = global::SEMV_Dispencer_V1.Properties.Resources.redo;
            this.btRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRotateRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRotateRight.Location = new System.Drawing.Point(243, 3);
            this.btRotateRight.Name = "btRotateRight";
            this.btRotateRight.Size = new System.Drawing.Size(34, 34);
            this.btRotateRight.TabIndex = 3;
            this.btRotateRight.UseVisualStyleBackColor = true;
            this.btRotateRight.Click += new System.EventHandler(this.btRotateRight_Click);
            // 
            // cvsInSightDisplay
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.cvsInSightDisplay, 9);
            this.cvsInSightDisplay.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay.DialogIcon = null;
            this.cvsInSightDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsInSightDisplay.Location = new System.Drawing.Point(3, 43);
            this.cvsInSightDisplay.Name = "cvsInSightDisplay";
            this.cvsInSightDisplay.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay.Size = new System.Drawing.Size(474, 290);
            this.cvsInSightDisplay.TabIndex = 4;
            // 
            // panelASCamera
            // 
            this.panelASCamera.Controls.Add(this.conErrorList1);
            this.panelASCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelASCamera.Location = new System.Drawing.Point(486, 2);
            this.panelASCamera.Margin = new System.Windows.Forms.Padding(2);
            this.panelASCamera.Name = "panelASCamera";
            this.panelASCamera.Size = new System.Drawing.Size(371, 166);
            this.panelASCamera.TabIndex = 5;
            // 
            // conErrorList1
            // 
            this.conErrorList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conErrorList1.Location = new System.Drawing.Point(0, 0);
            this.conErrorList1.Margin = new System.Windows.Forms.Padding(4);
            this.conErrorList1.Name = "conErrorList1";
            this.conErrorList1.Size = new System.Drawing.Size(371, 166);
            this.conErrorList1.TabIndex = 4;
            // 
            // conTableAction1
            // 
            this.conTableAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conTableAction1.Location = new System.Drawing.Point(488, 174);
            this.conTableAction1.Margin = new System.Windows.Forms.Padding(4);
            this.conTableAction1.Name = "conTableAction1";
            this.conTableAction1.Size = new System.Drawing.Size(367, 162);
            this.conTableAction1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.conDataTotal1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.conTableState1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 385);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1009, 156);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // conDataTotal1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.conDataTotal1, 2);
            this.conDataTotal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conDataTotal1.Location = new System.Drawing.Point(2, 2);
            this.conDataTotal1.Margin = new System.Windows.Forms.Padding(2);
            this.conDataTotal1.Name = "conDataTotal1";
            this.conDataTotal1.Size = new System.Drawing.Size(436, 152);
            this.conDataTotal1.TabIndex = 0;
            // 
            // conTableState1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.conTableState1, 2);
            this.conTableState1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conTableState1.Location = new System.Drawing.Point(442, 2);
            this.conTableState1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conTableState1.Name = "conTableState1";
            this.conTableState1.Size = new System.Drawing.Size(565, 152);
            this.conTableState1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel4.Controls.Add(this.conMainControl1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.conCoordinate1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.conMainControlAuto1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 548);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1009, 146);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // conMainControl1
            // 
            this.conMainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMainControl1.Location = new System.Drawing.Point(2, 2);
            this.conMainControl1.Margin = new System.Windows.Forms.Padding(2);
            this.conMainControl1.Name = "conMainControl1";
            this.conMainControl1.Size = new System.Drawing.Size(258, 142);
            this.conMainControl1.TabIndex = 0;
            // 
            // conCoordinate1
            // 
            this.conCoordinate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conCoordinate1.Location = new System.Drawing.Point(749, 2);
            this.conCoordinate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conCoordinate1.Name = "conCoordinate1";
            this.conCoordinate1.Size = new System.Drawing.Size(258, 142);
            this.conCoordinate1.TabIndex = 1;
            // 
            // conMainControlAuto1
            // 
            this.conMainControlAuto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMainControlAuto1.Location = new System.Drawing.Point(264, 2);
            this.conMainControlAuto1.Margin = new System.Windows.Forms.Padding(2);
            this.conMainControlAuto1.Name = "conMainControlAuto1";
            this.conMainControlAuto1.Size = new System.Drawing.Size(481, 142);
            this.conMainControlAuto1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Trang Chính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.cMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panelASCamera.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsChoosePrf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Control.ConMainControl conMainControl1;
        private Control.ConCoordinate conCoordinate1;
        private Control.ConMainControlAuto conMainControlAuto1;
        private System.Windows.Forms.ToolStripComboBox tsChooseModel;
        private System.Windows.Forms.ToolStripMenuItem tsSettingModel;
        private Control.ConDataTotal conDataTotal1;
        private Control.ConDeviceConnection conDeviceConnection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Timer timer1;
        private Control.conErrorList conErrorList1;
        private System.Windows.Forms.ToolStripComboBox tsAccess;
        private Control.ConTableState conTableState1;
        private Control.ConTableAction conTableAction1;
        private System.Windows.Forms.ToolStripMenuItem tsSettingMachine;
        private System.Windows.Forms.ToolStripMenuItem tsMaster;
        private System.Windows.Forms.ToolStripMenuItem tsData;
        private System.Windows.Forms.ToolStripMenuItem chếĐộHoạtĐộngToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsCheckGlue;
        private System.Windows.Forms.ToolStripComboBox tsWrongprd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelASCamera;
        private System.Windows.Forms.Button btRotateLeft;
        private System.Windows.Forms.Button btRotateRight;
        private System.Windows.Forms.ToolStripMenuItem tsNeedleDisplay;
        private System.Windows.Forms.ToolStripMenuItem tsTestMode;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay;
        private System.Windows.Forms.ToolStripMenuItem frmLimit;
    }
}