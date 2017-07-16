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
        public bool _LauncherOptionsSate { get; set; }
        public bool _OptionsState { get; set; }
        public bool _ScreenshotsState { get; set; }
        public bool _LogsState { get; set; }
        public bool _StartupState { get; set; }
        public int _IntervalTime { get; set; }

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = this.Icon.ToBitmap();

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

            _MinecraftPath = logic.minecraftpath.GetMinecraftPath();
            _Backcraft7ZipPath = logic._7zippath.Get7ZipPath();
            _EnableBackcraftState = logic.backcraft.GetBackcraftState();
            _ResourcePackState = logic.resourcepackstate.GetResourcePackState();
            _SavesState = logic.worldstate.GetWorldsState();
            _LauncherOptionsSate = logic.launcherprofiles.GetLauncherOptionsState();
            _OptionsState = logic.options.GetOptionsState();
            _ScreenshotsState = logic.screenshots.GetScreenshotsState();
            _LogsState = logic.logs.GetLogsState();
            _StartupState = logic.startup.GetStartupState();
            _IntervalTime = logic.interval.GetIntervalTime();

            foreach (Control c in m_panel.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += GreyOutControlsIfNeeded;
            }

            foreach (Control c in b_panel.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += GreyOutControlsIfNeeded;
            }

            back_enable.Checked = _EnableBackcraftState;
            set_resource.Checked = _ResourcePackState;
            set_saves.Checked = _SavesState;
            set_launcher.Checked = _LauncherOptionsSate;
            set_options.Checked = _OptionsState;
            set_screenshots.Checked = _ScreenshotsState;
            back_enablelog.Checked = _LogsState;
            back_startup.Checked = _StartupState;

            txtMinecraftPath.Text = logic.minecraftpath.GetMinecraftPath ();
            txtPath7Zip.Text = logic._7zippath.Get7ZipPath ();


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

            // LoadMinecraftCheckboxes();

            // If the checkboxes are checked, make their forecolor black.
            // Otherwise, make them gray.


            #endregion

            #region BACKCRAFT

         

            #endregion

            #endregion

            #region LOAD SCROLL AND TEXTBOX

            scroll_interval.Value = _IntervalTime;
            back_intervaltextbox.Text = _IntervalTime.ToString() + " min";

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

        void GreyOutControlsIfNeeded (object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                (sender as CheckBox).ForeColor = Color.Black;
            else
                (sender as CheckBox).ForeColor = Color.FromArgb (128, 128, 128);

            btn_resourcepacks.Enabled = set_resource.Checked;
            btn_saves.Enabled = set_saves.Checked;
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

        #region BUTTONS

        private void btn_minecraftfolder_Click(object sender, EventArgs e)
        {
            new forms.minecraft.m_minecraftpath().ShowDialog();
        }

        private void btn_resourcepacks_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtMinecraftPath.Text))
            {
                MessageBox.Show("The specified Minecraft path doesn't exist!",
                                 "BackCraft",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                new forms.minecraft.m_resourcepacks().ShowDialog();
            }
        }

        private void btn_saves_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtMinecraftPath.Text))
            {
                MessageBox.Show("The specified Minecraft path doesn't exist!",
                                 "BackCraft",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                new forms.minecraft.m_saves().ShowDialog();
            }
        }

        #endregion

        #region SCROLL

        private void scroll_interval_Scroll(object sender, EventArgs e)
        {
            back_intervaltextbox.Text = 
            scroll_interval.Value.ToString() + " min";
        }

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
                #region 7-ZIP AND MINECRAFT PATHS

                new logic._7zippath(txtPath7Zip.Text).WriteToFile();
                Form1._Backcraft7ZipPath = txtPath7Zip.Text;

                new logic.minecraftpath(txtMinecraftPath.Text).WriteToFile();
                Form1._MinecraftPath = txtMinecraftPath.Text;

                #endregion

                #region ENABLE BACKCRAFT

                if (_EnableBackcraftState == back_enable.Checked)
                {
                }
                else
                {
                    new logic.backcraft(back_enable.Checked).WriteToFile();
                }

                #endregion

                #region RESOURCE PACKS STATE

                if (_ResourcePackState == set_resource.Checked)
                {
                }
                else
                {
                    new logic.resourcepackstate(set_resource.Checked).WriteToFile();
                }

                #endregion

                #region WORLDS/SAVES STATE

                if (_SavesState == set_saves.Checked)
                {
                }
                else
                {
                    new logic.worldstate(set_saves.Checked).WriteToFile();
                }

                #endregion

                #region LAUNCHER PROFILES STATE


                if (_LauncherOptionsSate == set_launcher.Checked)
                {
                }
                else
                {
                    if (File.Exists(@"config\launcheroptions.txt"))
                    {
                        logic.launcherprofiles.SetState(set_launcher.Checked);
                    }
                    else
                    {
                        new logic.launcherprofiles("launcher_profiles.json", _MinecraftPath + @"\launcher_profiles.json", set_launcher.Checked).WriteToFile();
                    }

                }

                #endregion

                #region OPTIONS STATE

                if (_OptionsState == set_options.Checked)
                {
                }
                else
                {
                    if (File.Exists(@"config\options.txt"))
                    {
                        logic.options.SetState(set_options.Checked);
                    }
                    else
                    {
                        new logic.options("options.txt", _MinecraftPath + @"\options.txt", set_options.Checked).WriteToFile();
                    }
                }

                #endregion

                #region SCREENSHOTS STATE

                if (_ScreenshotsState == set_screenshots.Checked)
                {
                }
                else
                {
                    if (File.Exists(@"config\screenshots.txt"))
                    {
                        logic.screenshots.SetState(set_screenshots.Checked);
                    }
                    else
                    {
                        new logic.screenshots("screenshots", _MinecraftPath + @"\screenshots", set_screenshots.Checked).WriteToFile();
                    }
                }

                #endregion

                #region LOGS STATE

                if (_LogsState == back_enable.Checked)
                {
                }
                else
                {
                    new logic.logs(back_enable.Checked).WriteToFile();
                }


                #endregion

                #region STARTUP STATE

                if (_StartupState == back_startup.Checked)
                {

                }
                else
                {
                    new logic.startup(back_startup.Checked).WriteToFile();

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
                    new logic.interval(scroll_interval.Value).WriteToFile();
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

            // TODO: check whether settings are valid first

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

        private void m_panel_Enter(object sender, EventArgs e)
        {

        }

        private void btnBrowseMC_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Minecraft folder";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtMinecraftPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnBrowse7Z_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "7-Zip path";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtPath7Zip.Text = folderBrowserDialog1.SelectedPath;
        }

        private void defaultMCPath_Click(object sender, EventArgs e)
        {
            txtMinecraftPath.Text =
            Environment.GetFolderPath 
            (Environment.SpecialFolder.ApplicationData) + @"\.minecraft";
        }

        private void Default7ZPath_Click(object sender, EventArgs e)
        {     
           // TODO: 7-Zip may be located in either Program Files or Program Files (x86)
           txtPath7Zip.Text =
           Environment.GetFolderPath
           (Environment.SpecialFolder.ProgramFiles) + @"\7-Zip\7z.exe";
        }

        private void txtMinecraftPath_MouseLeave(object sender, EventArgs e)
        {
            // TODO: there should be a better time to save these settings
            new logic.minecraftpath(txtMinecraftPath.Text).WriteToFile();
            Form1._MinecraftPath = txtMinecraftPath.Text;
        }

        private void txtPath7Zip_MouseLeave(object sender, EventArgs e)
        {
            // TODO: there should be a better time to save these settings
            new logic._7zippath(txtPath7Zip.Text).WriteToFile();
            Form1._Backcraft7ZipPath = txtPath7Zip.Text;
        }

    }
}
