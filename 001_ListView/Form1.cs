using System.Windows.Forms;

namespace _001_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //создаем контрол лист вью
            var dynamicListView = new ListView();
            dynamicListView.Location = new System.Drawing.Point(419, 29);
            dynamicListView.Size = new System.Drawing.Size(428, 262);
            dynamicListView.TabIndex = 2;

            //задаем свойства лист вьюхе
            dynamicListView.View = View.Tile;

            //создаем группы и добавляем их в лист вью
            var diskListViewGroup = new ListViewGroup("Жесткие диски");
            var flashListViewGroup = new ListViewGroup("Съемные диски");
            dynamicListView.Groups.Add(diskListViewGroup);
            dynamicListView.Groups.Add(flashListViewGroup);

            //Теперь очередь элементов нашей листвьюхи.
            //Группа дисков
            var lvi1 = new ListViewItem();
            lvi1.Text = "C:\\";
            lvi1.Group = diskListViewGroup;
            dynamicListView.Items.Add(lvi1);

            var lvi2 = new ListViewItem("D:\\");
            lvi2.Group = diskListViewGroup;
            dynamicListView.Items.Add(lvi2);

            var lvi3 = new ListViewItem("E:\\",diskListViewGroup);
            dynamicListView.Items.Add(lvi3);

            //группа флехи
            dynamicListView.Items.Add(new ListViewItem("Флеха 1", flashListViewGroup));
            dynamicListView.Items.Add(new ListViewItem("Флеха 2", flashListViewGroup));

            //без группы
            dynamicListView.Items.Add(new ListViewItem("Безгрупный 1 )))"));
            dynamicListView.Items.Add(new ListViewItem("без группы 2"));
            
            //От і все
            this.Controls.Add(dynamicListView);
        }
    }
}
