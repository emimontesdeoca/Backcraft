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
    public partial class m_saves : Form
    {
        public string _MinecraftSavesPath { get; set; } = Form1._MinecraftPath + @"\saves";

        public m_saves()
        {
            InitializeComponent();
        }

        private void m_saves_Load(object sender, EventArgs e)
        {
            gridview_worlds.Enabled = false;

            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "Name";
            col1.Name = "name";

            col2.HeaderText = "Path";
            col2.Name = "path";

            col3.HeaderText = "Backup";
            col3.Name = "backup";


            gridview_worlds.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3 });
            gridview_worlds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_worlds.AllowUserToAddRows = false;

            gridview_worlds.RowHeadersVisible = false;
            col3.Width = 50;
        }

        private void btn_loadworlds_Click(object sender, EventArgs e)
        {
            List<string> d = Directory.GetDirectories(_MinecraftSavesPath).ToList();

            foreach (string dir in d)
            {
                string name = dir.Split('\\').Last();
                string path = dir;
                gridview_worlds.Rows.Add(name, path, false);
            }

            gridview_worlds.Enabled = true;
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
