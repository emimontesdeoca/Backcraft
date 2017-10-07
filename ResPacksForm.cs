using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace backcraft
{
    public partial class ResPacksForm : Form
    {

        public ResPacksForm()
        {
            InitializeComponent();
        }

        private void loadGridviewResourcePacks()
        {
            dataGridView1.Enabled = false;

            dataGridView1.Rows.Clear();
            try
            {
                List<string> d = Directory.GetDirectories(Form1._MinecraftPath + "resourcepacks").ToList();

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
                        dataGridView1.Rows.Add(name, path, check);
                    }
                }
                catch (Exception)
                {
                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;

                        dataGridView1.Rows.Add(name, path, check);
                    }
                }


                int gridview_rp_height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                dataGridView1.Enabled = true;
                dataGridView1.Height = gridview_rp_height + 47;

                dataGridView1.Enabled = true;
            }
            catch
            {
            }
        }

        private void GenericListInputForm_Load(object sender, EventArgs e)
        {         
            loadGridviewResourcePacks();

            dataGridView1.Columns[0].Width = dataGridView1.Width * 2 / 7;
            dataGridView1.Columns[1].Width = dataGridView1.Width * 4 / 7;
            dataGridView1.Columns[2].Width = dataGridView1.Width * 1 / 7;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
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
        }
    }
}
