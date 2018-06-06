using System;
using System.Windows.Forms;

namespace _003_ListViewImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                comboBox1.Items.AddRange(Enum.GetNames(typeof(View)));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = (View)Enum.Parse(typeof(View), comboBox1.Text);
        }
    }
}
