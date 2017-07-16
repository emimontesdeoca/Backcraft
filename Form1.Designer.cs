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
            this.set_resource = new System.Windows.Forms.CheckBox();
            this.set_screenshots = new System.Windows.Forms.CheckBox();
            this.set_saves = new System.Windows.Forms.CheckBox();
            this.set_launcher = new System.Windows.Forms.CheckBox();
            this.set_options = new System.Windows.Forms.CheckBox();
            this.m_panel = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.b_panel = new System.Windows.Forms.GroupBox();
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
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_deletesettings = new System.Windows.Forms.Button();
            this.txtMinecraftPath = new System.Windows.Forms.TextBox();
            this.btnBrowseMC = new System.Windows.Forms.Button();
            this.btnBrowse7Z = new System.Windows.Forms.Button();
            this.txtPath7Zip = new System.Windows.Forms.TextBox();
            this.defaultMCPath = new System.Windows.Forms.Label();
            this.Default7ZPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_backups = new System.Windows.Forms.Button();
            this.btn_saves = new System.Windows.Forms.Button();
            this.btn_resourcepacks = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_panel.SuspendLayout();
            this.b_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(130, 14);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 32);
            this.label.TabIndex = 0;
            this.label.Text = "Backcraft";
            // 
            // set_resource
            // 
            this.set_resource.AutoSize = true;
            this.set_resource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.set_resource.ForeColor = System.Drawing.Color.Gray;
            this.set_resource.Location = new System.Drawing.Point(13, 110);
            this.set_resource.Margin = new System.Windows.Forms.Padding(4);
            this.set_resource.Name = "set_resource";
            this.set_resource.Size = new System.Drawing.Size(132, 21);
            this.set_resource.TabIndex = 3;
            this.set_resource.Text = "Resource packs";
            this.toolTip1.SetToolTip(this.set_resource, "If this box is checked, Backcraft will backup your resource packs.");
            this.set_resource.UseVisualStyleBackColor = true;
            // 
            // set_screenshots
            // 
            this.set_screenshots.AutoSize = true;
            this.set_screenshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.set_screenshots.ForeColor = System.Drawing.Color.Gray;
            this.set_screenshots.Location = new System.Drawing.Point(278, 187);
            this.set_screenshots.Margin = new System.Windows.Forms.Padding(4);
            this.set_screenshots.Name = "set_screenshots";
            this.set_screenshots.Size = new System.Drawing.Size(109, 21);
            this.set_screenshots.TabIndex = 4;
            this.set_screenshots.Text = "Screenshots";
            this.toolTip1.SetToolTip(this.set_screenshots, "If this box is checked, Backcraft will backup your screenshots.");
            this.set_screenshots.UseVisualStyleBackColor = true;
            // 
            // set_saves
            // 
            this.set_saves.AutoSize = true;
            this.set_saves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.set_saves.ForeColor = System.Drawing.Color.Gray;
            this.set_saves.Location = new System.Drawing.Point(13, 139);
            this.set_saves.Margin = new System.Windows.Forms.Padding(4);
            this.set_saves.Name = "set_saves";
            this.set_saves.Size = new System.Drawing.Size(69, 21);
            this.set_saves.TabIndex = 5;
            this.set_saves.Text = "Saves";
            this.toolTip1.SetToolTip(this.set_saves, "If this box is checked, Backcraft will backup the worlds you select.");
            this.set_saves.UseVisualStyleBackColor = true;
            // 
            // set_launcher
            // 
            this.set_launcher.AutoSize = true;
            this.set_launcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.set_launcher.ForeColor = System.Drawing.Color.Gray;
            this.set_launcher.Location = new System.Drawing.Point(13, 187);
            this.set_launcher.Margin = new System.Windows.Forms.Padding(4);
            this.set_launcher.Name = "set_launcher";
            this.set_launcher.Size = new System.Drawing.Size(140, 21);
            this.set_launcher.TabIndex = 6;
            this.set_launcher.Text = "Launcher profiles";
            this.set_launcher.UseVisualStyleBackColor = true;
            // 
            // set_options
            // 
            this.set_options.AutoSize = true;
            this.set_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.set_options.ForeColor = System.Drawing.Color.Gray;
            this.set_options.Location = new System.Drawing.Point(173, 188);
            this.set_options.Margin = new System.Windows.Forms.Padding(4);
            this.set_options.Name = "set_options";
            this.set_options.Size = new System.Drawing.Size(79, 21);
            this.set_options.TabIndex = 7;
            this.set_options.Text = "Options";
            this.toolTip1.SetToolTip(this.set_options, "If this box is checked, Backcraft will backup your game options.");
            this.set_options.UseVisualStyleBackColor = true;
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.defaultMCPath);
            this.m_panel.Controls.Add(this.btnBrowseMC);
            this.m_panel.Controls.Add(this.btn_saves);
            this.m_panel.Controls.Add(this.txtMinecraftPath);
            this.m_panel.Controls.Add(this.label14);
            this.m_panel.Controls.Add(this.btn_resourcepacks);
            this.m_panel.Controls.Add(this.set_saves);
            this.m_panel.Controls.Add(this.set_resource);
            this.m_panel.Controls.Add(this.set_options);
            this.m_panel.Controls.Add(this.set_screenshots);
            this.m_panel.Controls.Add(this.set_launcher);
            this.m_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_panel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_panel.Location = new System.Drawing.Point(12, 75);
            this.m_panel.Margin = new System.Windows.Forms.Padding(4);
            this.m_panel.Name = "m_panel";
            this.m_panel.Padding = new System.Windows.Forms.Padding(4);
            this.m_panel.Size = new System.Drawing.Size(402, 231);
            this.m_panel.TabIndex = 11;
            this.m_panel.TabStop = false;
            this.m_panel.Text = "Backup settings";
            this.toolTip1.SetToolTip(this.m_panel, "If this box is checked, Backcraft will backup your launcher profiles.");
            this.m_panel.Enter += new System.EventHandler(this.m_panel_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(9, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Minecraft path:";
            // 
            // b_panel
            // 
            this.b_panel.Controls.Add(this.Default7ZPath);
            this.b_panel.Controls.Add(this.btnBrowse7Z);
            this.b_panel.Controls.Add(this.back_intervaltextbox);
            this.b_panel.Controls.Add(this.txtPath7Zip);
            this.b_panel.Controls.Add(this.btn_backups);
            this.b_panel.Controls.Add(this.scroll_interval);
            this.b_panel.Controls.Add(this.back_startup);
            this.b_panel.Controls.Add(this.label2);
            this.b_panel.Controls.Add(this.label1);
            this.b_panel.Controls.Add(this.back_enablelog);
            this.b_panel.Controls.Add(this.label8);
            this.b_panel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_panel.Location = new System.Drawing.Point(12, 328);
            this.b_panel.Margin = new System.Windows.Forms.Padding(4);
            this.b_panel.Name = "b_panel";
            this.b_panel.Padding = new System.Windows.Forms.Padding(4);
            this.b_panel.Size = new System.Drawing.Size(402, 242);
            this.b_panel.TabIndex = 12;
            this.b_panel.TabStop = false;
            this.b_panel.Text = "Backcraft settings";
            // 
            // back_intervaltextbox
            // 
            this.back_intervaltextbox.BackColor = System.Drawing.SystemColors.Control;
            this.back_intervaltextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.back_intervaltextbox.Enabled = false;
            this.back_intervaltextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_intervaltextbox.Location = new System.Drawing.Point(323, 148);
            this.back_intervaltextbox.Margin = new System.Windows.Forms.Padding(4);
            this.back_intervaltextbox.Name = "back_intervaltextbox";
            this.back_intervaltextbox.Size = new System.Drawing.Size(56, 17);
            this.back_intervaltextbox.TabIndex = 33;
            this.back_intervaltextbox.Text = "5 min";
            this.back_intervaltextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // scroll_interval
            // 
            this.scroll_interval.AutoSize = false;
            this.scroll_interval.Location = new System.Drawing.Point(10, 136);
            this.scroll_interval.Margin = new System.Windows.Forms.Padding(4);
            this.scroll_interval.Maximum = 60;
            this.scroll_interval.Minimum = 5;
            this.scroll_interval.Name = "scroll_interval";
            this.scroll_interval.Size = new System.Drawing.Size(321, 48);
            this.scroll_interval.SmallChange = 5;
            this.scroll_interval.TabIndex = 20;
            this.scroll_interval.TickFrequency = 5;
            this.scroll_interval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.scroll_interval.Value = 5;
            this.scroll_interval.Scroll += new System.EventHandler(this.scroll_interval_Scroll);
            // 
            // back_startup
            // 
            this.back_startup.AutoSize = true;
            this.back_startup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.back_startup.ForeColor = System.Drawing.Color.Gray;
            this.back_startup.Location = new System.Drawing.Point(101, 201);
            this.back_startup.Margin = new System.Windows.Forms.Padding(4);
            this.back_startup.Name = "back_startup";
            this.back_startup.Size = new System.Drawing.Size(120, 21);
            this.back_startup.TabIndex = 18;
            this.back_startup.Text = "Run at startup";
            this.back_startup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paths";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "7-Zip path:";
            // 
            // back_enablelog
            // 
            this.back_enablelog.AutoSize = true;
            this.back_enablelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.back_enablelog.ForeColor = System.Drawing.Color.Gray;
            this.back_enablelog.Location = new System.Drawing.Point(12, 201);
            this.back_enablelog.Margin = new System.Windows.Forms.Padding(4);
            this.back_enablelog.Name = "back_enablelog";
            this.back_enablelog.Size = new System.Drawing.Size(61, 21);
            this.back_enablelog.TabIndex = 13;
            this.back_enablelog.Text = "Logs";
            this.back_enablelog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Backup interval";
            // 
            // back_enable
            // 
            this.back_enable.AutoSize = true;
            this.back_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.back_enable.Location = new System.Drawing.Point(332, 28);
            this.back_enable.Margin = new System.Windows.Forms.Padding(4);
            this.back_enable.Name = "back_enable";
            this.back_enable.Size = new System.Drawing.Size(82, 21);
            this.back_enable.TabIndex = 12;
            this.back_enable.Text = "Enabled";
            this.back_enable.UseVisualStyleBackColor = true;
            this.back_enable.CheckedChanged += new System.EventHandler(this.back_enable_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backup now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_save
            // 
            this.back_save.Location = new System.Drawing.Point(36, 592);
            this.back_save.Margin = new System.Windows.Forms.Padding(4);
            this.back_save.Name = "back_save";
            this.back_save.Size = new System.Drawing.Size(112, 39);
            this.back_save.TabIndex = 14;
            this.back_save.Text = "Save settings";
            this.back_save.UseVisualStyleBackColor = true;
            this.back_save.Click += new System.EventHandler(this.back_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 674);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Emiliano Montesdeoca";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(358, 674);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(259, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "v3.0";
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
            this.btn_deletesettings.Location = new System.Drawing.Point(276, 592);
            this.btn_deletesettings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletesettings.Name = "btn_deletesettings";
            this.btn_deletesettings.Size = new System.Drawing.Size(118, 39);
            this.btn_deletesettings.TabIndex = 18;
            this.btn_deletesettings.Text = "Delete settings";
            this.btn_deletesettings.UseVisualStyleBackColor = true;
            this.btn_deletesettings.Click += new System.EventHandler(this.btn_deletesettings_Click);
            // 
            // txtMinecraftPath
            // 
            this.txtMinecraftPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinecraftPath.Location = new System.Drawing.Point(11, 64);
            this.txtMinecraftPath.Name = "txtMinecraftPath";
            this.txtMinecraftPath.Size = new System.Drawing.Size(332, 22);
            this.txtMinecraftPath.TabIndex = 35;
            this.txtMinecraftPath.MouseLeave += new System.EventHandler(this.txtMinecraftPath_MouseLeave);
            // 
            // btnBrowseMC
            // 
            this.btnBrowseMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseMC.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseMC.Location = new System.Drawing.Point(349, 63);
            this.btnBrowseMC.Name = "btnBrowseMC";
            this.btnBrowseMC.Size = new System.Drawing.Size(29, 25);
            this.btnBrowseMC.TabIndex = 36;
            this.btnBrowseMC.Text = "🔎";
            this.btnBrowseMC.UseVisualStyleBackColor = true;
            this.btnBrowseMC.Click += new System.EventHandler(this.btnBrowseMC_Click);
            // 
            // btnBrowse7Z
            // 
            this.btnBrowse7Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse7Z.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse7Z.Location = new System.Drawing.Point(350, 61);
            this.btnBrowse7Z.Name = "btnBrowse7Z";
            this.btnBrowse7Z.Size = new System.Drawing.Size(29, 25);
            this.btnBrowse7Z.TabIndex = 38;
            this.btnBrowse7Z.Text = "🔎";
            this.btnBrowse7Z.UseVisualStyleBackColor = true;
            this.btnBrowse7Z.Click += new System.EventHandler(this.btnBrowse7Z_Click);
            // 
            // txtPath7Zip
            // 
            this.txtPath7Zip.Location = new System.Drawing.Point(12, 62);
            this.txtPath7Zip.Name = "txtPath7Zip";
            this.txtPath7Zip.Size = new System.Drawing.Size(332, 22);
            this.txtPath7Zip.TabIndex = 37;
            this.txtPath7Zip.MouseLeave += new System.EventHandler(this.txtPath7Zip_MouseLeave);
            // 
            // defaultMCPath
            // 
            this.defaultMCPath.AutoSize = true;
            this.defaultMCPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defaultMCPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.defaultMCPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.defaultMCPath.Location = new System.Drawing.Point(110, 40);
            this.defaultMCPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultMCPath.Name = "defaultMCPath";
            this.defaultMCPath.Size = new System.Drawing.Size(135, 17);
            this.defaultMCPath.TabIndex = 37;
            this.defaultMCPath.Text = "[Click to use default]";
            this.defaultMCPath.Click += new System.EventHandler(this.defaultMCPath_Click);
            // 
            // Default7ZPath
            // 
            this.Default7ZPath.AutoSize = true;
            this.Default7ZPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Default7ZPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Default7ZPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.Default7ZPath.Location = new System.Drawing.Point(86, 39);
            this.Default7ZPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Default7ZPath.Name = "Default7ZPath";
            this.Default7ZPath.Size = new System.Drawing.Size(135, 17);
            this.Default7ZPath.TabIndex = 38;
            this.Default7ZPath.Text = "[Click to use default]";
            this.Default7ZPath.Click += new System.EventHandler(this.Default7ZPath_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btn_backups
            // 
            this.btn_backups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_backups.ForeColor = System.Drawing.Color.Black;
            this.btn_backups.Image = global::backcraft.Properties.Resources.gear;
            this.btn_backups.Location = new System.Drawing.Point(341, 198);
            this.btn_backups.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backups.Name = "btn_backups";
            this.btn_backups.Size = new System.Drawing.Size(37, 28);
            this.btn_backups.TabIndex = 31;
            this.btn_backups.UseVisualStyleBackColor = true;
            this.btn_backups.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_saves
            // 
            this.btn_saves.Enabled = false;
            this.btn_saves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_saves.ForeColor = System.Drawing.Color.Black;
            this.btn_saves.Image = global::backcraft.Properties.Resources.gear;
            this.btn_saves.Location = new System.Drawing.Point(172, 136);
            this.btn_saves.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saves.Name = "btn_saves";
            this.btn_saves.Size = new System.Drawing.Size(37, 28);
            this.btn_saves.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btn_saves, "Click to select which world(s) to backup.");
            this.btn_saves.UseVisualStyleBackColor = true;
            this.btn_saves.Click += new System.EventHandler(this.btn_saves_Click);
            // 
            // btn_resourcepacks
            // 
            this.btn_resourcepacks.Enabled = false;
            this.btn_resourcepacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_resourcepacks.ForeColor = System.Drawing.Color.Black;
            this.btn_resourcepacks.Image = global::backcraft.Properties.Resources.gear;
            this.btn_resourcepacks.Location = new System.Drawing.Point(172, 106);
            this.btn_resourcepacks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_resourcepacks.Name = "btn_resourcepacks";
            this.btn_resourcepacks.Size = new System.Drawing.Size(37, 28);
            this.btn_resourcepacks.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btn_resourcepacks, "Click to select which resource pack(s) to backup.");
            this.btn_resourcepacks.UseVisualStyleBackColor = true;
            this.btn_resourcepacks.Click += new System.EventHandler(this.btn_resourcepacks_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_deletesettings);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
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
            this.Text = "Backcraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
            this.b_panel.ResumeLayout(false);
            this.b_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox set_resource;
        private System.Windows.Forms.CheckBox set_screenshots;
        private System.Windows.Forms.CheckBox set_saves;
        private System.Windows.Forms.CheckBox set_launcher;
        private System.Windows.Forms.CheckBox set_options;
        private System.Windows.Forms.GroupBox m_panel;
        private System.Windows.Forms.GroupBox b_panel;
        private System.Windows.Forms.Button back_save;
        private System.Windows.Forms.CheckBox back_enablelog;
        private System.Windows.Forms.CheckBox back_enable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox back_startup;
        private System.Windows.Forms.Button btn_saves;
        private System.Windows.Forms.Button btn_resourcepacks;
        private System.Windows.Forms.TrackBar scroll_interval;
        private System.Windows.Forms.Button btn_backups;
        private System.Windows.Forms.TextBox back_intervaltextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_deletesettings;
        private System.Windows.Forms.Button btnBrowseMC;
        private System.Windows.Forms.TextBox txtMinecraftPath;
        private System.Windows.Forms.Button btnBrowse7Z;
        private System.Windows.Forms.TextBox txtPath7Zip;
        private System.Windows.Forms.Label defaultMCPath;
        private System.Windows.Forms.Label Default7ZPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

