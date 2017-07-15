using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backcraft.forms.minecraft
{
    public partial class m_resourcepacks : Form
    {
        public string _MinecraftResourcePacksPath { get; set; } = Form1._MinecraftPath + @"\resourcepacks";
        public m_resourcepacks()
        {
            InitializeComponent();
        }

        private void m_resourcepacks_Load(object sender, EventArgs e)
        {
            gridview_resourcepacks.Enabled = false;

            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "Name";
            col1.Name = "name";

            col2.HeaderText = "Path";
            col2.Name = "path";

            col3.HeaderText = "Backup";
            col3.Name = "backup";


            gridview_resourcepacks.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3 });
            gridview_resourcepacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_resourcepacks.AllowUserToAddRows = false;

            gridview_resourcepacks.RowHeadersVisible = false;
            col3.Width = 50;
        }

        private void btn_loadresourcepakcs_Click(object sender, EventArgs e)
        {
            List<string> d = Directory.GetDirectories(_MinecraftResourcePacksPath).ToList();

            foreach (string dir in d)
            {
                string name = dir.Split('\\').Last();
                string path = dir;
                gridview_resourcepacks.Rows.Add(name, path, false);
            }

            gridview_resourcepacks.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
