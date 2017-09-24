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
            MaximizeBox = false;
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

            LoadWorldList();
        }

        private void btn_loadworlds_Click(object sender, EventArgs e)
        {
            LoadWorldList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in gridview_worlds.Rows)
            {
                string name = r.Cells[0].Value.ToString();
                string path = r.Cells[1].Value.ToString();
                string check = r.Cells[2].Value.ToString();
                if (Convert.ToBoolean(check))
                {
                    new logic.files(name, path, "d").WriteCFG();
                }
                else
                {
                    try
                    {
                        new logic.files().DeleteFromFile(name, path);
                    }
                    catch (Exception)
                    {
                    }
                }

            }

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadWorldList()
        {
            gridview_worlds.Rows.Clear();

            try
            {
                List<string> d = Directory.GetDirectories(_MinecraftSavesPath).ToList();

                try
                {
                    List<logic.files> files = logic.files.GetFiles();
                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;
                        try
                        {
                            if (files.Single(x => x.name == name && x.path == path) != null)
                            {
                                check = true;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        gridview_worlds.Rows.Add(name, path, check);
                    }
                }
                catch (Exception)
                {
                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;
                        gridview_worlds.Rows.Add(name, path, check);
                    }
                }

                gridview_worlds.Enabled = true;
                btn_save.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting the folders from the path! Check out that the Minecraft path is correct or if there are files inside the folder!", "Backcraft");
            }
        }

    }
}
