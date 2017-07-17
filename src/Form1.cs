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
        public static string _MinecraftPath { get; set; }
        public static string _Backcraft7ZipPath { get; set; }
        public bool _EnableBackcraftState { get; set; }
        public bool _ResourcePackState { get; set; }
        public bool _SavesState { get; set; }
        public bool _LauncherProfilesState { get; set; }
        public bool _OptionsState { get; set; }
        public bool _ScreenshotsState { get; set; }
        public bool _LogsState { get; set; }
        public bool _StartupState { get; set; }
        public int _IntervalTime { get; set; } = 5;

        public Form1()
        {
            InitializeComponent();

            #region FOLDER CREATION

            /// Create data folder if not created for user settings
            if (!Directory.Exists("config"))
            {
                Directory.CreateDirectory("config");

            }

            /// Create backup folder if not created for backups
            if (!Directory.Exists("backups"))
            {
                Directory.CreateDirectory("backups");
            }

            #endregion

            #region LOAD STATES AND SET CHECKBOXES

            try
            {
                _MinecraftPath = logic.cfg.GetTypeFromFile("minecraft");
            }
            catch (Exception)
            {
                _MinecraftPath = "";
            }
            try
            {
                _Backcraft7ZipPath = logic.cfg.GetTypeFromFile("7zip");
            }
            catch (Exception)
            {

                _Backcraft7ZipPath = "";
            }
            try
            {
                _EnableBackcraftState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("backcraft"));
            }
            catch (Exception)
            {
                _EnableBackcraftState = false;
            }
            try
            {
                _ResourcePackState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("resource_packs"));
            }
            catch (Exception)
            {
                _ResourcePackState = false;
            }
            try
            {
                _SavesState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("worlds"));
            }
            catch (Exception)
            {
                _SavesState = false;
            }
            try
            {
                _LauncherProfilesState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("launcher_profiles"));
            }
            catch (Exception)
            {
                _LauncherProfilesState = false;
            }
            try
            {
                _OptionsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("options"));
            }
            catch (Exception)
            {
                _OptionsState = false;
            }
            try
            {
                _ScreenshotsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("screenshots"));
            }
            catch (Exception)
            {
                _ScreenshotsState = false;
            }
            try
            {
                _LogsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("logs"));
            }
            catch (Exception)
            {
                _LogsState = false;
            }
            try
            {
                _StartupState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("startup"));
            }
            catch (Exception)
            {
                _StartupState = false;
            }
            try
            {
                _IntervalTime = Convert.ToInt32(logic.cfg.GetTypeFromFile("interval"));

            }
            catch (Exception)
            {

                _IntervalTime = 5;
            }

            back_enable.Checked = _EnableBackcraftState;
            set_resource.Checked = _ResourcePackState;
            set_saves.Checked = _SavesState;
            set_launcher.Checked = _LauncherProfilesState;
            set_options.Checked = _OptionsState;
            set_screenshots.Checked = _ScreenshotsState;
            back_enablelog.Checked = _LogsState;
            back_startup.Checked = _StartupState;


            #endregion

            #region LOAD CHECKBOXES

            #region ENABLE

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

            #endregion

            #region MINECRAFT 

            //LoadMinecraftCheckboxes();

            if (set_resource.Checked)
            {
                label_resource.Enabled = true;
                label_checkboxresources.Enabled = true;
                btn_resourcepacks.Enabled = true;
            }
            else
            {
                label_resource.Enabled = false;
                label_checkboxresources.Enabled = false;
                btn_resourcepacks.Enabled = false;
            }

            if (set_saves.Checked)
            {
                label_checkboxsaves.Enabled = true;
                label_saves.Enabled = true;
                btn_saves.Enabled = true;
            }
            else
            {
                label_checkboxsaves.Enabled = false;
                label_saves.Enabled = false;
                btn_saves.Enabled = false;
            }
            if (set_launcher.Checked)
            {
                label_checkboxlauncher.Enabled = true;
                label_launcher.Enabled = true;
            }
            else
            {
                label_checkboxlauncher.Enabled = false;
                label_launcher.Enabled = false;
            }
            if (set_options.Checked)
            {
                label_checkboxoptions.Enabled = true;
                label_options.Enabled = true;
            }
            else
            {
                label_checkboxoptions.Enabled = false;
                label_options.Enabled = false;
            }
            if (set_screenshots.Checked)
            {
                label_checkboxscreenshots.Enabled = true;
                label_screenshots.Enabled = true;
            }
            else
            {
                label_checkboxscreenshots.Enabled = false;
                label_screenshots.Enabled = false;
            }

            #endregion

            #region BACKCRAFT

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

            #endregion

            #endregion

            #region LOAD SCROLL AND TEXTBOX

            scroll_interval.Value = _IntervalTime;
            back_intervaltextbox.Text = _IntervalTime.ToString();

            #endregion

            #region ICON TRAY SETTINGS

            notifyIcon1.BalloonTipTitle = "Backcraft minimized!";
            notifyIcon1.BalloonTipText = "Backcraft will be running in the background.";

            if (_EnableBackcraftState)
            {
                try
                {
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
            }

            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int interval = _IntervalTime;

            CancellationToken cancel = new CancellationToken();
            cancel = token.Token;

            if (!_EnableBackcraftState)
            {
                token.Cancel();
            }

            //var x = AsyncBackcraft(interval);
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
            new forms.backcraft.b_7zip().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new forms.backcraft.b_backups().ShowDialog();
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
                label_resource.Enabled = false;
                label_checkboxresources.Enabled = false;
                btn_resourcepacks.Enabled = false;
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
                label_checkboxsaves.Enabled = false;
                label_saves.Enabled = false;
                btn_saves.Enabled = false;
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
                label_checkboxlauncher.Enabled = false;
                label_launcher.Enabled = false;
            }
        }

        private void set_options_CheckedChanged(object sender, EventArgs e)
        {
            if (set_options.Checked)
            {
                label_checkboxoptions.Enabled = true;
                label_options.Enabled = true;
            }
            else
            {
                label_checkboxoptions.Enabled = false;
                label_options.Enabled = false;
            }
        }

        private void set_screenshots_CheckedChanged(object sender, EventArgs e)
        {
            if (set_screenshots.Checked)
            {
                label_checkboxscreenshots.Enabled = true;
                label_screenshots.Enabled = true;
            }
            else
            {
                label_checkboxscreenshots.Enabled = false;
                label_screenshots.Enabled = false;
            }
        }

        #endregion

        #region BUTTONS

        private void btn_minecraftfolder_Click(object sender, EventArgs e)
        {
            new forms.minecraft.m_minecraftpath().ShowDialog();
        }

        private void btn_resourcepacks_Click(object sender, EventArgs e)
        {
            new forms.minecraft.m_resourcepacks().ShowDialog();
        }

        private void btn_saves_Click(object sender, EventArgs e)
        {
            new forms.minecraft.m_saves().ShowDialog();
        }

        #endregion

        #region SCROLL

        private void scroll_interval_Scroll(object sender, EventArgs e)
        {
            back_intervaltextbox.Text = scroll_interval.Value.ToString();
        }

        #endregion

        #endregion

        #region LOGIC

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

        private async Task Backcraft()
        {
            #region Make folder


            /// Build folderpath string
            string folderpath = "backups\\Backcraft_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString();
            folderpath = folderpath.Replace('/', '-').Replace(':', '-');

            /// Create path
            Directory.CreateDirectory(folderpath);


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

                }
                /// If launcher file is checked, copy for the backup
                if (set_launcher.Checked)
                {
                    /// Copy to the backup folder
                    File.Copy(folderlocation + "\\launcher_profiles.json", folderpath + "\\launcher_profiles");

                }
                /// If screenshots folder is checked, copy for the backup
                if (set_screenshots.Checked)
                {
                    /// Copy to the backup folder
                    bs.compression.Copy(folderlocation + "\\screenshots", folderpath + "\\screenshots");


                }
                /// If options file is checked, copy for the backup
                if (set_options.Checked)
                {
                    /// Copy to the backup folder
                    File.Copy(folderlocation + "\\options.txt", folderpath + "\\options.txt");


                }
                /// If saves folder is checked, copy for the backup
                if (set_saves.Checked)
                {
                    /// Copy to the backup folder
                    bs.compression.Copy(folderlocation + "\\saves", folderpath + "\\saves");

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

        private void RestartApp()
        {
            try
            {
                Process.Start(Application.StartupPath + "\\backcraft.exe");
                Process.GetCurrentProcess().Kill();
            }
            catch
            { }
        }

        #endregion

        #region SYSTEM TRAY AND WINDOWS SIZE

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

        #endregion

        #region BUTTONS

        private void back_save_Click(object sender, EventArgs e)
        {
            try
            {

                #region ENABLE BACKCRAFT

                if (_EnableBackcraftState == back_enable.Checked)
                {
                }
                else
                {
                    new logic.cfg("backcraft", back_enable.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region RESOURCE PACKS STATE

                if (_ResourcePackState == set_resource.Checked)
                {
                }
                else
                {
                    new logic.cfg("resource_packs", set_resource.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region WORLDS/SAVES STATE

                if (_SavesState == set_saves.Checked)
                {
                }
                else
                {
                    new logic.cfg("worlds", set_saves.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region LAUNCHER PROFILES STATE


                if (_LauncherProfilesState == set_launcher.Checked)
                {
                }
                else
                {
                    new logic.cfg("launcher_profiles", set_launcher.Checked.ToString()).WriteCFG();

                }

                #endregion

                #region OPTIONS STATE

                if (_OptionsState == set_options.Checked)
                {
                }
                else
                {
                    new logic.cfg("options", set_options.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region SCREENSHOTS STATE

                if (_ScreenshotsState == set_screenshots.Checked)
                {
                }
                else
                {
                    new logic.cfg("screenshots", set_options.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region LOGS STATE

                if (_LogsState == back_enablelog.Checked)
                {
                }
                else
                {
                    new logic.cfg("logs", back_enablelog.Checked.ToString()).WriteCFG();
                }

                #endregion

                #region STARTUP STATE

                if (_StartupState == back_startup.Checked)
                {
                }
                else
                {
                    new logic.cfg("startup", set_options.Checked.ToString());
                    RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                    if (back_startup.Checked)
                    {
                        registryKey.SetValue("Backcraft", Application.ExecutablePath);
                    }
                    else
                    {
                        registryKey.DeleteValue("Backcraft");
                    }
                }

                #endregion

                #region INTERVAL STATE

                if (_IntervalTime == scroll_interval.Value)
                {
                }
                else
                {
                    new logic.cfg("interval", scroll_interval.Value.ToString()).WriteCFG();
                }

                #endregion

                RestartApp();
            }
            catch (Exception err)
            {
                string a = err.ToString();
                /// Change text value for btn
                back_save.Text = "Error!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /// BACKUP NOW BUTTON
            try
            {
                var a = Backcraft();
            }
            catch (Exception)
            {
            }
        }

        private void btn_deletesettings_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"config", true);
            RestartApp();
        }

        #endregion

        #region BUTTON LABELS

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// Link to github repo
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/backcraft");
        }


        #endregion

    }
}
