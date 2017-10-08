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
    public partial class BackupSavesForm : Form
    {
        public BackupSavesForm()
        {
            InitializeComponent();
        }

        private void BackupSavesForm_Load(object sender, EventArgs e)
        {

            try
            {
                List<string> d = Directory.GetDirectories(Form1._MinecraftPath + "saves").ToList();

                try
                {
                    List<logic.files> files = logic.files.GetFiles();
                    if (files.Count != 0)
                    {
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
                    else
                    {

                        foreach (string dir in d)
                        {
                            string name = dir.Split('\\').Last();
                            string path = dir;
                            bool check = false;
                            gridview_worlds.Rows.Add(name, path, check);
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
        }
    }
}
