using System;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Cognex.InSight;
using System.IO;

namespace SEMV_Dispencer_V1.Screen
{
    public partial class frmMain : Form
    {
        private int accessIndex = 0;
        //private CvsInSight _camIS;
        private Process p;
        public static bool ChoosePrdForm = false;
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //static extern IntPtr SetParent(IntPtr hWnd, IntPtr hParent);
        public frmMain()
        {
            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            InitializeComponent();
            LoadModelName();
            tsCheckGlue.SelectedIndex = RunProgram.Settings.GlueActive;
            tsWrongprd.SelectedIndex = RunProgram.Settings.WrongActive;
            tsAccess.SelectedIndex = 0;
        }
        private void cMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Enabled = true;
            //DisplayASCamera();
        }
        private void DisplayASCamera()
        {
            if(RunProgram.CheckNeedleApp())
            {
                try
                {
                    string files = Path.Combine(RunProgram.AsApp.FileName);
                    p = Process.Start(files);
                    p.WaitForInputIdle();
                    while (p.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(100);
                        p.Refresh();
                    }
                }
                catch(Exception) { }
            }

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(p!=null) p.Close();
            }
            catch
            { }
            try
            {
                DeviceConnection.cSensorHeight.Dispose();
            }
            catch
            { }

            //IsDisplay.Disconnect();

        }
        #region Form Event
        private void tsNeedleDisplay_Click(object sender, EventArgs e)
        {
            DisplayASCamera();
        }
        private void tsAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsAccess.SelectedIndex > 0)
            {
                frmAccess frm = new frmAccess();
                DialogResult = frm.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    accessIndex = tsAccess.SelectedIndex;
                }
                else tsAccess.SelectedIndex = accessIndex;
            }
            else
            {
                accessIndex = 0;
                RunProgram.AccessLevel = 0;
            }

        }
        private void tsChooseProduct_Click(object sender, EventArgs e)
        {
            if(!ChoosePrdForm)
            {
                ChoosePrdForm = true;
                frmProduct1 frm = new frmProduct1();
                frm.Show();
            }    

        }
        private void tsTestMode_Click(object sender, EventArgs e)
        {
            if (RunProgram.AccessLevel > 1)
            {
                frmModelTest frm = new frmModelTest();
                frm.Show();
            }
            else MessageBox.Show("Please Access with Master!", "Access", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void frmLimit_Click(object sender, EventArgs e)
        {
            if (RunProgram.AccessLevel > 0)
            {
                frmTeachingLimit frm = new frmTeachingLimit();
                frm.Show();
            }
            else MessageBox.Show("Please Access with Admin!", "Access", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void tsSettingModel_Click(object sender, EventArgs e)
        {
            if (RunProgram.AccessLevel > 0)
            {
                frmTeachingModel frm = new frmTeachingModel();
                frm.Show();
                //DisconnectIS();
                //if (results == DialogResult.OK)
                //{
                    //LoadModelName();
                //    //ConnectIS();
                //}
            }
            else MessageBox.Show("Please Access with Admin!", "Access", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void tsMaster_Click(object sender, EventArgs e)
        {
            if (RunProgram.AccessLevel > 1)
            {
                frmMaster frm = new frmMaster();
                frm.ShowDialog();
            }
            else MessageBox.Show("Please Access with Master!", "Access", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void tsData_Click(object sender, EventArgs e)
        {
            if (RunProgram.AccessLevel > 1)
            {
                frmTeachingData frm = new frmTeachingData();
                frm.Show();
            }
            else MessageBox.Show("Please Access with Master!", "Access", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void tsAdjustPosition_Click(object sender, EventArgs e)
        {

        }
        private void tsGlueCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

            RunProgram.SendGlueSetting(tsCheckGlue.SelectedIndex);
        }
        private void tsWrongprd_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunProgram.SendWrongSetting(tsWrongprd.SelectedIndex);
        }
        private void tsChooseModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunProgram.ActiveModel(tsChooseModel.SelectedIndex);
            LoadISJob();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectIS();
        }
        #endregion
        //Camera IS
        private void ConnectIS()
        {
            try
            {
                if (!(cvsInSightDisplay.Connected))
                {
                    cvsInSightDisplay.Connect(DeviceConnection.cCameraIS.Instance.Setting.Ip, "admin", "", false); //
                    cvsInSightDisplay.ShowGraphics = true;
                }
                else
                {
                    cvsInSightDisplay.Disconnect();
                }
               
                Refresh();
            }
            catch (CvsInSightLockedException)
            {
                // The sensor has been software-locked, preventing a connection.
                // Display a message and consume the exception.
                Console.WriteLine("The sensor is currently locked.");
            }

            catch (CvsSensorAlreadyConnectedException)
            {
                // Someone is already connected to this sensor.
                // Display a message and consume the exception.
                Console.WriteLine("A user currently has an open connection to the sensor.");
            }

            catch (CvsInvalidLogonException ex)
            {
                // If we receive an invalid logon, then we can look at the IsInvalidUsername property 
                // to find out more about the exception.
                if (ex.IsInvalidUsername)
                    Console.WriteLine("Invalid Username");
                else
                    Console.WriteLine("Invalid Password");
            }

            catch (CvsNetworkException ex)
            {
                // Unable to successfully connect to the sensor.
                // Display a message and consume the exception.
                Console.WriteLine("A network error occurred while connecting to the sensor: " + ex.Message);
            }

            catch (Exception ex)
            {
                // Consume any other exception that may occur
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                
            }
            btnConnect.BackgroundImage = cvsInSightDisplay.Connected ? Properties.Resources.live : Properties.Resources.live_Off;

        }
        private void DisconnectIS()
        {
            cvsInSightDisplay.Disconnect();
        }
        #region Radio Image Zoom Button Events
        private void btnMax_Click(object sender, EventArgs e)
        {
            cvsInSightDisplay.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            cvsInSightDisplay.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (cvsInSightDisplay != null)
            {
                cvsInSightDisplay.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
                cvsInSightDisplay.ImageScale += 0.05;
            }
            
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (cvsInSightDisplay != null)
            {
                cvsInSightDisplay.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
                cvsInSightDisplay.ImageScale -= 0.05;
            }
               
        }
        private void btRotateLeft_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cvsInSightDisplay.ImageOrientation)
                {
                    case CvsImageOrientation.Normal:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.RotateClockwise90;
                            break;
                        }
                    case CvsImageOrientation.RotateClockwise90:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.Rotate180;
                            break;
                        }
                    case CvsImageOrientation.Rotate180:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.RotateCounterclockwise90;
                            break;
                        }
                    case CvsImageOrientation.RotateCounterclockwise90:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.Normal;
                            break;
                        }
                }
            }
            catch
            {

            }
        }

        private void btRotateRight_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cvsInSightDisplay.ImageOrientation)
                {
                    case CvsImageOrientation.Normal:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.RotateCounterclockwise90;
                            break;
                        }
                    case CvsImageOrientation.RotateCounterclockwise90:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.Rotate180;
                            break;
                        }
                    case CvsImageOrientation.Rotate180:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.RotateClockwise90;
                            break;
                        }
                    case CvsImageOrientation.RotateClockwise90:
                        {
                            cvsInSightDisplay.ImageOrientation = CvsImageOrientation.Normal;
                            break;
                        }
                }
            }
            catch
            {

            }
        }
        #endregion
        #region CvsInSightDisplay2 Events

        //The connected state changed within the display control.  Event raised.
        private void CvsInSightDisplay2_ConnectedChanged(object sender, System.EventArgs e)
        {
            if (cvsInSightDisplay.Connected)
            {
                btnConnect.BackgroundImage = Properties.Resources.live;

            }
            else
            {
                btnConnect.BackgroundImage = Properties.Resources.live_Off;
            }
            //btnConnect.Text = "&Connect";
        }

        //The state changed within the display control.  Event raised.
        private void CvsInSightDisplay2_StateChanged(object sender, EventArgs e)
        {
            //UpdateStateMsg();
        }

        //The display control is now connected.  Event raised.
        private double _scale = 0;
        private void CvsInSightDisplay2_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            cvsInSightDisplay.ShowImage = true;
            cvsInSightDisplay.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
            _scale = cvsInSightDisplay.GridOpacity;
            //if (cvsInSightDisplay.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.None)
            //    rbNone.Checked = true;
            //else if (cvsInSightDisplay.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit)
            //    rbFit.Checked = true;
            //else if (cvsInSightDisplay.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill)
            //    rbFill.Checked = true;
        }

        //The status changed within the display control.  Event raised.
        private void CvsInSightDisplay2_StatusInformationChanged(object sender, System.EventArgs e)
        {
            //StatusBar1.Panels[1].Text = cvsInSightDisplay.StatusInformation;
        }
        #endregion
        private void LoadModelName()
        {
            tsChooseModel.Items.Clear();
            int activeModel = 0;
            var models = RunProgram.Models;
            for (int i = 0; i< models.Count; i++)
            {
                if(models[i].Active) activeModel = i;
                tsChooseModel.Items.Add(models[i].ModelName);
            }
            tsChooseModel.SelectedIndex = activeModel;
        }
        private async void LoadISJob()
        {
            
            int tick = 0;
            while(!DeviceConnection.cCameraIS.Connected && tick < 3000)
            {
                tick += 100;
                await Task.Delay(100);
            }
            if (tick >= 3000)
            {
                MessageBox.Show("Check Camera Connection!");
            }
            else
            {
                tick = 0;
                Cursor = Cursors.WaitCursor;
                conMainControlAuto1.Enabled = false;
                conMainControl1.Enabled = false;
                menuStrip1.Enabled = false;
                while (DeviceConnection.cCameraIS.nowCommand != DeviceConnection.ISCommand.None && tick < 20000)
                {
                    tick += 100;
                    await Task.Delay(100);
                }
                if (tick >= 20000)
                {
                    MessageBox.Show("Load Job Timeout!");
                }
                else
                {
                    DeviceConnection.cCameraIS.ChangeJob = 0;
                    DeviceConnection.cCameraIS.ChangeISJob(RunProgram.ModelActive.CamId);
                    tick = 0;
                    while (DeviceConnection.cCameraIS.ChangeJob == 0 && tick < 20000)
                    {
                        tick += 100;
                        await Task.Delay(100);
                    }
                    if (tick >= 20000)
                    {
                        MessageBox.Show("Load Job Timeout!");
                    }
                    else

                    {
                        if (DeviceConnection.cCameraIS.ChangeJob == 1)
                        {
                            MessageBox.Show("Load Job Successfull!");
                            DeviceConnection.cCameraIS.ChangeJob = -1;
                        }
                        else
                        {
                            MessageBox.Show("Load Job Fail!");
                        }
                    }
                }
                conMainControlAuto1.Enabled = true;
                conMainControl1.Enabled = true;
                menuStrip1.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            DeviceConnection.cCameraIS.nowCommand = DeviceConnection.ISCommand.None;
            DeviceConnection.cCameraIS.ReadBMP();
        }
    }
}