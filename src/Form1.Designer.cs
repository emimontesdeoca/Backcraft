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
            this.sett_searchfolder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.set_folderlocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.acc_default7zip = new System.Windows.Forms.CheckBox();
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.back_startup = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.set_resource.Location = new System.Drawing.Point(10, 65);
            this.set_resource.Name = "set_resource";
            this.set_resource.Size = new System.Drawing.Size(126, 24);
            this.set_resource.TabIndex = 3;
            this.set_resource.Text = "Resource packs";
            this.set_resource.UseVisualStyleBackColor = true;
            // 
            // set_screenshots
            // 
            this.set_screenshots.AutoSize = true;
            this.set_screenshots.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_screenshots.Location = new System.Drawing.Point(10, 105);
            this.set_screenshots.Name = "set_screenshots";
            this.set_screenshots.Size = new System.Drawing.Size(103, 24);
            this.set_screenshots.TabIndex = 4;
            this.set_screenshots.Text = "Screenshots";
            this.set_screenshots.UseVisualStyleBackColor = true;
            // 
            // set_saves
            // 
            this.set_saves.AutoSize = true;
            this.set_saves.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_saves.Location = new System.Drawing.Point(10, 145);
            this.set_saves.Name = "set_saves";
            this.set_saves.Size = new System.Drawing.Size(66, 24);
            this.set_saves.TabIndex = 5;
            this.set_saves.Text = "Saves";
            this.set_saves.UseVisualStyleBackColor = true;
            // 
            // set_launcher
            // 
            this.set_launcher.AutoSize = true;
            this.set_launcher.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_launcher.Location = new System.Drawing.Point(10, 85);
            this.set_launcher.Name = "set_launcher";
            this.set_launcher.Size = new System.Drawing.Size(133, 24);
            this.set_launcher.TabIndex = 6;
            this.set_launcher.Text = "Launcher_profiles";
            this.set_launcher.UseVisualStyleBackColor = true;
            // 
            // set_options
            // 
            this.set_options.AutoSize = true;
            this.set_options.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.set_options.Location = new System.Drawing.Point(10, 125);
            this.set_options.Name = "set_options";
            this.set_options.Size = new System.Drawing.Size(74, 24);
            this.set_options.TabIndex = 7;
            this.set_options.Text = "Options";
            this.set_options.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.sett_searchfolder);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.set_folderlocation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.set_saves);
            this.groupBox2.Controls.Add(this.set_resource);
            this.groupBox2.Controls.Add(this.set_options);
            this.groupBox2.Controls.Add(this.set_screenshots);
            this.groupBox2.Controls.Add(this.set_launcher);
            this.groupBox2.Location = new System.Drawing.Point(9, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 175);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup settings";
            // 
            // sett_searchfolder
            // 
            this.sett_searchfolder.Location = new System.Drawing.Point(134, 16);
            this.sett_searchfolder.Name = "sett_searchfolder";
            this.sett_searchfolder.Size = new System.Drawing.Size(77, 23);
            this.sett_searchfolder.TabIndex = 14;
            this.sett_searchfolder.Text = "Search folder";
            this.sett_searchfolder.UseVisualStyleBackColor = true;
            this.sett_searchfolder.Click += new System.EventHandler(this.sett_searchfolder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Minecraft folder path";
            // 
            // set_folderlocation
            // 
            this.set_folderlocation.Location = new System.Drawing.Point(10, 45);
            this.set_folderlocation.Name = "set_folderlocation";
            this.set_folderlocation.Size = new System.Drawing.Size(313, 20);
            this.set_folderlocation.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(82, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contains in-game settings.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(141, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contains profiles inforamtion.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(76, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contains your Minecraft worlds.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(112, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "\tContains all in-game screenshots.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contains resource packs.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.back_startup);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.acc_default7zip);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.back_backupfolderpath);
            this.groupBox3.Controls.Add(this.back_search7zip);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.back_7zippath);
            this.groupBox3.Controls.Add(this.back_enablelog);
            this.groupBox3.Controls.Add(this.back_enable);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(9, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 181);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backcraft settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.checkBox1.Location = new System.Drawing.Point(222, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Default path";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // acc_default7zip
            // 
            this.acc_default7zip.AutoSize = true;
            this.acc_default7zip.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.acc_default7zip.Location = new System.Drawing.Point(222, 37);
            this.acc_default7zip.Name = "acc_default7zip";
            this.acc_default7zip.Size = new System.Drawing.Size(97, 24);
            this.acc_default7zip.TabIndex = 18;
            this.acc_default7zip.Text = "Default path";
            this.acc_default7zip.UseVisualStyleBackColor = true;
            this.acc_default7zip.CheckedChanged += new System.EventHandler(this.acc_default7zip_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Backups folder";
            // 
            // back_backupfolderpath
            // 
            this.back_backupfolderpath.Location = new System.Drawing.Point(10, 128);
            this.back_backupfolderpath.Name = "back_backupfolderpath";
            this.back_backupfolderpath.Size = new System.Drawing.Size(313, 20);
            this.back_backupfolderpath.TabIndex = 15;
            // 
            // back_search7zip
            // 
            this.back_search7zip.Location = new System.Drawing.Point(134, 38);
            this.back_search7zip.Name = "back_search7zip";
            this.back_search7zip.Size = new System.Drawing.Size(77, 23);
            this.back_search7zip.TabIndex = 17;
            this.back_search7zip.Text = "Search";
            this.back_search7zip.UseVisualStyleBackColor = true;
            this.back_search7zip.Click += new System.EventHandler(this.back_search7zip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "7zip folder path";
            // 
            // back_7zippath
            // 
            this.back_7zippath.Location = new System.Drawing.Point(10, 70);
            this.back_7zippath.Name = "back_7zippath";
            this.back_7zippath.Size = new System.Drawing.Size(313, 20);
            this.back_7zippath.TabIndex = 15;
            // 
            // back_enablelog
            // 
            this.back_enablelog.AutoSize = true;
            this.back_enablelog.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_enablelog.Location = new System.Drawing.Point(138, 15);
            this.back_enablelog.Name = "back_enablelog";
            this.back_enablelog.Size = new System.Drawing.Size(86, 24);
            this.back_enablelog.TabIndex = 13;
            this.back_enablelog.Text = "Save log ";
            this.back_enablelog.UseVisualStyleBackColor = true;
            // 
            // back_enable
            // 
            this.back_enable.AutoSize = true;
            this.back_enable.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_enable.Location = new System.Drawing.Point(10, 15);
            this.back_enable.Name = "back_enable";
            this.back_enable.Size = new System.Drawing.Size(128, 24);
            this.back_enable.TabIndex = 12;
            this.back_enable.Text = "Enable Backcraft";
            this.back_enable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Backup interval (minutes)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(293, 154);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "60";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(250, 154);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "30";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(207, 154);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(170, 154);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backup now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_save
            // 
            this.back_save.Location = new System.Drawing.Point(68, 407);
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
            this.label10.Location = new System.Drawing.Point(6, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Emiliano Montesdeoca";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 444);
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
            this.label11.Text = "v2.0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Backcraft";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.checkBox2.Location = new System.Drawing.Point(222, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 24);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Default path";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // back_startup
            // 
            this.back_startup.AutoSize = true;
            this.back_startup.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_startup.Location = new System.Drawing.Point(222, 15);
            this.back_startup.Name = "back_startup";
            this.back_startup.Size = new System.Drawing.Size(110, 24);
            this.back_startup.TabIndex = 18;
            this.back_startup.Text = "Run at Startup";
            this.back_startup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 466);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.back_save);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Backcraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox acc_default7zip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox back_backupfolderpath;
        private System.Windows.Forms.Button back_search7zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox back_7zippath;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox back_startup;
    }
}

