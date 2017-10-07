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

namespace backcraft
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();

            #region ABOUT

            richtextbox_license.Text = "MIT License" + Environment.NewLine + Environment.NewLine + "Permission is hereby granted, free of charge, to any person obtaining a " +
                "copy of this software and associated documentation files(the 'Software'), to deal in the Software without restriction, including " +
                "without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/ or sell  copies of the Software, " +
                "and to permit persons to whom the Software is  furnished to do so, subject to the following conditions: " + Environment.NewLine + Environment.NewLine +
                "The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software." +
                Environment.NewLine + Environment.NewLine + "THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO " +
                "THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS " +
                "BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN " +
                "CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";


            label_version.Text = "Version " + Form1.currentVersion;

            #endregion

            #region LOGS

            try
            {
                using (System.IO.StreamReader sr = new StreamReader("logs.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox_logs.Text += line + Environment.NewLine;
                    }
                }
            }
            catch (Exception)
            {
                richTextBox_logs.Text = "File logs.txt not found!";
            }

            richTextBox_logs.SelectionStart = richTextBox_logs.Text.Length;
            richTextBox_logs.ScrollToCaret();


            #endregion

            #region FILES

            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewTextBoxColumn();

            col1.HeaderText = "Name";
            col1.Name = "name";
            col1.ReadOnly = true;

            col2.HeaderText = "Path";
            col2.Name = "path";
            col2.ReadOnly = true;

            col3.HeaderText = "MD5";
            col3.Name = "MD5";

            dataGridView_files.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3 });
            dataGridView_files.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_files.AutoSize = false;
            dataGridView_files.AllowUserToResizeRows = false;
            dataGridView_files.AllowUserToAddRows = false;
            dataGridView_files.RowHeadersVisible = false;



            try
            {
                List<logic.files> FilesToBackup = logic.files.GetFiles();

                foreach (logic.files f in FilesToBackup)
                {
                    dataGridView_files.Rows.Add(f.name, f.path, f.MD5);
                }
            }
            catch (Exception)
            {

                throw;
            }

            #endregion

            #region PATHS

            var col1_p = new DataGridViewTextBoxColumn();

            col1_p.HeaderText = "Path";
            col1_p.Name = "path";
            col1_p.ReadOnly = true;

            dataGridView_paths.Columns.AddRange(new DataGridViewColumn[] { col1_p });
            dataGridView_paths.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_paths.AutoSize = false;
            dataGridView_paths.AllowUserToResizeRows = false;
            dataGridView_paths.AllowUserToAddRows = false;
            dataGridView_paths.RowHeadersVisible = false;

            dataGridView_paths.Rows.Clear();

            try
            {
                List<string> l = logic.paths.GetPaths();

                foreach (string s in l)
                {
                    dataGridView_paths.Rows.Add(s);
                }
            }
            catch (Exception)
            {
            }


            try
            {
                List<logic.files> FilesToBackup = logic.files.GetFiles();

                foreach (logic.files f in FilesToBackup)
                {
                    dataGridView_files.Rows.Add(f.name, f.path, f.MD5);
                }
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
        }

        private void info_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

        private void btn_logs_delete_Click(object sender, EventArgs e)
        {
            File.Delete("logs.txt");
            richTextBox_logs.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://emilianomontesdeoca.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/Backcraft/issues/new");
        }
    }
}
