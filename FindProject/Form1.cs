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

namespace FindProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var f = new FolderBrowserDialog(); 
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                PathTextBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = Directory.GetDirectories(PathTextBox1.Text);
                foreach (var item in tmp)
                {
                    var tmp1 = new ListViewItem(item.Split('\\').Last());
                    MainListView1.Items.Add(tmp1);
                    tmp1.SubItems.Add(SearchFoldersSize(new DirectoryInfo(item)).ToString());
                    tmp1.SubItems.Add(CountFolders(new DirectoryInfo(item)).ToString());
                }
            }
            catch (Exception)
            {
                PathTextBox1.Clear();
            }
        }
        private long SearchFoldersSize(DirectoryInfo di)
        {

            long size = 0;
            foreach (var item in di.GetFiles())
            {
                size += item.Length;
            }
            foreach (var item in di.GetDirectories())
            {
                size += SearchFoldersSize(item);
            }
            return size;
        }
        private long CountFolders(DirectoryInfo di)
        {
            long count = 0;
            foreach (var item in di.GetDirectories())
            {
                if (item.GetDirectories(PathTextBox1.Text).Length == 0)
                    return count;
                else
                {
                    foreach (var item1 in di.GetFiles())
                    {
                        count += item1.Length;
                    }
                }
            }
            return count;
        }
    }
}
