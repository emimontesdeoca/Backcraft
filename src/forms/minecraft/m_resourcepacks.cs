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
            gridview_resourcepacks.Rows.Clear();
            try
            {
                List<string> d = Directory.GetDirectories(_MinecraftResourcePacksPath).ToList();

                List<logic.resourcepacks> list = new logic.resourcepacks().GetWorldsFromFile();

                foreach (string dir in d)
                {
                    string name = dir.Split('\\').Last();
                    string path = dir;
                    bool check = false;
                    try
                    {
                        if (list.Single(x => x.name == name && x.path == path) != null)
                        {
                            check = true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    gridview_resourcepacks.Rows.Add(name, path, check);
                }

                gridview_resourcepacks.Enabled = true;
                btn_save.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No Minecraft path configured!", "Backcraft");
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridview_resourcepacks.Rows)
            {
                string name = r.Cells[0].Value.ToString();
                string path = r.Cells[1].Value.ToString();
                string check = r.Cells[2].Value.ToString();
                new logic.resourcepacks(name, path).WriteResourcePackDirectories(Convert.ToBoolean(check));

            }
            logic.resourcepacks.FinallyWriteFile();

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
