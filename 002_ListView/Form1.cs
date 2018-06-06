using System.Windows.Forms;

namespace _002_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //создаем контрол лист вью
            var dynamicListView = new ListView();
            dynamicListView.Location = new System.Drawing.Point(341, 12);
            dynamicListView.Size = new System.Drawing.Size(362, 276);
            dynamicListView.TabIndex = 2;

            //Снова это свойство
            dynamicListView.View = View.Details;

            // первым делом - колонки
            var c1 = new ColumnHeader();
            c1.Text = "ID";
            var c2 = new ColumnHeader();
            c2.Text = "Name";
            var c3 = new ColumnHeader();
            c3.Text = "Age";
            var c4 = new ColumnHeader();
            c4.Text = "Gender";
            dynamicListView.Columns.AddRange(new ColumnHeader[] { c1, c2, c3, c4 });

            //теперь можно добавлять айтемы и сабайтемы!!!
            //Айтемы, которые добавляються при отображаемом стиле Details это только 1 колонка
            //Чтобы добавить 2, 3 и остальные колонки надо каждому айтему добавлять сабайтемы
            var lvi1 = new ListViewItem(new string[] { "1", "Vova", "25", "m" });
            var lvi3 = new ListViewItem(new string[] { "3", "", "22", "w" });
            var lvi4 = new ListViewItem(new string[] { "4", "Vas", "", "m" });
            var lvi5 = new ListViewItem(new string[] { "5", "Petr", "", "" });

            var lvi2 = new ListViewItem("2");
            lvi2.SubItems.Add("Kate");
            lvi2.SubItems.Add("22");
            lvi2.SubItems.Add("w");

            dynamicListView.Items.AddRange(new ListViewItem[] { lvi1, lvi2, lvi3, lvi4, lvi5 });

            //вуаля )
            this.Controls.Add(dynamicListView);

        }
    }
}
