namespace backcraft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.b_panel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch7zipPath = new System.Windows.Forms.Button();
            this.btnSave7ZipPath = new System.Windows.Forms.Button();
            this.textbox_7zip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.back_checkupdate = new System.Windows.Forms.CheckBox();
            this.back_intervaltextbox = new System.Windows.Forms.TextBox();
            this.scroll_interval = new System.Windows.Forms.TrackBar();
            this.back_startup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_enablelog = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.back_enable = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.back_save = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_deletesettings = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.set_launcher = new System.Windows.Forms.CheckBox();
            this.set_screenshots = new System.Windows.Forms.CheckBox();
            this.set_options = new System.Windows.Forms.CheckBox();
            this.set_resource = new System.Windows.Forms.CheckBox();
            this.set_saves = new System.Windows.Forms.CheckBox();
            this.btn_minecraftpathsave = new System.Windows.Forms.Button();
            this.btn_minecraftfoldersearch = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_minecraftpath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.gridview_resourcepacks = new System.Windows.Forms.DataGridView();
            this.gridview_worlds = new System.Windows.Forms.DataGridView();
            this.m_panel = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchMCPath = new System.Windows.Forms.Button();
            this.btnSaveMCPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridview_backups = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripEmiliano = new System.Windows.Forms.ToolStripStatusLabel();
            this.separator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.separator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.b_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_resourcepacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_worlds)).BeginInit();
            this.m_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_backups)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(206, 19);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(153, 38);
            this.label.TabIndex = 0;
            this.label.Text = "Backcraft";
            // 
            // b_panel
            // 
            this.b_panel.Controls.Add(this.label5);
            this.b_panel.Controls.Add(this.btnSearch7zipPath);
            this.b_panel.Controls.Add(this.btnSave7ZipPath);
            this.b_panel.Controls.Add(this.textbox_7zip);
            this.b_panel.Controls.Add(this.label11);
            this.b_panel.Controls.Add(this.back_checkupdate);
            this.b_panel.Controls.Add(this.back_intervaltextbox);
            this.b_panel.Controls.Add(this.scroll_interval);
            this.b_panel.Controls.Add(this.back_startup);
            this.b_panel.Controls.Add(this.label2);
            this.b_panel.Controls.Add(this.label1);
            this.b_panel.Controls.Add(this.back_enablelog);
            this.b_panel.Controls.Add(this.label8);
            this.b_panel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_panel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_panel.Location = new System.Drawing.Point(13, 293);
            this.b_panel.Margin = new System.Windows.Forms.Padding(4);
            this.b_panel.Name = "b_panel";
            this.b_panel.Padding = new System.Windows.Forms.Padding(4);
            this.b_panel.Size = new System.Drawing.Size(527, 321);
            this.b_panel.TabIndex = 12;
            this.b_panel.TabStop = false;
            this.b_panel.Text = "Backcraft settings";
            this.b_panel.Enter += new System.EventHandler(this.b_panel_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = global::backcraft.Properties.Resources.settings;
            this.label5.Location = new System.Drawing.Point(415, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = " ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSearch7zipPath
            // 
            this.btnSearch7zipPath.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch7zipPath.Image = global::backcraft.Properties.Resources.folder;
            this.btnSearch7zipPath.Location = new System.Drawing.Point(421, 138);
            this.btnSearch7zipPath.Name = "btnSearch7zipPath";
            this.btnSearch7zipPath.Size = new System.Drawing.Size(33, 31);
            this.btnSearch7zipPath.TabIndex = 49;
            this.btnSearch7zipPath.UseVisualStyleBackColor = true;
            // 
            // btnSave7ZipPath
            // 
            this.btnSave7ZipPath.Image = global::backcraft.Properties.Resources.save;
            this.btnSave7ZipPath.Location = new System.Drawing.Point(459, 138);
            this.btnSave7ZipPath.Name = "btnSave7ZipPath";
            this.btnSave7ZipPath.Size = new System.Drawing.Size(35, 31);
            this.btnSave7ZipPath.TabIndex = 48;
            this.btnSave7ZipPath.UseVisualStyleBackColor = true;
            // 
            // textbox_7zip
            // 
            this.textbox_7zip.ForeColor = System.Drawing.Color.DarkGray;
            this.textbox_7zip.Location = new System.Drawing.Point(11, 140);
            this.textbox_7zip.Name = "textbox_7zip";
            this.textbox_7zip.Size = new System.Drawing.Size(405, 27);
            this.textbox_7zip.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(-20, 366);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(492, 1);
            this.label11.TabIndex = 46;
            this.label11.Text = "label11";
            // 
            // back_checkupdate
            // 
            this.back_checkupdate.AutoSize = true;
            this.back_checkupdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_checkupdate.ForeColor = System.Drawing.Color.DarkGray;
            this.back_checkupdate.Location = new System.Drawing.Point(10, 42);
            this.back_checkupdate.Margin = new System.Windows.Forms.Padding(4);
            this.back_checkupdate.Name = "back_checkupdate";
            this.back_checkupdate.Size = new System.Drawing.Size(242, 23);
            this.back_checkupdate.TabIndex = 34;
            this.back_checkupdate.Text = "Check for updates on startup";
            this.toolTip1.SetToolTip(this.back_checkupdate, "Check to enable updates at the program launch");
            this.back_checkupdate.UseVisualStyleBackColor = true;
            // 
            // back_intervaltextbox
            // 
            this.back_intervaltextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back_intervaltextbox.Enabled = false;
            this.back_intervaltextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_intervaltextbox.Location = new System.Drawing.Point(454, 231);
            this.back_intervaltextbox.Margin = new System.Windows.Forms.Padding(4);
            this.back_intervaltextbox.Name = "back_intervaltextbox";
            this.back_intervaltextbox.Size = new System.Drawing.Size(36, 27);
            this.back_intervaltextbox.TabIndex = 33;
            // 
            // scroll_interval
            // 
            this.scroll_interval.Location = new System.Drawing.Point(8, 220);
            this.scroll_interval.Margin = new System.Windows.Forms.Padding(4);
            this.scroll_interval.Maximum = 60;
            this.scroll_interval.Minimum = 5;
            this.scroll_interval.Name = "scroll_interval";
            this.scroll_interval.Size = new System.Drawing.Size(438, 56);
            this.scroll_interval.SmallChange = 5;
            this.scroll_interval.TabIndex = 20;
            this.scroll_interval.TickFrequency = 5;
            this.scroll_interval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTip1.SetToolTip(this.scroll_interval, "Select interval between backups.");
            this.scroll_interval.Value = 5;
            this.scroll_interval.Scroll += new System.EventHandler(this.scroll_interval_Scroll);
            // 
            // back_startup
            // 
            this.back_startup.AutoSize = true;
            this.back_startup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_startup.ForeColor = System.Drawing.Color.DarkGray;
            this.back_startup.Location = new System.Drawing.Point(377, 69);
            this.back_startup.Margin = new System.Windows.Forms.Padding(4);
            this.back_startup.Name = "back_startup";
            this.back_startup.Size = new System.Drawing.Size(132, 23);
            this.back_startup.TabIndex = 18;
            this.back_startup.Text = "Run at startup";
            this.toolTip1.SetToolTip(this.back_startup, "Check to start Backcraft at system startup");
            this.back_startup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your files will be backed up to 0 path(s).";
            this.toolTip1.SetToolTip(this.label2, "Paths in which backups are saved");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "7Zip folder path:";
            this.toolTip1.SetToolTip(this.label1, "Software used to compress backups");
            // 
            // back_enablelog
            // 
            this.back_enablelog.AutoSize = true;
            this.back_enablelog.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_enablelog.ForeColor = System.Drawing.Color.DarkGray;
            this.back_enablelog.Location = new System.Drawing.Point(10, 69);
            this.back_enablelog.Margin = new System.Windows.Forms.Padding(4);
            this.back_enablelog.Name = "back_enablelog";
            this.back_enablelog.Size = new System.Drawing.Size(138, 23);
            this.back_enablelog.TabIndex = 13;
            this.back_enablelog.Text = "Enable logging";
            this.toolTip1.SetToolTip(this.back_enablelog, "Check to enable logs; they are useful to keep track of backup information");
            this.back_enablelog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Backup interval (min)";
            this.toolTip1.SetToolTip(this.label8, "Time between backups, in minutes");
            // 
            // back_enable
            // 
            this.back_enable.AutoSize = true;
            this.back_enable.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_enable.Location = new System.Drawing.Point(234, 63);
            this.back_enable.Margin = new System.Windows.Forms.Padding(4);
            this.back_enable.Name = "back_enable";
            this.back_enable.Size = new System.Drawing.Size(81, 23);
            this.back_enable.TabIndex = 12;
            this.back_enable.Text = "Enable";
            this.toolTip1.SetToolTip(this.back_enable, "Enables Backcraft.");
            this.back_enable.UseVisualStyleBackColor = true;
            this.back_enable.CheckedChanged += new System.EventHandler(this.back_enable_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backup now";
            this.toolTip1.SetToolTip(this.button1, "Make a backup.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_save
            // 
            this.back_save.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_save.Location = new System.Drawing.Point(66, 635);
            this.back_save.Margin = new System.Windows.Forms.Padding(4);
            this.back_save.Name = "back_save";
            this.back_save.Size = new System.Drawing.Size(120, 39);
            this.back_save.TabIndex = 14;
            this.back_save.Text = "Save settings";
            this.toolTip1.SetToolTip(this.back_save, "Saves settings and restart.");
            this.back_save.UseVisualStyleBackColor = true;
            this.back_save.Click += new System.EventHandler(this.back_save_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Backcraft";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btn_deletesettings
            // 
            this.btn_deletesettings.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletesettings.Location = new System.Drawing.Point(322, 635);
            this.btn_deletesettings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletesettings.Name = "btn_deletesettings";
            this.btn_deletesettings.Size = new System.Drawing.Size(157, 39);
            this.btn_deletesettings.TabIndex = 18;
            this.btn_deletesettings.Text = "Delete settings";
            this.toolTip1.SetToolTip(this.btn_deletesettings, "Delete settings and restart.");
            this.btn_deletesettings.UseVisualStyleBackColor = true;
            this.btn_deletesettings.Click += new System.EventHandler(this.btn_deletesettings_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(362, 43);
            this.label_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(35, 17);
            this.label_version.TabIndex = 16;
            this.label_version.Text = "v3.0";
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(509, 11);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(37, 28);
            this.btn_report.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btn_report, "Open a issue in Github.");
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(467, 11);
            this.btn_info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(37, 28);
            this.btn_info.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btn_info, "Check the logs.");
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::backcraft.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(140, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // set_launcher
            // 
            this.set_launcher.AutoSize = true;
            this.set_launcher.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_launcher.ForeColor = System.Drawing.Color.DarkGray;
            this.set_launcher.Location = new System.Drawing.Point(201, 113);
            this.set_launcher.Margin = new System.Windows.Forms.Padding(4);
            this.set_launcher.Name = "set_launcher";
            this.set_launcher.Size = new System.Drawing.Size(158, 23);
            this.set_launcher.TabIndex = 6;
            this.set_launcher.Text = "Launcher profiles";
            this.toolTip1.SetToolTip(this.set_launcher, "If checked, Backcraft will backup your Minecraft launcher profiles");
            this.set_launcher.UseVisualStyleBackColor = true;
            this.set_launcher.Click += new System.EventHandler(this.set_launcher_Click);
            // 
            // set_screenshots
            // 
            this.set_screenshots.AutoSize = true;
            this.set_screenshots.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_screenshots.ForeColor = System.Drawing.Color.DarkGray;
            this.set_screenshots.Location = new System.Drawing.Point(378, 111);
            this.set_screenshots.Margin = new System.Windows.Forms.Padding(4);
            this.set_screenshots.Name = "set_screenshots";
            this.set_screenshots.Size = new System.Drawing.Size(122, 23);
            this.set_screenshots.TabIndex = 4;
            this.set_screenshots.Text = "Screenshots";
            this.toolTip1.SetToolTip(this.set_screenshots, "If checked, Backcraft will backup your screenshots");
            this.set_screenshots.UseVisualStyleBackColor = true;
            // 
            // set_options
            // 
            this.set_options.AutoSize = true;
            this.set_options.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_options.ForeColor = System.Drawing.Color.DarkGray;
            this.set_options.Location = new System.Drawing.Point(11, 140);
            this.set_options.Margin = new System.Windows.Forms.Padding(4);
            this.set_options.Name = "set_options";
            this.set_options.Size = new System.Drawing.Size(86, 23);
            this.set_options.TabIndex = 7;
            this.set_options.Text = "Options";
            this.toolTip1.SetToolTip(this.set_options, "If checked, Backcraft will backup your in-game settings");
            this.set_options.UseVisualStyleBackColor = true;
            // 
            // set_resource
            // 
            this.set_resource.AutoSize = true;
            this.set_resource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_resource.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_resource.ForeColor = System.Drawing.Color.DarkGray;
            this.set_resource.Location = new System.Drawing.Point(11, 113);
            this.set_resource.Margin = new System.Windows.Forms.Padding(4);
            this.set_resource.Name = "set_resource";
            this.set_resource.Size = new System.Drawing.Size(149, 23);
            this.set_resource.TabIndex = 3;
            this.set_resource.Text = "Resource packs";
            this.toolTip1.SetToolTip(this.set_resource, "If checked, Backcraft will backup your resource packs\r\n");
            this.set_resource.UseVisualStyleBackColor = true;
            // 
            // set_saves
            // 
            this.set_saves.AutoSize = true;
            this.set_saves.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_saves.ForeColor = System.Drawing.Color.DarkGray;
            this.set_saves.Location = new System.Drawing.Point(201, 140);
            this.set_saves.Margin = new System.Windows.Forms.Padding(4);
            this.set_saves.Name = "set_saves";
            this.set_saves.Size = new System.Drawing.Size(75, 23);
            this.set_saves.TabIndex = 5;
            this.set_saves.Text = "Saves";
            this.toolTip1.SetToolTip(this.set_saves, "If checked, Backcraft will backup your Minecraft worlds\r\n");
            this.set_saves.UseVisualStyleBackColor = true;
            // 
            // btn_minecraftpathsave
            // 
            this.btn_minecraftpathsave.Location = new System.Drawing.Point(357, 218);
            this.btn_minecraftpathsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minecraftpathsave.Name = "btn_minecraftpathsave";
            this.btn_minecraftpathsave.Size = new System.Drawing.Size(37, 28);
            this.btn_minecraftpathsave.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btn_minecraftpathsave, "Save Minecraft\'s path.");
            this.btn_minecraftpathsave.UseVisualStyleBackColor = true;
            this.btn_minecraftpathsave.Visible = false;
            this.btn_minecraftpathsave.Click += new System.EventHandler(this.btn_minecraftpathsave_Click);
            // 
            // btn_minecraftfoldersearch
            // 
            this.btn_minecraftfoldersearch.Location = new System.Drawing.Point(400, 249);
            this.btn_minecraftfoldersearch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minecraftfoldersearch.Name = "btn_minecraftfoldersearch";
            this.btn_minecraftfoldersearch.Size = new System.Drawing.Size(37, 28);
            this.btn_minecraftfoldersearch.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btn_minecraftfoldersearch, "Search Minecraft\'s folder.");
            this.btn_minecraftfoldersearch.UseVisualStyleBackColor = true;
            this.btn_minecraftfoldersearch.Visible = false;
            this.btn_minecraftfoldersearch.Click += new System.EventHandler(this.btn_minecraftfoldersearch_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(400, 218);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 28);
            this.btn_close.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btn_close, "Close.");
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(7, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "Minecraft folder path:";
            // 
            // textbox_minecraftpath
            // 
            this.textbox_minecraftpath.Location = new System.Drawing.Point(13, 251);
            this.textbox_minecraftpath.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_minecraftpath.Name = "textbox_minecraftpath";
            this.textbox_minecraftpath.Size = new System.Drawing.Size(380, 27);
            this.textbox_minecraftpath.TabIndex = 37;
            this.textbox_minecraftpath.Visible = false;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-15, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(492, 1);
            this.label7.TabIndex = 39;
            this.label7.Text = "label7";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(8, 222);
            this.label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(0, 19);
            this.label_text.TabIndex = 41;
            // 
            // gridview_resourcepacks
            // 
            this.gridview_resourcepacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_resourcepacks.Location = new System.Drawing.Point(12, 249);
            this.gridview_resourcepacks.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_resourcepacks.Name = "gridview_resourcepacks";
            this.gridview_resourcepacks.Size = new System.Drawing.Size(424, 208);
            this.gridview_resourcepacks.TabIndex = 41;
            this.gridview_resourcepacks.Visible = false;
            // 
            // gridview_worlds
            // 
            this.gridview_worlds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_worlds.Location = new System.Drawing.Point(12, 249);
            this.gridview_worlds.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_worlds.Name = "gridview_worlds";
            this.gridview_worlds.Size = new System.Drawing.Size(424, 208);
            this.gridview_worlds.TabIndex = 42;
            this.gridview_worlds.Visible = false;
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.label4);
            this.m_panel.Controls.Add(this.label3);
            this.m_panel.Controls.Add(this.btnSearchMCPath);
            this.m_panel.Controls.Add(this.btnSaveMCPath);
            this.m_panel.Controls.Add(this.textBox1);
            this.m_panel.Controls.Add(this.gridview_worlds);
            this.m_panel.Controls.Add(this.gridview_resourcepacks);
            this.m_panel.Controls.Add(this.btn_close);
            this.m_panel.Controls.Add(this.label_text);
            this.m_panel.Controls.Add(this.btn_minecraftfoldersearch);
            this.m_panel.Controls.Add(this.label7);
            this.m_panel.Controls.Add(this.btn_minecraftpathsave);
            this.m_panel.Controls.Add(this.gridview_backups);
            this.m_panel.Controls.Add(this.textbox_minecraftpath);
            this.m_panel.Controls.Add(this.label14);
            this.m_panel.Controls.Add(this.set_saves);
            this.m_panel.Controls.Add(this.set_resource);
            this.m_panel.Controls.Add(this.set_options);
            this.m_panel.Controls.Add(this.set_screenshots);
            this.m_panel.Controls.Add(this.set_launcher);
            this.m_panel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_panel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_panel.Location = new System.Drawing.Point(12, 99);
            this.m_panel.Margin = new System.Windows.Forms.Padding(4);
            this.m_panel.Name = "m_panel";
            this.m_panel.Padding = new System.Windows.Forms.Padding(4);
            this.m_panel.Size = new System.Drawing.Size(528, 177);
            this.m_panel.TabIndex = 11;
            this.m_panel.TabStop = false;
            this.m_panel.Text = "Minecraft settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::backcraft.Properties.Resources.settings;
            this.label4.Location = new System.Drawing.Point(277, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = " ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = global::backcraft.Properties.Resources.settings;
            this.label3.Location = new System.Drawing.Point(160, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = " ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSearchMCPath
            // 
            this.btnSearchMCPath.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMCPath.Image = global::backcraft.Properties.Resources.folder;
            this.btnSearchMCPath.Location = new System.Drawing.Point(422, 57);
            this.btnSearchMCPath.Name = "btnSearchMCPath";
            this.btnSearchMCPath.Size = new System.Drawing.Size(33, 31);
            this.btnSearchMCPath.TabIndex = 46;
            this.btnSearchMCPath.UseVisualStyleBackColor = true;
            // 
            // btnSaveMCPath
            // 
            this.btnSaveMCPath.Image = global::backcraft.Properties.Resources.save;
            this.btnSaveMCPath.Location = new System.Drawing.Point(459, 57);
            this.btnSaveMCPath.Name = "btnSaveMCPath";
            this.btnSaveMCPath.Size = new System.Drawing.Size(35, 31);
            this.btnSaveMCPath.TabIndex = 44;
            this.btnSaveMCPath.UseVisualStyleBackColor = true;
            this.btnSaveMCPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(11, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 27);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridview_backups
            // 
            this.gridview_backups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_backups.Location = new System.Drawing.Point(497, 153);
            this.gridview_backups.Name = "gridview_backups";
            this.gridview_backups.RowTemplate.Height = 24;
            this.gridview_backups.Size = new System.Drawing.Size(53, 45);
            this.gridview_backups.TabIndex = 50;
            this.gridview_backups.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEmiliano,
            this.separator1,
            this.lblStatus,
            this.separator2,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 29);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripEmiliano
            // 
            this.toolStripEmiliano.Name = "toolStripEmiliano";
            this.toolStripEmiliano.Size = new System.Drawing.Size(161, 24);
            this.toolStripEmiliano.Text = "Emiliano Montesdeoca";
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.Color.DarkGray;
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(13, 24);
            this.separator1.Text = "|";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 24);
            this.lblStatus.Text = "Settings not found";
            // 
            // separator2
            // 
            this.separator2.ForeColor = System.Drawing.Color.DarkGray;
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(13, 24);
            this.separator2.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 24);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = global::backcraft.Properties.Resources.twitter;
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 24);
            this.toolStripStatusLabel3.Text = "Twitter";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Image = global::backcraft.Properties.Resources.github;
            this.toolStripStatusLabel4.IsLink = true;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(77, 24);
            this.toolStripStatusLabel4.Text = "Github";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 727);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_deletesettings);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.b_panel);
            this.Controls.Add(this.m_panel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.back_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_enable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backcraft";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.b_panel.ResumeLayout(false);
            this.b_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_resourcepacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_worlds)).EndInit();
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_backups)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox b_panel;
        private System.Windows.Forms.Button back_save;
        private System.Windows.Forms.CheckBox back_enablelog;
        private System.Windows.Forms.CheckBox back_enable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox back_startup;
        private System.Windows.Forms.TrackBar scroll_interval;
        private System.Windows.Forms.TextBox back_intervaltextbox;
        private System.Windows.Forms.Button btn_deletesettings;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.CheckBox back_checkupdate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox set_launcher;
        private System.Windows.Forms.CheckBox set_screenshots;
        private System.Windows.Forms.CheckBox set_options;
        private System.Windows.Forms.CheckBox set_resource;
        private System.Windows.Forms.CheckBox set_saves;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_minecraftpath;
        private System.Windows.Forms.Button btn_minecraftpathsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_minecraftfoldersearch;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView gridview_resourcepacks;
        private System.Windows.Forms.DataGridView gridview_worlds;
        private System.Windows.Forms.GroupBox m_panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripEmiliano;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel separator1;
        private System.Windows.Forms.ToolStripStatusLabel separator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.TextBox textbox_7zip;
        private System.Windows.Forms.Button btnSaveMCPath;
        private System.Windows.Forms.Button btnSearchMCPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch7zipPath;
        private System.Windows.Forms.Button btnSave7ZipPath;
        private System.Windows.Forms.DataGridView gridview_backups;
        private System.Windows.Forms.Label label5;
    }
}

