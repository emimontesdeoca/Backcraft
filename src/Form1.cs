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
        public int _IntervalTime { get; set; } = 5;
        /// <summary>
        /// Array of states
        /// </summary>
        public static bool[] states = new bool[6];
        /// <summary>
        /// App version
        /// </summary>
        public static string currentVersion = "3.3";

        #endregion

        public Form1()
        {
            InitializeComponent();

            #region INITIAL RESIZE AND STYLING

            doStyleResizeForSettings(0, 0);
            doStyleResizeForSettings(0, 1);

            MaximizeBox = false;
            label_version.Text = "v" + currentVersion;

            this.Icon = backcraft.Properties.Resources.icon;

            #endregion

            #region IMAGES

            object o = Properties.Resources.ResourceManager.GetObject("settings");
            btn_minecraftfolder.Image = (Image)o;
            btn_minecraftfolder.ImageAlign = ContentAlignment.MiddleCenter;

            btn_resourcepacks.Image = (Image)o;
            btn_resourcepacks.ImageAlign = ContentAlignment.MiddleCenter;

            btn_saves.Image = (Image)o;
            btn_saves.ImageAlign = ContentAlignment.MiddleCenter;

            button3.Image = (Image)o;
            button3.ImageAlign = ContentAlignment.MiddleCenter;

            button5.Image = (Image)o;
            button5.ImageAlign = ContentAlignment.MiddleCenter;

            object report = Properties.Resources.ResourceManager.GetObject("bug");
            btn_report.Image = (Image)report;
            btn_report.ImageAlign = ContentAlignment.MiddleCenter;

            object info = Properties.Resources.ResourceManager.GetObject("info");
            btn_info.Image = (Image)info;
            btn_info.ImageAlign = ContentAlignment.MiddleCenter;

            object close = Properties.Resources.ResourceManager.GetObject("close");
            btn_close.Image = (Image)close;
            btn_close.ImageAlign = ContentAlignment.MiddleCenter;

            btn_settings_close.Image = (Image)close;
            btn_settings_close.ImageAlign = ContentAlignment.MiddleCenter;

            object folder = Properties.Resources.ResourceManager.GetObject("folder");
            btn_minecraftfoldersearch.Image = (Image)folder;
            btn_minecraftfoldersearch.ImageAlign = ContentAlignment.MiddleCenter;

            btn_search_7zip.Image = (Image)folder;
            btn_search_7zip.ImageAlign = ContentAlignment.MiddleCenter;

            btn_search_path.Image = (Image)folder;
            btn_search_path.ImageAlign = ContentAlignment.MiddleCenter;

            object save = Properties.Resources.ResourceManager.GetObject("save");
            btn_minecraftpathsave.Image = (Image)save;
            btn_minecraftpathsave.ImageAlign = ContentAlignment.MiddleCenter;
            btn_add_path.Image = (Image)save;
            btn_add_path.ImageAlign = ContentAlignment.MiddleCenter;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

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

                    string t1 = "There is a new release for Backcraft.";
                    string t2 = "Your current version is: " + currentVersion + ".";
                    string t3 = "The latest version is: " + updaterVersion + ".";
                    string t4 = "Do you want to update?";

                    string t5 = "This might take some time!";

                    string total = t1 + Environment.NewLine + Environment.NewLine + t2
                        + Environment.NewLine + t3 + Environment.NewLine + Environment.NewLine
                        + t4 + Environment.NewLine + Environment.NewLine + t5;

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
                    label_settings.Text = " Settings loaded";
                    label_settings.ForeColor = System.Drawing.Color.Green;
                    new logs.log().WriteLog(0, "Settings found");
                }
                else
                {
                    label_settings.Text = " Settings not found";
                    label_settings.ForeColor = System.Drawing.Color.Red;
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
                new logs.log().WriteLog(0, "Create config folder");
                Directory.CreateDirectory("backups");
            }

            #endregion

            #region LOAD STATES AND SET CHECKBOXES

            try
            {
                _MinecraftPath = logic.cfg.GetTypeFromFile("minecraft");
                new logs.log().WriteLog(0, "Loaded Mineraft path: " + _MinecraftPath);
            }
            catch (Exception)
            {
                _MinecraftPath = "";
                new logs.log().WriteLog(2, "Loaded Mineraft path: " + _MinecraftPath);
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
            if (back_checkupdate.Checked)
            {
                label_updater.Enabled = true;
                label_updater2.Enabled = true;
            }
            else
            {
                label_updater.Enabled = false;
                label_updater2.Enabled = false;
            }
            #endregion

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
            loadGridviewRPStructure();
            loadGridviewWStructure();
            loadGridviewBStructure();

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

        #region LOAD GRIDVIEW ITEMS

        private void loadGridviewRPStructure()
        {
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "Name";
            col1.Name = "name";
            col1.ReadOnly = true;

            col2.HeaderText = "Path";
            col2.Name = "path";
            col2.ReadOnly = true;

            col3.HeaderText = "Backup";
            col3.Name = "backup";

            gridview_worlds.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3 });
            gridview_worlds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_worlds.AllowUserToAddRows = false;
            gridview_worlds.RowHeadersVisible = false;
            gridview_worlds.AllowUserToResizeRows = false;

            col3.Width = 50;
            col1.Width = 100;
        }

        private void loadGridviewWStructure()
        {
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "Name";
            col1.Name = "name";
            col1.ReadOnly = true;

            col2.HeaderText = "Path";
            col2.Name = "path";
            col2.ReadOnly = true;

            col3.HeaderText = "Backup";
            col3.Name = "backup";

            gridview_resourcepacks.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3 });
            gridview_resourcepacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_resourcepacks.AllowUserToAddRows = false;
            gridview_resourcepacks.AllowUserToResizeRows = false;

            gridview_resourcepacks.RowHeadersVisible = false;
            col3.Width = 30;
        }

        private void loadGridviewBStructure()
        {
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewButtonColumn();

            col1.HeaderText = "Path";
            col1.Name = "path";
            col1.ReadOnly = true;

            col2.HeaderText = "Delete";
            col2.Name = "delete";

            gridview_backups.Columns.AddRange(new DataGridViewColumn[] { col1, col2 });
            gridview_backups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_backups.AllowUserToAddRows = false;
            gridview_backups.AllowUserToResizeRows = false;

            gridview_backups.RowHeadersVisible = false;
            col2.Width = 50;
        }

        private void loadGridviewResourcePacks()
        {
            gridview_resourcepacks.Enabled = false;

            gridview_resourcepacks.Rows.Clear();
            try
            {
                List<string> d = Directory.GetDirectories(_MinecraftPath + @"\resourcepacks").ToList();

                try
                {
                    List<logic.files> files = logic.files.GetFiles();

                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;
                        try
                        {
                            if (files.Single(x => x.name == name && x.path == path) != null)
                            {
                                check = true;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        gridview_resourcepacks.Rows.Add(name, path, check);
                    }
                }
                catch (Exception)
                {
                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;

                        gridview_resourcepacks.Rows.Add(name, path, check);
                    }
                }


                int gridview_rp_height = gridview_resourcepacks.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                gridview_resourcepacks.Enabled = true;
                gridview_resourcepacks.Height = gridview_rp_height + 47;

                gridview_resourcepacks.Enabled = true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void loadGridviewWorlds()
        {
            gridview_worlds.Enabled = false;

            gridview_worlds.Rows.Clear();

            try
            {
                List<string> d = Directory.GetDirectories(_MinecraftPath + @"\saves").ToList();

                try
                {
                    List<logic.files> files = logic.files.GetFiles();
                    if (files.Count != 0)
                    {
                        foreach (string dir in d)
                        {
                            string name = dir.Split('\\').Last();
                            string path = dir;
                            bool check = false;
                            try
                            {
                                if (files.Single(x => x.name == name && x.path == path) != null)
                                {
                                    check = true;
                                }
                            }
                            catch (Exception)
                            {
                            }
                            gridview_worlds.Rows.Add(name, path, check);
                        }
                    }
                    else
                    {

                        foreach (string dir in d)
                        {
                            string name = dir.Split('\\').Last();
                            string path = dir;
                            bool check = false;
                            gridview_worlds.Rows.Add(name, path, check);
                        }
                    }
                }
                catch (Exception)
                {
                }

                int gridview_worlds_height = gridview_worlds.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                gridview_worlds.Enabled = true;
                gridview_worlds.Height = gridview_worlds_height + 47;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void loadGridviewBackups()
        {
            gridview_backups.Rows.Clear();

            try
            {
                List<string> l = logic.paths.GetPaths();

                foreach (string s in l)
                {
                    gridview_backups.Rows.Add(s, "Delete");
                }
            }
            catch (Exception)
            {
            }

            int gridview_backups_height = gridview_backups.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            gridview_backups.Enabled = true;
            gridview_backups.Height = gridview_backups_height + 47;
        }

        #endregion

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

            doStyleResizeForSettings(65, 1);

            string pathfromsettings = logic.cfg.GetPathFromFile("7zip");

            label_path.Text = "Folder to 7zip";

            string sevenzip32bits = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\7-Zip";
            string sevenzip64bits = @"C:\Program Files\7-Zip";

            if (pathfromsettings == "")
            {
                if (Directory.Exists(sevenzip32bits))
                {
                    textbox_7zip.Text = sevenzip32bits;
                }
                else
                {
                    textbox_7zip.Text = sevenzip64bits;
                }
                label_path.Text += " (NOT SAVED)";
            }
            else
            {
                textbox_7zip.Text = logic.cfg.GetPathFromFile("7zip");
            }

            textbox_7zip.Visible = true;
            btn_search_7zip.Visible = true;
            label_path.Text = "Folder to 7zip";
            textbox_7zip.Enabled = true;
            btn_search_7zip.Enabled = true;

            textbox_path.Visible = false;
            btn_search_path.Visible = false;
            btn_add_path.Visible = false;
            gridview_backups.Visible = false;
            btn_search_path.Enabled = false;
            btn_add_path.Enabled = false;
            gridview_backups.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadGridviewBackups();

            doStyleResizeForSettings(75 + gridview_backups.Height, 1);


            textbox_path.Text = "";

            textbox_7zip.Visible = false;
            btn_search_7zip.Visible = false;
            label_path.Text = "Backup destinations";
            textbox_7zip.Enabled = false;
            btn_search_7zip.Enabled = false;

            textbox_path.Visible = true;
            btn_search_path.Visible = true;
            btn_add_path.Visible = true;
            gridview_backups.Visible = true;
            btn_search_path.Enabled = true;
            btn_add_path.Enabled = true;
            gridview_backups.Enabled = true;
        }

        #endregion

        #endregion

        #endregion

        #region MINECRAFT SETTINGS

        #region ACTIVATING CHECKBOXES

        private void set_resource_Click(object sender, EventArgs e)
        {
            if (set_resource.Checked && _MinecraftPath != "")
            {
                label_checkboxresources.Enabled = true;
                label_resource.Enabled = true;
                btn_resourcepacks.Enabled = true;
            }
            else
            {
                if (_MinecraftPath == "")
                {
                    MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                    label_resource.Enabled = false;
                    label_checkboxresources.Enabled = false;
                    btn_resourcepacks.Enabled = false;
                    set_resource.Checked = false;
                }
                else
                {
                    label_resource.Enabled = true;
                    label_checkboxresources.Enabled = true;
                    btn_resourcepacks.Enabled = true;
                }
            }
        }

        private void set_saves_Click(object sender, EventArgs e)
        {
            if (set_saves.Checked && _MinecraftPath != "")
            {
                label_checkboxsaves.Enabled = true;
                label_saves.Enabled = true;
                btn_saves.Enabled = true;
            }
            else
            {
                if (_MinecraftPath == "")
                {
                    MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                    label_checkboxsaves.Enabled = false;
                    label_saves.Enabled = false;
                    set_saves.Checked = false;
                    btn_saves.Enabled = false;
                }
                else
                {
                    label_checkboxsaves.Enabled = true;
                    label_saves.Enabled = true;
                    btn_saves.Enabled = true;
                }
            }
        }

        private void set_screenshots_Click(object sender, EventArgs e)
        {

            if (set_screenshots.Checked && _MinecraftPath != "")
            {
                label_checkboxscreenshots.Enabled = true;
                label_screenshots.Enabled = true;
            }
            else
            {

                if (_MinecraftPath == "")
                {
                    MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                    set_screenshots.Checked = false;
                    label_screenshots.Enabled = false;
                    label_checkboxscreenshots.Enabled = false;
                }
                else
                {
                    label_checkboxscreenshots.Enabled = false;
                    label_screenshots.Enabled = false;
                }
            }
        }

        private void set_options_Click(object sender, EventArgs e)
        {
            if (set_options.Checked && _MinecraftPath != "")
            {
                label_checkboxoptions.Enabled = true;
                label_options.Enabled = true;
            }
            else
            {

                if (_MinecraftPath == "")
                {
                    MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                    set_options.Checked = false;
                    label_options.Enabled = false;
                    label_checkboxoptions.Enabled = false;
                }
                else
                {
                    label_checkboxoptions.Enabled = false;
                    label_options.Enabled = false;
                }
            }
        }

        private void set_launcher_Click(object sender, EventArgs e)
        {
            if (set_launcher.Checked && _MinecraftPath != "")
            {
                label_checkboxlauncher.Enabled = true;
                label_launcher.Enabled = true;
            }
            else
            {
                if (_MinecraftPath == "")
                {
                    MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                    set_launcher.Checked = false;
                    label_launcher.Enabled = false;
                    label_checkboxlauncher.Enabled = false;
                }
                else
                {
                    label_checkboxlauncher.Enabled = false;
                    label_launcher.Enabled = false;
                }
            }
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

            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\";

            if (_MinecraftPath.ToString() == "" && Directory.Exists(folderpath))
            {
                textbox_minecraftpath.Text = folderpath;
                label_text.Text += " (NOT SAVED)";
            }
            else
            {
                textbox_minecraftpath.Text = _MinecraftPath.ToString();
            }

        }

        private void btn_resourcepacks_Click(object sender, EventArgs e)
        {
            try
            {
                loadGridviewResourcePacks();

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
                MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                set_resource.Checked = false;
                label_resource.Enabled = false;
                label_checkboxresources.Enabled = false;
            }
        }

        private void btn_saves_Click(object sender, EventArgs e)
        {
            try
            {
                loadGridviewWorlds();

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
                MessageBox.Show("Error getting the folders from the path!" + Environment.NewLine + Environment.NewLine + "The Minecraft folder configured is: " + _MinecraftPath + Environment.NewLine + Environment.NewLine + "Check that the Minecraft path is correct or if there are files inside the folder!", "Backcraft - Path error");
                set_saves.Checked = false;
                label_checkboxsaves.Enabled = false;
                label_saves.Enabled = false;
            }
        }

        private void gridview_backups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridview_backups.Columns[e.ColumnIndex].Name == "delete")
            {
                try
                {
                    new logic.paths().DeleteFromFile(gridview_backups.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gridview_backups.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btn_search_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_add_path_Click(object sender, EventArgs e)
        {
            if (textbox_path.Text != string.Empty)
            {   // Add path if exists.
                if (Directory.Exists(textbox_path.Text))
                {
                    gridview_backups.Rows.Add(textbox_path.Text.ToString(), "Delete");
                }
                else
                {
                    MessageBox.Show("Path does not exist!", "Error");
                }
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

        private void back_checkupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (back_checkupdate.Checked)
            {
                label_updater.Enabled = true;
                label_updater2.Enabled = true;
            }
            else
            {
                label_updater.Enabled = false;
                label_updater2.Enabled = false;
            }
        }

        #endregion

        #region SCROLL

        private void scroll_interval_Scroll(object sender, EventArgs e)
        {
            back_intervaltextbox.Text = scroll_interval.Value.ToString();
        }

        #endregion

        #endregion

        #region STYLING

        private void doStyleResizeForSettings(int newLoc, int i)
        {
            switch (i)
            {
                case 0:
                    m_panel.Height = 170 + newLoc;
                    break;
                case 1:
                    b_panel.Height = 220 + newLoc;
                    break;
            }
            //b_panel.Height = 220 + newLoc;

            this.Height = 100 + m_panel.Height + 15 + b_panel.Height + 35;

            b_panel.Location = new Point(b_panel.Location.X, m_panel.Location.Y + m_panel.Height + 5);

            ///btns
            back_save.Location = new Point(back_save.Location.X, b_panel.Location.Y + b_panel.Height + 5);
            button1.Location = new Point(button1.Location.X, b_panel.Location.Y + b_panel.Height + 5);
            btn_deletesettings.Location = new Point(btn_deletesettings.Location.X, b_panel.Location.Y + b_panel.Height + 5);

            ///footer
            label4.Location = new Point(label4.Location.X, btn_deletesettings.Location.Y + btn_deletesettings.Height + 5);
            label5.Location = new Point(label5.Location.X, btn_deletesettings.Location.Y + btn_deletesettings.Height + 5);
            label6.Location = new Point(label6.Location.X, btn_deletesettings.Location.Y + btn_deletesettings.Height + 5);
            label10.Location = new Point(label10.Location.X, label4.Location.Y + label4.Height + 3);
            label_settings.Location = new Point(label_settings.Location.X, label4.Location.Y + label4.Height + 3);
            pictureBox1.Location = new Point(pictureBox1.Location.X, label4.Location.Y + label4.Height + 1);
            pictureBox2.Location = new Point(pictureBox2.Location.X, label4.Location.Y + label4.Height + 1);

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

                #region WORLDS/SAVES STATE

                try
                {
                    new logic.cfg("worlds", set_saves.Checked.ToString()).WriteCFG();
                    new logs.log().WriteLog(0, "Saved worlds state: " + set_saves.Checked.ToString());
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Saved worlds state: " + set_saves.Checked.ToString());
                }

                foreach (DataGridViewRow r in gridview_worlds.Rows)
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

                #region BACKUPS

                try
                {
                    foreach (DataGridViewRow r in gridview_backups.Rows)
                    {
                        try
                        {
                            new logic.paths(r.Cells[0].Value.ToString()).WriteCFg();
                            new logs.log().WriteLog(0, "Saved destination path: " + r.Cells[0].Value.ToString());
                        }
                        catch (Exception)
                        {
                            new logs.log().WriteLog(2, "Saved destination path: " + r.Cells[0].Value.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(2, "Destination path save");
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

    }
}
