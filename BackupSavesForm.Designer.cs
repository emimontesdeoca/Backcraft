namespace backcraft
{
    partial class BackupSavesForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridview_worlds = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_worlds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gridview_worlds
            // 
            this.gridview_worlds.AllowUserToAddRows = false;
            this.gridview_worlds.AllowUserToDeleteRows = false;
            this.gridview_worlds.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridview_worlds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridview_worlds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_worlds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColPath,
            this.BackupCol});
            this.gridview_worlds.GridColor = System.Drawing.Color.White;
            this.gridview_worlds.Location = new System.Drawing.Point(14, 32);
            this.gridview_worlds.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_worlds.MinimumSize = new System.Drawing.Size(595, 208);
            this.gridview_worlds.Name = "gridview_worlds";
            this.gridview_worlds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_worlds.ShowEditingIcon = false;
            this.gridview_worlds.ShowRowErrors = false;
            this.gridview_worlds.Size = new System.Drawing.Size(595, 208);
            this.gridview_worlds.TabIndex = 43;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 184;
            // 
            // ColPath
            // 
            this.ColPath.HeaderText = "Path";
            this.ColPath.Name = "ColPath";
            this.ColPath.Width = 184;
            // 
            // BackupCol
            // 
            this.BackupCol.HeaderText = "Backup?";
            this.BackupCol.Name = "BackupCol";
            this.BackupCol.Width = 184;
            // 
            // button1
            // 
            this.button1.Image = global::backcraft.Properties.Resources.save;
            this.button1.Location = new System.Drawing.Point(603, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridview_worlds);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 263);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which worlds to backup?";
            // 
            // BackupSavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BackupSavesForm";
            this.Text = "BackupSavesForm";
            this.Load += new System.EventHandler(this.BackupSavesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_worlds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView gridview_worlds;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BackupCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}