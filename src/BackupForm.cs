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
    public partial class BackupPathsForm : Form
    {
        public BackupPathsForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> l = logic.paths.GetPaths();

                foreach (string s in l)
                {
                    gridview_backups.Items.Add(s);
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            if (!Directory.Exists(textBox1.Text))
            {
                MessageBox.Show(
                    "The path you specified does not exist!",
                    "Backcraft - Path not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (!gridview_backups.Items.ContainsKey(textBox1.Text))
            {
                gridview_backups.Items.Add(textBox1.Text).Name = textBox1.Text;
                textBox1.Clear();
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gridview_backups.SelectedItems.Count > 0)
            {
                foreach (ListViewItem i in gridview_backups.SelectedItems)
                {
                    gridview_backups.Items.RemoveByKey(i.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem i in gridview_backups.Items)
                {
                    try
                    {
                        new logic.paths(i.Text).WriteCFg();
                        new logs.log().WriteLog(0, "Saved destination path: " + i.Text);
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Saved destination path: " + i.Text);
                    }
                }
            }
            catch (Exception)
            {
                new logs.log().WriteLog(2, "Destination path save");
            }
        }
    }
}
