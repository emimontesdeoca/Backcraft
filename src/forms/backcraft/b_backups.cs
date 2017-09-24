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

namespace backcraft.forms.backcraft
{
    public partial class b_backups : Form
    {
        public b_backups()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_backups_Load(object sender, EventArgs e)
        {
            gridview_backups.Enabled = false;

            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewButtonColumn();

            col1.HeaderText = "Path";
            col1.Name = "path";

            col2.HeaderText = "Delete";
            col2.Name = "delete";


            gridview_backups.Columns.AddRange(new DataGridViewColumn[] { col1, col2 });
            gridview_backups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview_backups.AllowUserToAddRows = false;

            gridview_backups.RowHeadersVisible = false;
            col2.Width = 100;

            LoadSavePathList();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadSavePathList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textbox_path.Text != string.Empty)
            {   // Add path if exists.
                if (Directory.Exists(textbox_path.Text))
                {
                    gridview_backups.Rows.Add(textbox_path.Text.ToString(), "Delete");
                }
                else
                {
                    MessageBox.Show("Path does not exist!", "Error");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in gridview_backups.Rows)
                {
                    try
                    {
                        new logic.paths(r.Cells[0].Value.ToString()).WriteCFg();
                        new logs.log().WriteLog(0, "Saved destination path: " + r.Cells[0].Value.ToString());
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Saved destination path: " + r.Cells[0].Value.ToString());
                    }
                }
            }
            catch (Exception)
            {
                new logs.log().WriteLog(2, "Destination path save");
            }

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridview_backups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridview_backups.Columns[e.ColumnIndex].Name == "delete")
            {
                try
                {
                    new logic.paths().DeleteFromFile(gridview_backups.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gridview_backups.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception)
                {
                }
            }
        }

        private void LoadSavePathList()
        {
            gridview_backups.Rows.Clear();

            try
            {
                List<string> l = logic.paths.GetPaths();

                foreach (string s in l)
                {
                    gridview_backups.Rows.Add(s, "Delete");
                }
            }
            catch (Exception)
            {
            }


            btn_search.Enabled = true;
            btn_save.Enabled = true;
            gridview_backups.Enabled = true;
            textbox_path.Enabled = true;
        }

        private void textbox_path_TextChanged(object sender, EventArgs e)
        {
            if (textbox_path.Text != string.Empty)
            {
                btn_add.Enabled = true;
            }
            else
            {
                btn_add.Enabled = false;
            }
        }
    }
}
