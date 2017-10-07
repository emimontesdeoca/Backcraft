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

            if (!listView1.Items.ContainsKey(textBox1.Text))
            {
                listView1.Items.Add(textBox1.Text).Name = textBox1.Text;
                textBox1.Clear();
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    listView1.Items.RemoveByKey(i.Text);
                }
            }
        }
    }
}
