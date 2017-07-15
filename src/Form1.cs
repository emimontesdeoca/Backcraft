using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace backcraft
{
    public partial class Form1 : Form
    {
        public CancellationTokenSource token = new CancellationTokenSource();

        public Form1()
        {

            //string builder = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft";

            InitializeComponent();

            #region Folder creation and files creation

            /// Create data folder if not created for user settings
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");

                if (!File.Exists("data/bsettings.txt"))
                {
                    //File.Create("data/bsettings.txt");
                }
                if (!File.Exists("data/msettings.txt"))
                {
                    //File.Create("data/msettings.txt");
                }
            }

            /// Create backup folder if not created for backups
            if (!Directory.Exists("backups"))
            {
                Directory.CreateDirectory("backups");
            }

            #endregion

            notifyIcon1.BalloonTipTitle = "Backcraft minimized!";
            notifyIcon1.BalloonTipText = "Backcraft will be running in the background.";

            try
            {

                #region Minecraft settings 

                /// Getting minecraft settings
                try
                {
                    string[] b = new data.msettings().GetMinecraftSettingsData();

                    /// Resource folder checkbox
                    set_resource.Checked = Convert.ToBoolean(b[1]);
                    /// Launcher options file checkbox
                    set_launcher.Checked = Convert.ToBoolean(b[2]);
                    /// Screenshots folder checkbox
                    set_screenshots.Checked = Convert.ToBoolean(b[3]);
                    /// Options file checkbox
                    set_options.Checked = Convert.ToBoolean(b[4]);
                    /// Saves folder checkbox
                    set_saves.Checked = Convert.ToBoolean(b[5]);
                }
                catch (Exception)
                {
                    throw;
                }

                #endregion

                #region Backcraft settings

                /// Getting backcraft settings
                try
                {
                    string[] c = new data.bsettings().GetBackcraftSettingsData();
                    /// Backcraft enabled checkbox
                    back_enable.Checked = Convert.ToBoolean(c[0]);
                    /// Save log enabled checkbox
                    back_enablelog.Checked = Convert.ToBoolean(c[1]);
                    /// 7zip path enabled checkbox
                    //back_7zippath.Text = c[2];
                    //if (c[2] == @"C:\Program Files\7-Zip\7z.exe")
                    //{
                    //    acc_default7zip.Checked = true;
                    //}
                    //else
                    //{
                    //    acc_default7zip.Checked = false;

                    //}
                    ///// 7zip path enabled checkbox
                    //back_backupfolderpath.Text = c[3];
                    //if (c[3] == @"backups\")
                    //{
                    //    checkBox1.Checked = true;
                    //}
                    //else
                    //{
                    //    checkBox1.Checked = false;

                    //}

                    /// Interval value
                    //switch (Convert.ToInt32(c[4]))
                    //{
                    //    case 5:
                    //        radioButton1.Checked = true;
                    //        break;
                    //    case 10:
                    //        radioButton2.Checked = true;
                    //        break;
                    //    case 30:
                    //        radioButton3.Checked = true;
                    //        break;
                    //    case 60:
                    //        radioButton4.Checked = true;
                    //        break;
                    //}
                    ///Startup

                    back_startup.Checked = Convert.ToBoolean(c[5]);

                }
                catch (Exception)
                {
                    throw;
                }

                #endregion

                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                ShowIcon = true;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(50);

            }
            catch (Exception)
            {
                ShowInTaskbar = true;
                ShowIcon = false;
            }



            #region Forms settings



            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int interval = Convert.ToInt32(new data.bsettings().GetBackcraftSettingsData()[4]);

            CancellationToken cancel = new CancellationToken();
            cancel = token.Token;

            if (!Convert.ToBoolean(new data.bsettings().GetBackcraftSettingsData()[0]))
            {
                token.Cancel();
            }

            //var x = AsyncBackcraft(interval);
        }

        public async Task AsyncBackcraft(int interval)
        {
            while (!token.IsCancellationRequested)
            {
                if (CheckIfMinecraftIsRunning())
                {
                    await Backcraft();
                    try
                    {
                        await Task.Delay(TimeSpan.FromMinutes(interval), token.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
                else
                {
                    await Task.Delay(TimeSpan.FromMinutes(5), token.Token);
                }

            }
        }


        private void back_save_Click(object sender, EventArgs e)
        {
            try
            {
                /// Getting the interval, this is ugly I know, dont killerino me
                int _interval = 5;

                //if (radioButton1.Checked)
                //{
                //    _interval = 5;
                //}
                //else if (radioButton2.Checked)
                //{
                //    _interval = 10;
                //}
                //else if (radioButton3.Checked)
                //{
                //    _interval = 30;
                //}
                //else if (radioButton4.Checked)
                //{
                //    _interval = 60;
                //}

                /// Save settings data
                //new data.msettings().WriteSettings(set_folderlocation.Text.ToString(), set_resource.Checked, set_launcher.Checked, set_screenshots.Checked, set_options.Checked, set_saves.Checked);

                /// Save backcraft data
                //new data.bsettings().WriteSettings(back_enable.Checked, back_enablelog.Checked, back_7zippath.Text, back_backupfolderpath.Text, _interval, back_startup.Checked);


                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (back_startup.Checked)
                {
                    registryKey.SetValue("Backcraft", Application.ExecutablePath);
                }
                else
                {
                    registryKey.DeleteValue("Backcraft");
                }


                /// Change text value for btn
                back_save.Text = "Saved!";

                try
                {
                    Process.Start(Application.StartupPath + "\\backcraft.exe");
                    Process.GetCurrentProcess().Kill();
                }
                catch
                { }
            }
            catch (Exception err)
            {
                string a = err.ToString();
                /// Change text value for btn
                back_save.Text = "Error!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// Link to github repo
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/backcraft");
        }

        private async Task Backcraft()
        {
            #region Make folder

            /// Save log
            if (back_enablelog.Checked)
            {
                new data.bsettings().WriteLog("", "", 0);
            }

            /// Build folderpath string
            string folderpath = "backups\\Backcraft_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString();
            folderpath = folderpath.Replace('/', '-').Replace(':', '-');

            /// Create path
            Directory.CreateDirectory(folderpath);

            /// Save log
            if (back_enablelog.Checked)
            {
                new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder created - " + folderpath, 1);
            }

            /// Get Minecraft folder location
            string folderlocation = ""; /*set_folderlocation.Text.ToString();*/

            #endregion

            #region Copy files 

            try
            {
                /// If resource folder is checked, copy for the backup
                if (set_resource.Checked)
                {
                    /// Copy to the backup folder
                    bs.compression.Copy(folderlocation + "\\resourcepacks", folderpath + "\\resourcepacks");

                    /// Save log
                    if (back_enablelog.Checked)
                    {
                        new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder copied from: " + folderlocation + "\\resourcepacks" + " to " + folderpath + "\\resourcepacks", 1);
                    }
                }
                /// If launcher file is checked, copy for the backup
                if (set_launcher.Checked)
                {
                    /// Copy to the backup folder
                    File.Copy(folderlocation + "\\launcher_profiles.json", folderpath + "\\launcher_profiles");

                    /// Save log
                    if (back_enablelog.Checked)
                    {
                        new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "File copied from: " + folderlocation + "\\launcher_profiles.json" + " to " + folderpath + "\\launcher_profiles.json", 1);
                    }
                }
                /// If screenshots folder is checked, copy for the backup
                if (set_screenshots.Checked)
                {
                    /// Copy to the backup folder
                    bs.compression.Copy(folderlocation + "\\screenshots", folderpath + "\\screenshots");

                    /// Save log
                    if (back_enablelog.Checked)
                    {
                        new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder copied from: " + folderlocation + "\\screenshots" + " to " + folderpath + "\\screenshots", 1);
                    }
                }
                /// If options file is checked, copy for the backup
                if (set_options.Checked)
                {
                    /// Copy to the backup folder
                    File.Copy(folderlocation + "\\options.txt", folderpath + "\\options.txt");

                    /// Save log
                    if (back_enablelog.Checked)
                    {
                        new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "File copied from: " + folderlocation + "\\options.txt" + " to " + folderpath + "\\options.txt", 1);
                    }
                }
                /// If saves folder is checked, copy for the backup
                if (set_saves.Checked)
                {
                    /// Copy to the backup folder
                    bs.compression.Copy(folderlocation + "\\saves", folderpath + "\\saves");

                    /// Save log
                    if (back_enablelog.Checked)
                    {
                        new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder copied from: " + folderlocation + "\\saves" + " to " + folderpath + "\\saves", 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem copying some files!", "Backcraft");
            }

            #endregion

            #region Compression

            try
            {
                string fileName = folderpath;
                FileInfo f = new FileInfo(fileName);
                string fullname = f.FullName;

                /// Compress it with 7Zip
                //bs.compression.CreateZipFile(back_7zippath.Text, back_backupfolderpath.Text + "\\" + fileName.Split('\\')[1], fullname);
                //bs.compression.CreateZipFile(back_7zippath.Text, folderpath, fullname);

                /// Save log
                if (back_enablelog.Checked)
                {
                    new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder compressed in : " + folderpath + ".7z", 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem compressing the folder!", "Backcraft");
            }


            #endregion

            #region Delete folder

            try
            {
                /// Delete recursively the folder created
                Directory.Delete(folderpath, true);

                /// Save log
                if (back_enablelog.Checked)
                {
                    new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder deleted: " + folderpath, 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem deleting the folder!", "Backcraft");
            }

            #endregion
        }

        private bool CheckIfMinecraftIsRunning()
        {
            bool res = false;
            var runningProcessByName = Process.GetProcessesByName("javaw");
            if (runningProcessByName.Length > 0)
            {
                return true;
            }
            else
            {
                return res;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var a = Backcraft();
            }
            catch (Exception)
            {
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                ShowIcon = true;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(250);

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                ShowIcon = false;
                notifyIcon1.Visible = false;

            }
            catch (Exception)
            {

            }

        }

        #region BACKCRAFT

        #region ENABLING

        private void back_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (back_enable.Checked)
            {
                b_panel.Enabled = true;
                m_panel.Enabled = true;
            }
            else
            {
                b_panel.Enabled = false;
                m_panel.Enabled = false;
            }
        }

        #endregion

        #region SETTINGS

        #region CHECKBOXES

        private void back_enablelog_CheckedChanged(object sender, EventArgs e)
        {
            if (back_enablelog.Checked)
            {
                label_checkboxlogs.Enabled = true;
                label_logs.Enabled = true;
            }
            else
            {
                label_checkboxlogs.Enabled = false;
                label_logs.Enabled = false;
            }
        }

        private void back_startup_CheckedChanged(object sender, EventArgs e)
        {
            if (back_startup.Checked)
            {
                label_checkboxstartup.Enabled = true;
                label_startup.Enabled = true;
            }
            else
            {
                label_checkboxstartup.Enabled = false;
                label_startup.Enabled = false;
            }
        }

        #endregion

        #region BUTTONS

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #endregion

        #region MINECRAFT SETTINGS

        #region ACTIVATING CHECKBOXES

        private void set_resource_CheckedChanged(object sender, EventArgs e)
        {
            if (set_resource.Checked)
            {
                label_resource.Enabled = true;
                label_checkboxresources.Enabled = true;
                btn_resourcepacks.Enabled = true;
            }
            else
            {
                label_resource.Enabled = true;
                label_checkboxresources.Enabled = true;
                btn_resourcepacks.Enabled = true;
            }
        }

        private void set_saves_CheckedChanged(object sender, EventArgs e)
        {
            if (set_saves.Checked)
            {
                label_checkboxsaves.Enabled = true;
                label_saves.Enabled = true;
                btn_saves.Enabled = true;
            }
            else
            {
                label_checkboxsaves.Enabled = true;
                label_saves.Enabled = true;
                btn_saves.Enabled = true;
            }
        }

        private void set_launcher_CheckedChanged(object sender, EventArgs e)
        {
            if (set_launcher.Checked)
            {
                label_checkboxlauncher.Enabled = true;
                label_launcher.Enabled = true;
            }
            else
            {
                label_checkboxlauncher.Enabled = true;
                label_launcher.Enabled = true;
            }
        }

        private void set_options_CheckedChanged(object sender, EventArgs e)
        {
            if (set_launcher.Checked)
            {
                label_checkboxoptions.Enabled = true;
                label_options.Enabled = true;
            }
            else
            {
                label_checkboxoptions.Enabled = true;
                label_options.Enabled = true;
            }
        }

        private void set_screenshots_CheckedChanged(object sender, EventArgs e)
        {
            if (set_launcher.Checked)
            {
                label_checkboxscreenshots.Enabled = true;
                label_screenshots.Enabled = true;
            }
            else
            {
                label_checkboxscreenshots.Enabled = true;
                label_screenshots.Enabled = true;
            }
        }

        #endregion

        #region BUTTONS

        private void btn_minecraftfolder_Click(object sender, EventArgs e)
        {

        }

        private void btn_resourcepacks_Click(object sender, EventArgs e)
        {

        }

        private void btn_saves_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #endregion


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void m_panel_Enter(object sender, EventArgs e)
        {

        }
    }
}
