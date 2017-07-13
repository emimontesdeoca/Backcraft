﻿using System;
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

namespace backcraft
{
    public partial class Form1 : Form
    {
        public CancellationTokenSource token = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();

            #region Folder creation

            /// Create data folder if not created for user settings
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            /// Create backup folder if not created for backups
            if (!Directory.Exists("backups"))
            {
                Directory.CreateDirectory("backups");
            }

            #endregion

            #region Account data

            /// Getting user data
            try
            {
                string[] a = new data.gdrive().GetUserData();

                acc_username.Text = a[0];
                acc_password.Text = a[1];
            }
            catch (Exception)
            {
            }

            #endregion

            #region Minecraft settings 

            /// Getting minecraft settings
            try
            {
                string[] b = new data.msettings().GetMinecraftSettingsData();

                /// Folder location string
                set_folderlocation.Text = b[0].ToString();
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
                /// Supload enabled checkbox
                back_uploadtodrive.Checked = Convert.ToBoolean(c[2]);
                /// save offline enabled checkbox
                back_saveofflinebackup.Checked = Convert.ToBoolean(c[3]);


                /// Interval value
                switch (Convert.ToInt32(c[4]))
                {
                    case 5:
                        radioButton1.Checked = true;
                        break;
                    case 10:
                        radioButton2.Checked = true;
                        break;
                    case 30:
                        radioButton3.Checked = true;
                        break;
                    case 60:
                        radioButton4.Checked = true;
                        break;
                }

            }
            catch (Exception)
            {
            }

            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int interval = Convert.ToInt32(new data.bsettings().GetBackcraftSettingsData()[4]);

            CancellationToken cancel = new CancellationToken();
            cancel = token.Token;

            var x = AsynBackcraft(interval);
        }

        public async Task AsynBackcraft(int interval)
        {
            while (!token.IsCancellationRequested)
            {
                if (CheckIfMinecraftIsRunning())
                {
                    await Backcraft();
                    try
                    {
                        await Task.Delay(TimeSpan.FromSeconds(interval), token.Token);
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
        private void account_save_Click(object sender, EventArgs e)
        {
            try
            {
                /// Save account data
                new data.gdrive().WriteSettings(acc_username.Text.ToString(), acc_password.Text.ToString());

                /// Change text value for btn
                account_save.Text = "Saved!";
            }
            catch (Exception)
            {
                /// Change text value for btn
                account_save.Text = "Error!";
            }

        }

        private void sett_searchfolder_Click(object sender, EventArgs e)
        {
            /// Browse for folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                set_folderlocation.Text = fbd.SelectedPath.ToString();
            }
        }

        private void settings_save_Click(object sender, EventArgs e)
        {
            try
            {
                /// Save settings data
                new data.msettings().WriteSettings(set_folderlocation.Text.ToString(), set_resource.Checked, set_launcher.Checked, set_screenshots.Checked, set_options.Checked, set_saves.Checked);

                /// Change text value for btn
                settings_save.Text = "Saved!";
            }
            catch (Exception)
            {
                /// Change text value for btn
                settings_save.Text = "Error!";
            }
        }

        private void back_save_Click(object sender, EventArgs e)
        {
            /// Getting the interval, this is ugly I know, dont killerino me
            int _interval = 0;

            if (radioButton1.Checked)
            {
                _interval = 5;
            }
            else if (radioButton2.Checked)
            {
                _interval = 10;
            }
            else if (radioButton3.Checked)
            {
                _interval = 30;
            }
            else if (radioButton4.Checked)
            {
                _interval = 60;
            }

            try
            {
                /// Save backcraft data
                new data.bsettings().WriteSettings(back_enable.Checked, back_enablelog.Checked, back_uploadtodrive.Checked, back_saveofflinebackup.Checked, _interval);

                /// Change text value for btn
                back_save.Text = "Saved!";
            }
            catch (Exception)
            {
                /// Change text value for btn
                back_save.Text = "Error!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backcraft();
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
            string folderlocation = set_folderlocation.Text.ToString();

            #endregion

            #region Copy files 

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

            #endregion

            #region Compression

            /// Compress it with 7Zip
            bs.compression.CreateZipFile(folderpath, folderpath);

            /// Save log
            if (back_enablelog.Checked)
            {
                new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder compressed in : " + folderpath + ".7z", 1);
            }

            #endregion

            #region Delete folder


            /// Delete recursively the folder created
            Directory.Delete(folderpath, true);

            /// Save log
            if (back_enablelog.Checked)
            {
                new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Folder deleted: " + folderpath, 1);
            }

            #endregion

            #region Upload to drive


            /// Upload to drive 
            if (back_uploadtodrive.Checked)
            {
                /// Save log
                if (back_enablelog.Checked)
                {
                    new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Starting backup uploaded to Drive: " + folderpath + ".7z", 1);
                }

                /// Save log
                if (back_enablelog.Checked)
                {
                    new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "Backup uploaded to Drive: " + folderpath + ".7z", 1);
                }
            }

            #endregion

            #region Save offline backup

            /// Save offline backup
            if (!back_saveofflinebackup.Checked)
            {
                File.Delete(folderpath + ".7z");

                /// Save log
                if (back_enablelog.Checked)
                {
                    new data.bsettings().WriteLog(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString(), "7zip file deleted: " + folderpath + ".7z", 1);
                }
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
    }
}
