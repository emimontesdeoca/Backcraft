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
            this.btn_minecraftfolder = new System.Windows.Forms.Button();
            this.label_checkboxscreenshots = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_checkboxoptions = new System.Windows.Forms.Label();
            this.label_checkboxlauncher = new System.Windows.Forms.Label();
            this.label_checkboxsaves = new System.Windows.Forms.Label();
            this.label_checkboxresources = new System.Windows.Forms.Label();
            this.btn_saves = new System.Windows.Forms.Button();
            this.btn_resourcepacks = new System.Windows.Forms.Button();
            this.label_options = new System.Windows.Forms.Label();
            this.label_launcher = new System.Windows.Forms.Label();
            this.label_saves = new System.Windows.Forms.Label();
            this.label_screenshots = new System.Windows.Forms.Label();
            this.label_resource = new System.Windows.Forms.Label();
            this.b_panel = new System.Windows.Forms.GroupBox();
            this.back_intervaltextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_startup = new System.Windows.Forms.Label();
            this.label_checkboxstartup = new System.Windows.Forms.Label();
            this.label_checkboxlogs = new System.Windows.Forms.Label();
            this.label_logs = new System.Windows.Forms.Label();
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
            this.label_settingsload = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.m_panel.SuspendLayout();
            this.b_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(128, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 31);
            this.label.TabIndex = 0;
            this.label.Text = "Backcraft";
            // 
            // set_resource
            // 
            this.set_resource.AutoSize = true;
            this.set_resource.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_resource.Location = new System.Drawing.Point(10, 48);
            this.set_resource.Name = "set_resource";
            this.set_resource.Size = new System.Drawing.Size(15, 14);
            this.set_resource.TabIndex = 3;
            this.set_resource.UseVisualStyleBackColor = true;
            this.set_resource.CheckedChanged += new System.EventHandler(this.set_resource_CheckedChanged);
            // 
            // set_screenshots
            // 
            this.set_screenshots.AutoSize = true;
            this.set_screenshots.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_screenshots.Location = new System.Drawing.Point(10, 148);
            this.set_screenshots.Name = "set_screenshots";
            this.set_screenshots.Size = new System.Drawing.Size(15, 14);
            this.set_screenshots.TabIndex = 4;
            this.set_screenshots.UseVisualStyleBackColor = true;
            this.set_screenshots.CheckedChanged += new System.EventHandler(this.set_screenshots_CheckedChanged);
            // 
            // set_saves
            // 
            this.set_saves.AutoSize = true;
            this.set_saves.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_saves.Location = new System.Drawing.Point(10, 73);
            this.set_saves.Name = "set_saves";
            this.set_saves.Size = new System.Drawing.Size(15, 14);
            this.set_saves.TabIndex = 5;
            this.set_saves.UseVisualStyleBackColor = true;
            this.set_saves.CheckedChanged += new System.EventHandler(this.set_saves_CheckedChanged);
            // 
            // set_launcher
            // 
            this.set_launcher.AutoSize = true;
            this.set_launcher.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_launcher.Location = new System.Drawing.Point(10, 98);
            this.set_launcher.Name = "set_launcher";
            this.set_launcher.Size = new System.Drawing.Size(15, 14);
            this.set_launcher.TabIndex = 6;
            this.set_launcher.UseVisualStyleBackColor = true;
            this.set_launcher.CheckedChanged += new System.EventHandler(this.set_launcher_CheckedChanged);
            // 
            // set_options
            // 
            this.set_options.AutoSize = true;
            this.set_options.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_options.Location = new System.Drawing.Point(10, 123);
            this.set_options.Name = "set_options";
            this.set_options.Size = new System.Drawing.Size(15, 14);
            this.set_options.TabIndex = 7;
            this.set_options.UseVisualStyleBackColor = true;
            this.set_options.CheckedChanged += new System.EventHandler(this.set_options_CheckedChanged);
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.btn_minecraftfolder);
            this.m_panel.Controls.Add(this.label_checkboxscreenshots);
            this.m_panel.Controls.Add(this.label9);
            this.m_panel.Controls.Add(this.label14);
            this.m_panel.Controls.Add(this.label_checkboxoptions);
            this.m_panel.Controls.Add(this.label_checkboxlauncher);
            this.m_panel.Controls.Add(this.label_checkboxsaves);
            this.m_panel.Controls.Add(this.label_checkboxresources);
            this.m_panel.Controls.Add(this.btn_saves);
            this.m_panel.Controls.Add(this.btn_resourcepacks);
            this.m_panel.Controls.Add(this.label_options);
            this.m_panel.Controls.Add(this.label_launcher);
            this.m_panel.Controls.Add(this.label_saves);
            this.m_panel.Controls.Add(this.label_screenshots);
            this.m_panel.Controls.Add(this.label_resource);
            this.m_panel.Controls.Add(this.set_saves);
            this.m_panel.Controls.Add(this.set_resource);
            this.m_panel.Controls.Add(this.set_options);
            this.m_panel.Controls.Add(this.set_screenshots);
            this.m_panel.Controls.Add(this.set_launcher);
            this.m_panel.Location = new System.Drawing.Point(9, 39);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(369, 172);
            this.m_panel.TabIndex = 11;
            this.m_panel.TabStop = false;
            this.m_panel.Text = "Backup settings";
            // 
            // btn_minecraftfolder
            // 
            this.btn_minecraftfolder.Location = new System.Drawing.Point(288, 18);
            this.btn_minecraftfolder.Name = "btn_minecraftfolder";
            this.btn_minecraftfolder.Size = new System.Drawing.Size(75, 23);
            this.btn_minecraftfolder.TabIndex = 35;
            this.btn_minecraftfolder.Text = "Settings";
            this.btn_minecraftfolder.UseVisualStyleBackColor = true;
            this.btn_minecraftfolder.Click += new System.EventHandler(this.btn_minecraftfolder_Click);
            // 
            // label_checkboxscreenshots
            // 
            this.label_checkboxscreenshots.AutoSize = true;
            this.label_checkboxscreenshots.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxscreenshots.Location = new System.Drawing.Point(28, 144);
            this.label_checkboxscreenshots.Name = "label_checkboxscreenshots";
            this.label_checkboxscreenshots.Size = new System.Drawing.Size(84, 20);
            this.label_checkboxscreenshots.TabIndex = 25;
            this.label_checkboxscreenshots.Text = "Screenshots";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Path to Minecraft folder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Minecraft folder";
            // 
            // label_checkboxoptions
            // 
            this.label_checkboxoptions.AutoSize = true;
            this.label_checkboxoptions.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxoptions.Location = new System.Drawing.Point(28, 119);
            this.label_checkboxoptions.Name = "label_checkboxoptions";
            this.label_checkboxoptions.Size = new System.Drawing.Size(55, 20);
            this.label_checkboxoptions.TabIndex = 24;
            this.label_checkboxoptions.Text = "Options";
            // 
            // label_checkboxlauncher
            // 
            this.label_checkboxlauncher.AutoSize = true;
            this.label_checkboxlauncher.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxlauncher.Location = new System.Drawing.Point(28, 94);
            this.label_checkboxlauncher.Name = "label_checkboxlauncher";
            this.label_checkboxlauncher.Size = new System.Drawing.Size(111, 20);
            this.label_checkboxlauncher.TabIndex = 23;
            this.label_checkboxlauncher.Text = "Launcher profiles";
            // 
            // label_checkboxsaves
            // 
            this.label_checkboxsaves.AutoSize = true;
            this.label_checkboxsaves.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxsaves.Location = new System.Drawing.Point(28, 69);
            this.label_checkboxsaves.Name = "label_checkboxsaves";
            this.label_checkboxsaves.Size = new System.Drawing.Size(47, 20);
            this.label_checkboxsaves.TabIndex = 22;
            this.label_checkboxsaves.Text = "Saves";
            // 
            // label_checkboxresources
            // 
            this.label_checkboxresources.AutoSize = true;
            this.label_checkboxresources.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxresources.Location = new System.Drawing.Point(28, 44);
            this.label_checkboxresources.Name = "label_checkboxresources";
            this.label_checkboxresources.Size = new System.Drawing.Size(107, 20);
            this.label_checkboxresources.TabIndex = 21;
            this.label_checkboxresources.Text = "Resource packs";
            // 
            // btn_saves
            // 
            this.btn_saves.Location = new System.Drawing.Point(288, 69);
            this.btn_saves.Name = "btn_saves";
            this.btn_saves.Size = new System.Drawing.Size(75, 23);
            this.btn_saves.TabIndex = 20;
            this.btn_saves.Text = "Settings";
            this.btn_saves.UseVisualStyleBackColor = true;
            this.btn_saves.Click += new System.EventHandler(this.btn_saves_Click);
            // 
            // btn_resourcepacks
            // 
            this.btn_resourcepacks.Location = new System.Drawing.Point(288, 43);
            this.btn_resourcepacks.Name = "btn_resourcepacks";
            this.btn_resourcepacks.Size = new System.Drawing.Size(75, 23);
            this.btn_resourcepacks.TabIndex = 19;
            this.btn_resourcepacks.Text = "Settings";
            this.btn_resourcepacks.UseVisualStyleBackColor = true;
            this.btn_resourcepacks.Click += new System.EventHandler(this.btn_resourcepacks_Click);
            // 
            // label_options
            // 
            this.label_options.AutoSize = true;
            this.label_options.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_options.Location = new System.Drawing.Point(89, 122);
            this.label_options.Name = "label_options";
            this.label_options.Size = new System.Drawing.Size(132, 16);
            this.label_options.TabIndex = 13;
            this.label_options.Text = "Backups in-game settings.";
            // 
            // label_launcher
            // 
            this.label_launcher.AutoSize = true;
            this.label_launcher.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_launcher.Location = new System.Drawing.Point(145, 97);
            this.label_launcher.Name = "label_launcher";
            this.label_launcher.Size = new System.Drawing.Size(144, 16);
            this.label_launcher.TabIndex = 12;
            this.label_launcher.Text = "Backups profiles inforamtion.";
            // 
            // label_saves
            // 
            this.label_saves.AutoSize = true;
            this.label_saves.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_saves.Location = new System.Drawing.Point(89, 72);
            this.label_saves.Name = "label_saves";
            this.label_saves.Size = new System.Drawing.Size(155, 16);
            this.label_saves.TabIndex = 11;
            this.label_saves.Text = "Backups your Minecraft worlds.";
            // 
            // label_screenshots
            // 
            this.label_screenshots.AutoSize = true;
            this.label_screenshots.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_screenshots.Location = new System.Drawing.Point(118, 147);
            this.label_screenshots.Name = "label_screenshots";
            this.label_screenshots.Size = new System.Drawing.Size(166, 16);
            this.label_screenshots.TabIndex = 10;
            this.label_screenshots.Text = "Backups all in-game screenshots.";
            // 
            // label_resource
            // 
            this.label_resource.AutoSize = true;
            this.label_resource.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resource.Location = new System.Drawing.Point(141, 46);
            this.label_resource.Name = "label_resource";
            this.label_resource.Size = new System.Drawing.Size(126, 16);
            this.label_resource.TabIndex = 9;
            this.label_resource.Text = "Backups resource packs.";
            // 
            // b_panel
            // 
            this.b_panel.Controls.Add(this.back_intervaltextbox);
            this.b_panel.Controls.Add(this.label13);
            this.b_panel.Controls.Add(this.button5);
            this.b_panel.Controls.Add(this.label12);
            this.b_panel.Controls.Add(this.button3);
            this.b_panel.Controls.Add(this.label3);
            this.b_panel.Controls.Add(this.label_startup);
            this.b_panel.Controls.Add(this.label_checkboxstartup);
            this.b_panel.Controls.Add(this.label_checkboxlogs);
            this.b_panel.Controls.Add(this.label_logs);
            this.b_panel.Controls.Add(this.scroll_interval);
            this.b_panel.Controls.Add(this.back_startup);
            this.b_panel.Controls.Add(this.label2);
            this.b_panel.Controls.Add(this.label1);
            this.b_panel.Controls.Add(this.back_enablelog);
            this.b_panel.Controls.Add(this.label8);
            this.b_panel.Location = new System.Drawing.Point(9, 217);
            this.b_panel.Name = "b_panel";
            this.b_panel.Size = new System.Drawing.Size(369, 204);
            this.b_panel.TabIndex = 12;
            this.b_panel.TabStop = false;
            this.b_panel.Text = "Backcraft settings";
            // 
            // back_intervaltextbox
            // 
            this.back_intervaltextbox.Enabled = false;
            this.back_intervaltextbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_intervaltextbox.Location = new System.Drawing.Point(305, 153);
            this.back_intervaltextbox.Name = "back_intervaltextbox";
            this.back_intervaltextbox.Size = new System.Drawing.Size(43, 26);
            this.back_intervaltextbox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(112, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Time between backups, in minutes.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Settings";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Locations where backups are saved.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Software used to compress the backups";
            // 
            // label_startup
            // 
            this.label_startup.AutoSize = true;
            this.label_startup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startup.Location = new System.Drawing.Point(123, 43);
            this.label_startup.Name = "label_startup";
            this.label_startup.Size = new System.Drawing.Size(117, 16);
            this.label_startup.TabIndex = 28;
            this.label_startup.Text = "Set Backcraft to run at ";
            // 
            // label_checkboxstartup
            // 
            this.label_checkboxstartup.AutoSize = true;
            this.label_checkboxstartup.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxstartup.Location = new System.Drawing.Point(28, 40);
            this.label_checkboxstartup.Name = "label_checkboxstartup";
            this.label_checkboxstartup.Size = new System.Drawing.Size(89, 20);
            this.label_checkboxstartup.TabIndex = 27;
            this.label_checkboxstartup.Text = "Run at startup";
            // 
            // label_checkboxlogs
            // 
            this.label_checkboxlogs.AutoSize = true;
            this.label_checkboxlogs.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_checkboxlogs.Location = new System.Drawing.Point(28, 15);
            this.label_checkboxlogs.Name = "label_checkboxlogs";
            this.label_checkboxlogs.Size = new System.Drawing.Size(39, 20);
            this.label_checkboxlogs.TabIndex = 26;
            this.label_checkboxlogs.Text = "Logs";
            // 
            // label_logs
            // 
            this.label_logs.AutoSize = true;
            this.label_logs.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logs.Location = new System.Drawing.Point(82, 18);
            this.label_logs.Name = "label_logs";
            this.label_logs.Size = new System.Drawing.Size(215, 16);
            this.label_logs.TabIndex = 26;
            this.label_logs.Text = "Useful to keep track of backups information.";
            // 
            // scroll_interval
            // 
            this.scroll_interval.Location = new System.Drawing.Point(6, 143);
            this.scroll_interval.Maximum = 60;
            this.scroll_interval.Minimum = 5;
            this.scroll_interval.Name = "scroll_interval";
            this.scroll_interval.Size = new System.Drawing.Size(283, 45);
            this.scroll_interval.SmallChange = 5;
            this.scroll_interval.TabIndex = 20;
            this.scroll_interval.TickFrequency = 5;
            this.scroll_interval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.scroll_interval.Value = 5;
            // 
            // back_startup
            // 
            this.back_startup.AutoSize = true;
            this.back_startup.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_startup.Location = new System.Drawing.Point(10, 44);
            this.back_startup.Name = "back_startup";
            this.back_startup.Size = new System.Drawing.Size(15, 14);
            this.back_startup.TabIndex = 18;
            this.back_startup.UseVisualStyleBackColor = true;
            this.back_startup.CheckedChanged += new System.EventHandler(this.back_startup_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Backups";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "7Zip";
            // 
            // back_enablelog
            // 
            this.back_enablelog.AutoSize = true;
            this.back_enablelog.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_enablelog.Location = new System.Drawing.Point(10, 19);
            this.back_enablelog.Name = "back_enablelog";
            this.back_enablelog.Size = new System.Drawing.Size(15, 14);
            this.back_enablelog.TabIndex = 13;
            this.back_enablelog.UseVisualStyleBackColor = true;
            this.back_enablelog.CheckedChanged += new System.EventHandler(this.back_enablelog_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Backup interval";
            // 
            // back_enable
            // 
            this.back_enable.AutoSize = true;
            this.back_enable.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_enable.Location = new System.Drawing.Point(54, 9);
            this.back_enable.Name = "back_enable";
            this.back_enable.Size = new System.Drawing.Size(70, 24);
            this.back_enable.TabIndex = 12;
            this.back_enable.Text = "Enable";
            this.back_enable.UseVisualStyleBackColor = true;
            this.back_enable.CheckedChanged += new System.EventHandler(this.back_enable_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backup now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_save
            // 
            this.back_save.Location = new System.Drawing.Point(24, 427);
            this.back_save.Name = "back_save";
            this.back_save.Size = new System.Drawing.Size(105, 32);
            this.back_save.TabIndex = 14;
            this.back_save.Text = "Save settings";
            this.back_save.UseVisualStyleBackColor = true;
            this.back_save.Click += new System.EventHandler(this.back_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Emiliano Montesdeoca";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(340, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
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
            // label_settingsload
            // 
            this.label_settingsload.AutoSize = true;
            this.label_settingsload.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_settingsload.Location = new System.Drawing.Point(294, 17);
            this.label_settingsload.Name = "label_settingsload";
            this.label_settingsload.Size = new System.Drawing.Size(74, 16);
            this.label_settingsload.TabIndex = 17;
            this.label_settingsload.Text = "Settings failed";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(255, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 32);
            this.button6.TabIndex = 18;
            this.button6.Text = "Delete settings";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 482);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label_settingsload);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.b_panel);
            this.Controls.Add(this.m_panel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.back_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_enable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Backcraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
            this.b_panel.ResumeLayout(false);
            this.b_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_interval)).EndInit();
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
        private System.Windows.Forms.Label label_options;
        private System.Windows.Forms.Label label_launcher;
        private System.Windows.Forms.Label label_saves;
        private System.Windows.Forms.Label label_screenshots;
        private System.Windows.Forms.Label label_resource;
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
        private System.Windows.Forms.Label label_checkboxscreenshots;
        private System.Windows.Forms.Label label_checkboxoptions;
        private System.Windows.Forms.Label label_checkboxlauncher;
        private System.Windows.Forms.Label label_checkboxsaves;
        private System.Windows.Forms.Label label_checkboxresources;
        private System.Windows.Forms.Label label_startup;
        private System.Windows.Forms.Label label_checkboxstartup;
        private System.Windows.Forms.Label label_checkboxlogs;
        private System.Windows.Forms.Label label_logs;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox back_intervaltextbox;
        private System.Windows.Forms.Button btn_minecraftfolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_settingsload;
        private System.Windows.Forms.Button button6;
    }
}

