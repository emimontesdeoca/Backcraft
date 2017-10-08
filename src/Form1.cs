using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace backcraft
{
    public partial class Form1 : Form
    {
        #region VARS

        /// <summary>
        /// Log state
        /// </summary>
        public static bool _LogsState { get; set; }
        /// <summary>
        /// Updater state
        /// </summary>
        public static bool _EnableCheckUpdates { get; set; }
        /// <summary>
        /// Token for async methods
        /// </summary>
        public CancellationTokenSource token = new CancellationTokenSource();
        /// <summary>
        /// Minecraft path
        /// </summary>
        public static string _MinecraftPath { get; set; }
        /// <summary>
        /// 7-zip path
        /// </summary>
        public static string _Backcraft7ZipPath { get; set; }
        /// <summary>
        /// App state
        /// </summary>
        public bool _EnableBackcraftState { get; set; }
        /// <summary>
        /// Resource packs state
        /// </summary>
        public bool _ResourcePackState { get; set; }
        /// <summary>
        /// Worlds state
        /// </summary>
        public bool _SavesState { get; set; }
        /// <summary>
        /// Launcher profiles state
        /// </summary>
        public bool _LauncherProfilesState { get; set; }
        /// <summary>
        /// Options state
        /// </summary>
        public bool _OptionsState { get; set; }
        /// <summary>
        /// Screenshots state
        /// </summary>
        public bool _ScreenshotsState { get; set; }
        /// <summary>
        /// Startup state
        /// </summary>
        public bool _StartupState { get; set; }
        /// <summary>
        /// Interval value, min is 5 if not configured
        /// </summary>
        public int _IntervalTime { get; set; }
        /// <summary>
        /// Array of states
        /// </summary>
        public static bool[] states = new bool[6];
        /// <summary>
        /// App version
        /// </summary>
        public static string currentVersion = "3.3";

        #endregion

        private void GreyOutUncheckedCheckboxes(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                (sender as CheckBox).ForeColor = Color.Black;
            else
                (sender as CheckBox).ForeColor = Color.DarkGray;
        }

        public Form1()
        {
            InitializeComponent();

            #region INITIAL STYLING

            MaximizeBox = false;
            label_version.Text = "v" + currentVersion;

            this.Icon = backcraft.Properties.Resources.icon;

            #endregion

            #region HANDLERS TO GREY OUT UNCHECKED CHECKBOXES

            foreach (Control c in m_panel.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += GreyOutUncheckedCheckboxes;
            }

            foreach (Control c in b_panel.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += GreyOutUncheckedCheckboxes;
            }

            #endregion

            #region IMAGES

            Bitmap settingsImg = Properties.Resources.settings;

            Bitmap bugReportImg = Properties.Resources.bug;

            btn_report.Image = bugReportImg;
            btn_report.ImageAlign = ContentAlignment.MiddleCenter;


            Bitmap infoImg = Properties.Resources.info;

            btn_info.Image = infoImg;
            btn_info.ImageAlign = ContentAlignment.MiddleCenter;


            Bitmap closeImg = Properties.Resources.close;

            btn_close.Image = closeImg;
            btn_close.ImageAlign = ContentAlignment.MiddleCenter;


            Bitmap folderImg = Properties.Resources.folder;

            btn_minecraftfoldersearch.Image = folderImg;
            btn_minecraftfoldersearch.ImageAlign = ContentAlignment.MiddleCenter;


            Bitmap saveImg = Properties.Resources.save;

            btn_minecraftpathsave.Image = saveImg;
            btn_minecraftpathsave.ImageAlign = ContentAlignment.MiddleCenter;

            #endregion

            #region GET LOGS VALUE AT START

            /// Get logs value, necessary for fist launch
            try
            {
                _LogsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("logs"));
            }
            catch (Exception)
            {
                _LogsState = false;
            }

            new logs.log().WriteLog(4, "");

            #endregion

            #region CHECK FOR UPDATES

            try
            {
                _EnableCheckUpdates = Convert.ToBoolean(logic.cfg.GetTypeFromFile("updater"));
            }
            catch (Exception)
            {
                _EnableCheckUpdates = false;
            }

            if (_EnableCheckUpdates)
            {
                new logs.log().WriteLog(8, "Checking for new releases");
                string updaterVersion = updater.updater.checkForUpdates(currentVersion);

                if (Convert.ToDouble(updaterVersion) > Convert.ToDouble(currentVersion))
                {
                    new logs.log().WriteLog(8, "New release found");

                    string NL = Environment.NewLine;

                    string total =
                    "There is a new release for Backcraft." + NL +
                    "Your current version is: {1}." + NL +
                    "The latest version is: {2}." + NL +
                    "Do you want to update?" + NL + NL +

                    "This might take some time!";

                    total = String.Format(total, currentVersion, updaterVersion);

                    DialogResult dialogResult = MessageBox.Show(total, "New version found", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        new logs.log().WriteLog(8, "Downloading new version.");
                        updater.updater.downloadUpdate(currentVersion, updaterVersion);

                        new logs.log().WriteLog(8, "Finished download and rename");
                        RestartApp();
                    }
                }
                else
                {
                    new logs.log().WriteLog(8, "Latest release already");
                }
            }
            else
            {
                new logs.log().WriteLog(8, "Updater not enabled");
            }

            #endregion

            #region FORM TEXT

            new logs.log().WriteLog(0, "Backcraft starts loading");

            if (Environment.Is64BitOperatingSystem)
            {
                this.Text += " - 64 bits ";
                if (File.Exists(@"config\cfg.txt"))
                {
                    new logs.log().WriteLog(0, "Detected 64 bits OS");
                    lblStatus.Text = " Settings loaded";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    new logs.log().WriteLog(0, "Settings found");
                }
                else
                {
                    lblStatus.Text = " Settings not found";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    new logs.log().WriteLog(0, "Settings not found");
                    //MessageBox.Show("Settings file not found");
                }
            }
            else
            {
                this.Text += " - 32 bits -";
                new logs.log().WriteLog(0, "Detected 32 bits OS");
            }

            #endregion

            #region FOLDER CREATION

            /// Create data folder if not created for user settings
            if (!Directory.Exists("config"))
            {
                new logs.log().WriteLog(0, "Create config folder");
                Directory.CreateDirectory("config");

            }

            /// Create backup folder if not created for backups
            if (!Directory.Exists("backups"))
            {
                // TODO: isn't it supposed to be "backup folder"?
                new logs.log().WriteLog(0, "Create config folder");
                Directory.CreateDirectory("backups");
            }

            #endregion

            #region LOAD STATES AND SET CHECKBOXES

            try
            {
                _MinecraftPath = logic.cfg.GetTypeFromFile("minecraft");
                new logs.log().WriteLog(0, "Loaded Minecraft path: " + _MinecraftPath);
            }
            catch (Exception)
            {
                _MinecraftPath = "";
                new logs.log().WriteLog(2, "Loaded Minecraft path: " + _MinecraftPath);
            }
            try
            {
                _Backcraft7ZipPath = logic.cfg.GetTypeFromFile("7zip");
                new logs.log().WriteLog(0, "Loaded 7zip path: " + _Backcraft7ZipPath);
            }
            catch (Exception)
            {

                _Backcraft7ZipPath = "";
                new logs.log().WriteLog(2, "Loaded 7zip path: " + _Backcraft7ZipPath);
            }
            try
            {
                _EnableBackcraftState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("backcraft"));
                new logs.log().WriteLog(0, "Loaded Backcraft state: " + _EnableBackcraftState);
            }
            catch (Exception)
            {
                _EnableBackcraftState = false;
                new logs.log().WriteLog(2, "Loaded Backcraft state: " + _EnableBackcraftState);
            }
            try
            {
                _ResourcePackState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("resource_packs"));
                new logs.log().WriteLog(0, "Loaded Resource pack state: " + _ResourcePackState);
            }
            catch (Exception)
            {
                _ResourcePackState = false;
                new logs.log().WriteLog(2, "Loaded Resource pack state: " + _ResourcePackState);
            }
            try
            {
                _SavesState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("worlds"));
                new logs.log().WriteLog(0, "Loaded Mineraft saves path: " + _SavesState);
            }
            catch (Exception)
            {
                _SavesState = false;
                new logs.log().WriteLog(2, "Loaded Mineraft saves path: " + _SavesState);
            }
            try
            {
                _LauncherProfilesState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("launcher_profiles"));
                new logs.log().WriteLog(0, "Loaded Launcher profiles state: " + _LauncherProfilesState);
            }
            catch (Exception)
            {
                _LauncherProfilesState = false;
                new logs.log().WriteLog(2, "Loaded Launcher profiles state: " + _LauncherProfilesState);
            }
            try
            {
                _OptionsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("options"));
                new logs.log().WriteLog(0, "Loaded Options state: " + _OptionsState);
            }
            catch (Exception)
            {
                _OptionsState = false;
                new logs.log().WriteLog(2, "Loaded Options state: " + _OptionsState);
            }
            try
            {
                _ScreenshotsState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("screenshots"));
                new logs.log().WriteLog(0, "Loaded Screenshots state: " + _ScreenshotsState);
            }
            catch (Exception)
            {
                _ScreenshotsState = false;
                new logs.log().WriteLog(2, "Loaded Screenshots state: " + _ScreenshotsState);
            }
            try
            {
                _StartupState = Convert.ToBoolean(logic.cfg.GetTypeFromFile("startup"));
                new logs.log().WriteLog(0, "Loaded Startup state: " + _StartupState);
            }
            catch (Exception)
            {
                _StartupState = false;
                new logs.log().WriteLog(2, "Loaded Startup state: " + _StartupState);
            }
            try
            {
                _IntervalTime = Convert.ToInt32(logic.cfg.GetTypeFromFile("interval"));
                new logs.log().WriteLog(0, "Loaded Interval value: " + _IntervalTime);
            }
            catch (Exception)
            {
                _IntervalTime = 5;
                new logs.log().WriteLog(2, "Loaded Interval value: " + _IntervalTime);
            }
            try
            {
                _EnableCheckUpdates = Convert.ToBoolean(logic.cfg.GetTypeFromFile("updater"));
                new logs.log().WriteLog(0, "Loaded Updater state: " + _EnableCheckUpdates);
            }
            catch (Exception)
            {
                _EnableCheckUpdates = false;
                new logs.log().WriteLog(2, "Loaded Updater state: " + _EnableCheckUpdates);
            }

            /// Assign values to checkboxes
            back_enable.Checked = _EnableBackcraftState;
            set_resource.Checked = _ResourcePackState;
            set_saves.Checked = _SavesState;
            set_launcher.Checked = _LauncherProfilesState;
            set_options.Checked = _OptionsState;
            set_screenshots.Checked = _ScreenshotsState;
            back_enablelog.Checked = _LogsState;
            back_startup.Checked = _StartupState;
            back_checkupdate.Checked = _EnableCheckUpdates;
            textbox_7zip.Text = _Backcraft7ZipPath;

            /// Assign values to array
            states[0] = _ResourcePackState;
            states[1] = _SavesState;
            states[2] = _LauncherProfilesState;
            states[3] = _OptionsState;
            states[4] = _ScreenshotsState;
            states[5] = _LogsState;

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

            #region LOAD SCROLL AND TEXTBOX

            scroll_interval.Value = _IntervalTime;
            back_intervaltextbox.Text = _IntervalTime.ToString();

            #endregion

            #region ICON TRAY ON LOAD

            notifyIcon1.BalloonTipTitle = "Backcraft minimized!";
            notifyIcon1.BalloonTipText = "Backcraft will be running in the background.";

            if (_EnableBackcraftState)
            {
                new logs.log().WriteLog(0, "Backcraft enabled");
                try
                {
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                    ShowIcon = true;
                    notifyIcon1.Visible = true;
                    notifyIcon1.Text = "Backcraft";
                    notifyIcon1.ShowBalloonTip(50);

                    new logs.log().WriteLog(0, "Backcraft started minimized");
                }
                catch (Exception)
                {
                    ShowInTaskbar = true;
                    ShowIcon = false;
                    new logs.log().WriteLog(0, "Backcraft started maximized");
                }
            }
            else
            {
                new logs.log().WriteLog(0, "Backcraft disabled");
                new logs.log().WriteLog(0, "Backcraft started maximized");
            }

            #endregion
        }

        #region FORM LOAD

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: might override loaded settings (?)
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\";

            if (_MinecraftPath.ToString() == "" && Directory.Exists(folderpath))
            {
                textBox1.Text = folderpath;
                label_text.Text += " (NOT SAVED)";
            }
            else
            {
                textBox1.Text = _MinecraftPath.ToString();
            }

            _MinecraftPath = textBox1.Text;

            int interval = _IntervalTime;

            CancellationToken cancel = new CancellationToken();
            cancel = token.Token;

            if (!_EnableBackcraftState)
            {
                token.Cancel();
            }

            var x = AsyncBackcraft(interval);
            new logs.log().WriteLog(0, "Backcraft finished loading");
        }

        #endregion

        #region ICON TRAY SETTINGS

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            ShowIcon = false;
            notifyIcon1.Visible = false;
        }

        private void makeBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new logs.log().WriteLog(0, "Manual backup from tray icon");
                new logs.log().WriteLog(6, "");
                logic.backup.MakeBackup(states);
                new logs.log().WriteLog(7, "");
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Manual backup from tray icon");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new logs.log().WriteLog(5, "");
            Close();
        }

        #endregion

        #region GRIDVIEWS

        #region MINECRAFR PATH

        private void btn_minecraftpathsave_Click(object sender, EventArgs e)
        {
            new logic.cfg("minecraft", textbox_minecraftpath.Text.ToString()).WriteCFG();
            _MinecraftPath = textbox_minecraftpath.Text;
        }

        private void btn_minecraftfoldersearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_minecraftpath.Text = fbd.SelectedPath;
            }
        }

        #endregion

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

        #endregion

        #region MINECRAFT SETTINGS

        #region ACTIVATING CHECKBOXES

        // TODO: error messages when an invalid Minecraft folder path is provided

        private void set_launcher_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region BUTTONS

        private void btn_minecraftfolder_Click(object sender, EventArgs e)
        {
            label_text.Text = "Minecraft's folder path";

            doStyleResizeForSettings(60, 0);

            btn_minecraftpathsave.Visible = true;

            textbox_minecraftpath.Visible = true;
            btn_minecraftfoldersearch.Visible = true;
            btn_minecraftpathsave.Visible = true;
            gridview_resourcepacks.Visible = false;
            gridview_worlds.Visible = false;
        }

        private void btn_resourcepacks_Click(object sender, EventArgs e)
        {

        }

        private void btn_saves_Click(object sender, EventArgs e)
        {
            try
            {
                label_text.Text = "Select the worlds to save";

                doStyleResizeForSettings(40 + gridview_worlds.Height, 0);

                btn_minecraftpathsave.Visible = false;

                textbox_minecraftpath.Visible = false;
                btn_minecraftfoldersearch.Visible = false;
                btn_minecraftpathsave.Visible = false;
                gridview_resourcepacks.Visible = false;
                gridview_worlds.Visible = true;

            }
            catch (Exception)
            {

            }
        }

        private void btn_search_7zip_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_7zip.Text = fbd.SelectedPath;
            }
        }

        #endregion

        #region SCROLL

        private void scroll_interval_Scroll(object sender, EventArgs e)
        {
            back_intervaltextbox.Text = scroll_interval.Value.ToString();
        }

        #endregion

        #region STYLING

        private void doStyleResizeForSettings(int newLoc, int i)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            doStyleResizeForSettings(0, 0);
        }

        private void btn_settings_close_Click(object sender, EventArgs e)
        {
            doStyleResizeForSettings(0, 1);
        }

        #endregion

        #region LOGIC

        public async Task AsyncBackcraft(int interval)
        {
            while (!token.IsCancellationRequested)
            {
                if (CheckIfMinecraftIsRunning())
                {
                    new logs.log().WriteLog(0, "Minecraft is running, proceed to backup.");
                    await Backcraft();
                    try
                    {
                        await Task.Delay(TimeSpan.FromMinutes(interval), token.Token);
                        new logs.log().WriteLog(0, "Finished backup, next backup will be in: " + interval);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
                else
                {
                    new logs.log().WriteLog(1, "Minecraft is not running, waiting 5 minutes.");
                    await Task.Delay(TimeSpan.FromMinutes(5), token.Token);
                }

            }
        }

        private async Task Backcraft()
        {
            try
            {
                new logs.log().WriteLog(6, "");
                logic.backup.MakeBackup(states);
                new logs.log().WriteLog(7, "");
            }
            catch (Exception)
            {
            }
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
                new logs.log().WriteLog(0, "Restarting Backcraft..");
                Process.Start(Application.StartupPath + "\\backcraft.exe");
                Process.GetCurrentProcess().Kill();
            }
            catch
            {
                new logs.log().WriteLog(3, "Restarting Backcraft..");
            }
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

                try
                {
                    new logic.cfg("backcraft", back_enable.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved Backcraft state: " + back_enable.Checked.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved Backcraft state: " + back_enable.Checked.ToString());
                }

                #endregion

                #region RESOURCE PACKS STATE

                try
                {
                    new logic.cfg("resource_packs", set_resource.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved resource packs state: " + set_resource.Checked.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved resource packs state: " + set_resource.Checked.ToString());
                }

                foreach (DataGridViewRow r in gridview_resourcepacks.Rows)
                {
                    string name = r.Cells[0].Value.ToString();
                    string path = r.Cells[1].Value.ToString();
                    string check = r.Cells[2].Value.ToString();

                    if (Convert.ToBoolean(check))
                    {
                        new logic.files(name, path, "d").WriteCFG();
                    }
                    else
                    {
                        try
                        {
                            new logic.files().DeleteFromFile(name, path);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }

                #endregion

                #region LAUNCHER PROFILES STATE


                try
                {
                    new logic.cfg("launcher_profiles", set_launcher.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved launcher profiles state: " + set_launcher.Checked.ToString());
                    try
                    {
                        if (set_launcher.Checked)
                        {
                            new logic.files("launcher_profiles", _MinecraftPath + @"\launcher_profiles.json", "f").WriteCFG();
                        }
                        else
                        {
                            new logic.files().DeleteFromFile("launcher_profiles", _MinecraftPath + @"\launcher_profiles.json");
                            new logs.log().WriteLog(0, "Deleted launcher profiles state: " + set_launcher.Checked.ToString());

                        }
                    }
                    catch (Exception exc)
                    {
                        string a = exc.Message;
                    }
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved launcher profiles state: " + set_launcher.Checked.ToString());
                }


                #endregion

                #region OPTIONS STATE

                try
                {
                    new logic.cfg("options", set_options.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved options state: " + set_options.Checked.ToString());
                    try
                    {
                        if (set_options.Checked)
                        {
                            new logic.files("options", _MinecraftPath + @"\options.txt", "f").WriteCFG();
                        }
                        else
                        {
                            new logic.files().DeleteFromFile("options", _MinecraftPath + @"\options.txt");
                            new logs.log().WriteLog(0, "Deleted options state: " + set_options.Checked.ToString());
                        }


                    }
                    catch (Exception)
                    {
                    }
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved options state: " + set_options.Checked.ToString());
                }

                #endregion

                #region SCREENSHOTS STATE

                try
                {
                    new logic.cfg("screenshots", set_screenshots.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved screenshots state: " + set_screenshots.Checked.ToString());
                    try
                    {
                        if (set_screenshots.Checked)
                        {
                            new logic.files("screenshots", _MinecraftPath + @"\screenshots", "d").WriteCFG();
                        }
                        else
                        {
                            new logic.files().DeleteFromFile("screenshots", _MinecraftPath + @"\screenshots");
                            new logs.log().WriteLog(0, "Delete screenshots state: " + set_screenshots.Checked.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        new logic.cfg("screenshots", false.ToString()).WriteCFG();
                    }
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved screenshots state: " + set_screenshots.Checked.ToString());
                }


                #endregion

                #region LOGS STATE

                try
                {
                    new logic.cfg("logs", back_enablelog.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved Logs state: " + back_enablelog.Checked.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved Logs state: " + back_enablelog.Checked.ToString());
                }

                #endregion

                #region CHECK UPDATES

                try
                {
                    new logic.cfg("updater", back_checkupdate.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved Check updates state: " + back_checkupdate.Checked.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved Check state: " + back_enablelog.Checked.ToString());
                }

                #endregion

                #region STARTUP STATE


                try
                {
                    new logic.cfg("startup", back_enablelog.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved startup state: " + back_startup.Checked.ToString());

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
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved startup state: " + back_startup.Checked.ToString());
                }


                #endregion

                #region INTERVAL STATE

                try
                {
                    new logic.cfg("interval", scroll_interval.Value.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved interval value: " + scroll_interval.Value.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved interval value: " + scroll_interval.Value.ToString());
                }

                #endregion

                #region 7ZIP

                try
                {
                    new logic.cfg("7zip", textbox_7zip.Text.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved 7zip path: " + textbox_7zip.Text.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved 7zip path: " + textbox_7zip.Text.ToString());
                }

                #endregion

                new logs.log().WriteLog(0, "All files saved, restarting Backcraft..");

                RestartApp();
            }
            catch (Exception err)
            {
                string a = err.ToString();
                /// Change text value for btn
                back_save.Text = "Error!";
                new logs.log().WriteLog(3, "Error in saving");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /// BACKUP NOW BUTTON
            try
            {
                new logs.log().WriteLog(0, "Manual backup");
                //var a = Backcraft();
                logic.backup.MakeBackup(states);
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Manual backup");
            }
        }

        private void btn_deletesettings_Click(object sender, EventArgs e)
        {
            try
            {
                new logs.log().WriteLog(0, "Delete config");
                Directory.Delete(@"config", true);
            }
            catch (Exception)
            {
                new logs.log().WriteLog(2, "Delete config");
            }

            try
            {
                new logs.log().WriteLog(0, "Restarting Backcraft");
                RestartApp();
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Restarting Backcraft");
            }
        }

        #endregion

        #region BUTTON LABELS

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// Link to github repo

        }

        #endregion

        #region CLOSING

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            new logs.log().WriteLog(5, "");
        }

        #endregion

        #region FOOTER AND TOP

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/backcraft");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/emimontesdeocaa");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/Backcraft/issues/new");

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            new info().ShowDialog();
        }

        #endregion

        #endregion

        #endregion

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/emimontesdeocaa");
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/backcraft");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new logic.cfg("minecraft", textbox_minecraftpath.Text.ToString()).WriteCFG();
            _MinecraftPath = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // TODO: repetitive, put in a separate method
            if (Directory.Exists(textBox1.Text))
            {
                new ResPacksForm().Show();
            }
            else
            {
                MessageBox.Show
                    ("The Minecraft folder you specified (\"" + textBox1.Text + "\") does not exist.",
                     "Backcraft - invalid Minecraft folder",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }

            try
            {
                label_text.Text = "Select the resource packs to save";

                doStyleResizeForSettings(40 + gridview_resourcepacks.Height, 0);

                btn_minecraftpathsave.Visible = false;

                textbox_minecraftpath.Visible = false;
                btn_minecraftfoldersearch.Visible = false;
                btn_minecraftpathsave.Visible = false;
                gridview_resourcepacks.Visible = true;
                gridview_worlds.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void b_panel_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new BackupPathsForm().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                new BackupSavesForm().Show();
            }
            else
            {
                MessageBox.Show
                    ("The Minecraft folder you specified (\"" + textBox1.Text + "\") does not exist.",
                     "Backcraft - invalid Minecraft folder",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
        }

    }     
}

//TODO: I don't know where's the beginning
#endregion