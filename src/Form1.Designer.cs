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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UseDefaultMinePath = new System.Windows.Forms.Label();
            this.sett_searchfolder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.set_folderlocation = new System.Windows.Forms.TextBox();
            this.GroupBackCraft = new System.Windows.Forms.GroupBox();
            this.UseDefaultBackupPath = new System.Windows.Forms.Label();
            this.UseDefault7ZipPath = new System.Windows.Forms.Label();
            this.back_startup = new System.Windows.Forms.CheckBox();
            this.searchbackups = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back_backupfolderpath = new System.Windows.Forms.TextBox();
            this.back_search7zip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_7zippath = new System.Windows.Forms.TextBox();
            this.back_enablelog = new System.Windows.Forms.CheckBox();
            this.back_enable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.back_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.GroupBackCraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(184, 13);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(155, 38);
            this.label.TabIndex = 0;
            this.label.Text = "Backcraft";
            // 
            // set_resource
            // 
            this.set_resource.AutoSize = true;
            this.set_resource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_resource.ForeColor = System.Drawing.Color.Black;
            this.set_resource.Location = new System.Drawing.Point(13, 91);
            this.set_resource.Margin = new System.Windows.Forms.Padding(4);
            this.set_resource.Name = "set_resource";
            this.set_resource.Size = new System.Drawing.Size(139, 22);
            this.set_resource.TabIndex = 3;
            this.set_resource.Text = "Resource packs";
            this.toolTip1.SetToolTip(this.set_resource, "Contains resource packs.");
            this.set_resource.UseVisualStyleBackColor = true;
            // 
            // set_screenshots
            // 
            this.set_screenshots.AutoSize = true;
            this.set_screenshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_screenshots.ForeColor = System.Drawing.Color.Black;
            this.set_screenshots.Location = new System.Drawing.Point(337, 91);
            this.set_screenshots.Margin = new System.Windows.Forms.Padding(4);
            this.set_screenshots.Name = "set_screenshots";
            this.set_screenshots.Size = new System.Drawing.Size(114, 22);
            this.set_screenshots.TabIndex = 4;
            this.set_screenshots.Text = "Screenshots";
            this.toolTip1.SetToolTip(this.set_screenshots, "Contains all in-game screenshots.");
            this.set_screenshots.UseVisualStyleBackColor = true;
            // 
            // set_saves
            // 
            this.set_saves.AutoSize = true;
            this.set_saves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_saves.ForeColor = System.Drawing.Color.Black;
            this.set_saves.Location = new System.Drawing.Point(169, 114);
            this.set_saves.Margin = new System.Windows.Forms.Padding(4);
            this.set_saves.Name = "set_saves";
            this.set_saves.Size = new System.Drawing.Size(71, 22);
            this.set_saves.TabIndex = 5;
            this.set_saves.Text = "Saves";
            this.toolTip1.SetToolTip(this.set_saves, "Contains your Minecraft worlds.");
            this.set_saves.UseVisualStyleBackColor = true;
            // 
            // set_launcher
            // 
            this.set_launcher.AutoSize = true;
            this.set_launcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_launcher.ForeColor = System.Drawing.Color.Black;
            this.set_launcher.Location = new System.Drawing.Point(169, 91);
            this.set_launcher.Margin = new System.Windows.Forms.Padding(4);
            this.set_launcher.Name = "set_launcher";
            this.set_launcher.Size = new System.Drawing.Size(147, 22);
            this.set_launcher.TabIndex = 6;
            this.set_launcher.Text = "Launcher_profiles";
            this.toolTip1.SetToolTip(this.set_launcher, "Contains profile information.");
            this.set_launcher.UseVisualStyleBackColor = true;
            // 
            // set_options
            // 
            this.set_options.AutoSize = true;
            this.set_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_options.ForeColor = System.Drawing.Color.Black;
            this.set_options.Location = new System.Drawing.Point(13, 114);
            this.set_options.Margin = new System.Windows.Forms.Padding(4);
            this.set_options.Name = "set_options";
            this.set_options.Size = new System.Drawing.Size(82, 22);
            this.set_options.TabIndex = 7;
            this.set_options.Text = "Options";
            this.toolTip1.SetToolTip(this.set_options, "Contains in-game settings.");
            this.set_options.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UseDefaultMinePath);
            this.groupBox2.Controls.Add(this.sett_searchfolder);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.set_folderlocation);
            this.groupBox2.Controls.Add(this.set_saves);
            this.groupBox2.Controls.Add(this.set_resource);
            this.groupBox2.Controls.Add(this.set_options);
            this.groupBox2.Controls.Add(this.set_screenshots);
            this.groupBox2.Controls.Add(this.set_launcher);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(521, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup settings";
            // 
            // UseDefaultMinePath
            // 
            this.UseDefaultMinePath.AutoSize = true;
            this.UseDefaultMinePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UseDefaultMinePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDefaultMinePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UseDefaultMinePath.Location = new System.Drawing.Point(154, 31);
            this.UseDefaultMinePath.Name = "UseDefaultMinePath";
            this.UseDefaultMinePath.Size = new System.Drawing.Size(141, 18);
            this.UseDefaultMinePath.TabIndex = 19;
            this.UseDefaultMinePath.Text = "[Click to use default]";
            this.UseDefaultMinePath.Click += new System.EventHandler(this.UseDefaultMinePath_Click);
            // 
            // sett_searchfolder
            // 
            this.sett_searchfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sett_searchfolder.ForeColor = System.Drawing.Color.Black;
            this.sett_searchfolder.Location = new System.Drawing.Point(467, 56);
            this.sett_searchfolder.Margin = new System.Windows.Forms.Padding(4);
            this.sett_searchfolder.Name = "sett_searchfolder";
            this.sett_searchfolder.Size = new System.Drawing.Size(41, 28);
            this.sett_searchfolder.TabIndex = 14;
            this.sett_searchfolder.Text = "🔎";
            this.sett_searchfolder.UseVisualStyleBackColor = true;
            this.sett_searchfolder.Click += new System.EventHandler(this.sett_searchfolder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Minecraft folder path:";
            // 
            // set_folderlocation
            // 
            this.set_folderlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_folderlocation.ForeColor = System.Drawing.Color.Black;
            this.set_folderlocation.Location = new System.Drawing.Point(13, 57);
            this.set_folderlocation.Margin = new System.Windows.Forms.Padding(4);
            this.set_folderlocation.Name = "set_folderlocation";
            this.set_folderlocation.Size = new System.Drawing.Size(446, 27);
            this.set_folderlocation.TabIndex = 11;
            // 
            // GroupBackCraft
            // 
            this.GroupBackCraft.Controls.Add(this.UseDefaultBackupPath);
            this.GroupBackCraft.Controls.Add(this.UseDefault7ZipPath);
            this.GroupBackCraft.Controls.Add(this.back_startup);
            this.GroupBackCraft.Controls.Add(this.searchbackups);
            this.GroupBackCraft.Controls.Add(this.label2);
            this.GroupBackCraft.Controls.Add(this.back_backupfolderpath);
            this.GroupBackCraft.Controls.Add(this.back_search7zip);
            this.GroupBackCraft.Controls.Add(this.label1);
            this.GroupBackCraft.Controls.Add(this.back_7zippath);
            this.GroupBackCraft.Controls.Add(this.back_enablelog);
            this.GroupBackCraft.Controls.Add(this.back_enable);
            this.GroupBackCraft.Controls.Add(this.label8);
            this.GroupBackCraft.Controls.Add(this.radioButton4);
            this.GroupBackCraft.Controls.Add(this.radioButton3);
            this.GroupBackCraft.Controls.Add(this.radioButton2);
            this.GroupBackCraft.Controls.Add(this.radioButton1);
            this.GroupBackCraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBackCraft.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBackCraft.Location = new System.Drawing.Point(12, 253);
            this.GroupBackCraft.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBackCraft.Name = "GroupBackCraft";
            this.GroupBackCraft.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBackCraft.Size = new System.Drawing.Size(521, 262);
            this.GroupBackCraft.TabIndex = 12;
            this.GroupBackCraft.TabStop = false;
            this.GroupBackCraft.Text = "Backcraft settings";
            // 
            // UseDefaultBackupPath
            // 
            this.UseDefaultBackupPath.AutoSize = true;
            this.UseDefaultBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UseDefaultBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDefaultBackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UseDefaultBackupPath.Location = new System.Drawing.Point(122, 153);
            this.UseDefaultBackupPath.Name = "UseDefaultBackupPath";
            this.UseDefaultBackupPath.Size = new System.Drawing.Size(141, 18);
            this.UseDefaultBackupPath.TabIndex = 21;
            this.UseDefaultBackupPath.Text = "[Click to use default]";
            this.UseDefaultBackupPath.Click += new System.EventHandler(this.UseDefaultBackupPath_Click);
            // 
            // UseDefault7ZipPath
            // 
            this.UseDefault7ZipPath.AutoSize = true;
            this.UseDefault7ZipPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UseDefault7ZipPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDefault7ZipPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UseDefault7ZipPath.Location = new System.Drawing.Point(127, 80);
            this.UseDefault7ZipPath.Name = "UseDefault7ZipPath";
            this.UseDefault7ZipPath.Size = new System.Drawing.Size(141, 18);
            this.UseDefault7ZipPath.TabIndex = 20;
            this.UseDefault7ZipPath.Text = "[Click to use default]";
            this.UseDefault7ZipPath.Click += new System.EventHandler(this.UseDefault7ZipPath_Click);
            // 
            // back_startup
            // 
            this.back_startup.AutoSize = true;
            this.back_startup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_startup.ForeColor = System.Drawing.Color.Black;
            this.back_startup.Location = new System.Drawing.Point(305, 36);
            this.back_startup.Margin = new System.Windows.Forms.Padding(4);
            this.back_startup.Name = "back_startup";
            this.back_startup.Size = new System.Drawing.Size(124, 22);
            this.back_startup.TabIndex = 18;
            this.back_startup.Text = "Run at Startup";
            this.back_startup.UseVisualStyleBackColor = true;
            // 
            // searchbackups
            // 
            this.searchbackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbackups.ForeColor = System.Drawing.Color.Black;
            this.searchbackups.Location = new System.Drawing.Point(467, 175);
            this.searchbackups.Margin = new System.Windows.Forms.Padding(4);
            this.searchbackups.Name = "searchbackups";
            this.searchbackups.Size = new System.Drawing.Size(41, 28);
            this.searchbackups.TabIndex = 17;
            this.searchbackups.Text = "🔎";
            this.searchbackups.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Backups folder:";
            // 
            // back_backupfolderpath
            // 
            this.back_backupfolderpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_backupfolderpath.ForeColor = System.Drawing.Color.Black;
            this.back_backupfolderpath.Location = new System.Drawing.Point(12, 176);
            this.back_backupfolderpath.Margin = new System.Windows.Forms.Padding(4);
            this.back_backupfolderpath.Name = "back_backupfolderpath";
            this.back_backupfolderpath.Size = new System.Drawing.Size(446, 27);
            this.back_backupfolderpath.TabIndex = 15;
            // 
            // back_search7zip
            // 
            this.back_search7zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_search7zip.ForeColor = System.Drawing.Color.Black;
            this.back_search7zip.Location = new System.Drawing.Point(466, 103);
            this.back_search7zip.Margin = new System.Windows.Forms.Padding(4);
            this.back_search7zip.Name = "back_search7zip";
            this.back_search7zip.Size = new System.Drawing.Size(41, 28);
            this.back_search7zip.TabIndex = 17;
            this.back_search7zip.Text = "🔎";
            this.back_search7zip.UseVisualStyleBackColor = true;
            this.back_search7zip.Click += new System.EventHandler(this.back_search7zip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "7-Zip folder path:";
            // 
            // back_7zippath
            // 
            this.back_7zippath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_7zippath.ForeColor = System.Drawing.Color.Black;
            this.back_7zippath.Location = new System.Drawing.Point(12, 104);
            this.back_7zippath.Margin = new System.Windows.Forms.Padding(4);
            this.back_7zippath.Name = "back_7zippath";
            this.back_7zippath.Size = new System.Drawing.Size(446, 27);
            this.back_7zippath.TabIndex = 15;
            // 
            // back_enablelog
            // 
            this.back_enablelog.AutoSize = true;
            this.back_enablelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_enablelog.ForeColor = System.Drawing.Color.Black;
            this.back_enablelog.Location = new System.Drawing.Point(186, 36);
            this.back_enablelog.Margin = new System.Windows.Forms.Padding(4);
            this.back_enablelog.Name = "back_enablelog";
            this.back_enablelog.Size = new System.Drawing.Size(91, 22);
            this.back_enablelog.TabIndex = 13;
            this.back_enablelog.Text = "Save log ";
            this.back_enablelog.UseVisualStyleBackColor = true;
            // 
            // back_enable
            // 
            this.back_enable.AutoSize = true;
            this.back_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_enable.ForeColor = System.Drawing.Color.Black;
            this.back_enable.Location = new System.Drawing.Point(12, 36);
            this.back_enable.Margin = new System.Windows.Forms.Padding(4);
            this.back_enable.Name = "back_enable";
            this.back_enable.Size = new System.Drawing.Size(142, 22);
            this.back_enable.TabIndex = 12;
            this.back_enable.Text = "Enable Backcraft";
            this.back_enable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Backup interval (minutes)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(375, 225);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 22);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "60";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(319, 225);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "30";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(263, 225);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(217, 225);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(267, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backup now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_save
            // 
            this.back_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_save.Location = new System.Drawing.Point(118, 532);
            this.back_save.Margin = new System.Windows.Forms.Padding(4);
            this.back_save.Name = "back_save";
            this.back_save.Size = new System.Drawing.Size(140, 39);
            this.back_save.TabIndex = 14;
            this.back_save.Text = "Save settings";
            this.back_save.UseVisualStyleBackColor = true;
            this.back_save.Click += new System.EventHandler(this.back_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 596);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Emiliano Montesdeoca";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(482, 596);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 18);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "v2.0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Backcraft";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(135, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GroupBackCraft);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.back_save);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Backcraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBackCraft.ResumeLayout(false);
            this.GroupBackCraft.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GroupBackCraft;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button back_save;
        private System.Windows.Forms.CheckBox back_enablelog;
        private System.Windows.Forms.CheckBox back_enable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button sett_searchfolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox set_folderlocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button searchbackups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox back_backupfolderpath;
        private System.Windows.Forms.Button back_search7zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox back_7zippath;
        private System.Windows.Forms.CheckBox back_startup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label UseDefaultMinePath;
        private System.Windows.Forms.Label UseDefaultBackupPath;
        private System.Windows.Forms.Label UseDefault7ZipPath;
    }
}

