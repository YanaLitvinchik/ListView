using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ListViewColumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //посмотреть функционал!!!
            listBoxColumns.Items.AddRange(Data.GetNames());
        }

        private void ListBoxColumnChange_SelectedIndexChange(object sender, EventArgs e)
        {
            var control = sender as ListBox;
            Debug.Assert(control != null, "control != null");
            var arrayColumnsName = control.SelectedItems;
            listViewDate.Items.Clear();
            listViewDate.Columns.Clear();
            foreach (var variable in arrayColumnsName)
            {
                var tmp = new ColumnHeader {Width = 100, Text = variable.ToString()};
                listViewDate.Columns.Add(tmp);
            }
            var columns = new string[arrayColumnsName.Count];
            arrayColumnsName.CopyTo(columns,0);
            SetDataToListView(ListData.GetDataTmp(),columns);
        }

        private void SetDataToListView(IEnumerable<Data> list, String[] columns)
        {
            if (columns.Length == 0)
                return;
            Type tData = typeof (Data);
            foreach (var data in list)
            {
                var lvi = new ListViewItem(tData.GetProperty(columns[0]).GetValue(data, null).ToString());
                for (int i = 1; i < columns.Length; i++)
                {
                    lvi.SubItems.Add(tData.GetProperty(columns[i]).GetValue(data, null).ToString());
                }
                listViewDate.Items.Add(lvi);
            }
        }
        

    }
}
