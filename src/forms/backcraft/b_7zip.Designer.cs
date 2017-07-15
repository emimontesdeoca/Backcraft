namespace backcraft.forms.backcraft
{
    partial class b_7zip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(b_7zip));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_usedefault = new System.Windows.Forms.Button();
            this.brn_search = new System.Windows.Forms.Button();
            this.textbox_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(148, 139);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(67, 139);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_usedefault);
            this.groupBox1.Controls.Add(this.brn_search);
            this.groupBox1.Controls.Add(this.textbox_path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "7Zip folder path";
            // 
            // btn_usedefault
            // 
            this.btn_usedefault.Location = new System.Drawing.Point(150, 88);
            this.btn_usedefault.Name = "btn_usedefault";
            this.btn_usedefault.Size = new System.Drawing.Size(94, 23);
            this.btn_usedefault.TabIndex = 5;
            this.btn_usedefault.Text = "Use default";
            this.btn_usedefault.UseVisualStyleBackColor = true;
            this.btn_usedefault.Click += new System.EventHandler(this.btn_usedefault_Click);
            // 
            // brn_search
            // 
            this.brn_search.Location = new System.Drawing.Point(47, 88);
            this.brn_search.Name = "brn_search";
            this.brn_search.Size = new System.Drawing.Size(94, 23);
            this.brn_search.TabIndex = 4;
            this.brn_search.Text = "Search";
            this.brn_search.UseVisualStyleBackColor = true;
            this.brn_search.Click += new System.EventHandler(this.brn_search_Click);
            // 
            // textbox_path
            // 
            this.textbox_path.Location = new System.Drawing.Point(47, 62);
            this.textbox_path.Name = "textbox_path";
            this.textbox_path.Size = new System.Drawing.Size(197, 20);
            this.textbox_path.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "In order to make the backups, Backcraft uses 7Zip to compress the folders.";
            // 
            // b_7zip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "b_7zip";
            this.Text = "Backcraft";
            this.Load += new System.EventHandler(this.b_7zip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_usedefault;
        private System.Windows.Forms.Button brn_search;
        private System.Windows.Forms.TextBox textbox_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}