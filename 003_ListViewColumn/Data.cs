using System;
using System.Linq;

namespace ListViewColumn
{
    class Data
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Surename { get; set; }
        public DateTime Birthday { get; set; }

        public static String[] GetNames()
        {
            var tmp = (typeof (Data)).GetProperties();
            var listString = new string[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
                listString[i] = tmp[i].Name;
            return listString;
        }
    }
}
