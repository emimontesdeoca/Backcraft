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
            gridview_resourcepacks.Enabled = false;

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
                        gridview_resourcepacks.Rows.Add(name, path, check);
                    }
                }
                catch (Exception)
                {
                    foreach (string dir in d)
                    {
                        string name = dir.Split('\\').Last();
                        string path = dir;
                        bool check = false;

                        gridview_resourcepacks.Rows.Add(name, path, check);
                    }
                }


                int gridview_rp_height = gridview_resourcepacks.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                gridview_resourcepacks.Enabled = true;
                gridview_resourcepacks.Height = gridview_rp_height + 47;

                gridview_resourcepacks.Enabled = true;
            }
            catch
            {
            }
        }

        private void GenericListInputForm_Load(object sender, EventArgs e)
        {         
            loadGridviewResourcePacks();

            gridview_resourcepacks.Columns[0].Width = gridview_resourcepacks.Width * 2 / 7;
            gridview_resourcepacks.Columns[1].Width = gridview_resourcepacks.Width * 4 / 7;
            gridview_resourcepacks.Columns[2].Width = gridview_resourcepacks.Width * 1 / 7;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in gridview_resourcepacks.Rows)
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
            catch
            {

            }
        }
    }
}
