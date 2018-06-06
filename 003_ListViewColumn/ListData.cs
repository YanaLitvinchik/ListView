using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListViewColumn
{
    class ListData
    {
        public static List<Data> GetDataTmp()
        {
            var tmp = new List<Data>
                {
                    new Data{Id = 1,Name = "Vova",Password = "123qwe", Surename = "Vovanchik", Birthday = new DateTime(1988,11,13)},
                    new Data{Id = 2,Name = "Olya",Password = "dsfgdfg", Surename = "Petrovich", Birthday = new DateTime(1984,10,3)},
                    new Data{Id = 3,Name = "Dasha",Password = "we fwef", Surename = "Mihaluch", Birthday = new DateTime(1982,1,1)},
                    new Data{Id = 4,Name = "Inna",Password = "werfg 343", Surename = "Vasssa", Birthday = new DateTime(1918,6,12)},
                    new Data{Id = 5,Name = "Maria",Password = "35gerf34f", Surename = "Petaaa", Birthday = new DateTime(1995,2,23)},
                    new Data{Id = 6,Name = "Anna",Password = "hyh567j6h", Surename = "Gekaaaa", Birthday = new DateTime(1919,9,23)}
                };
            return tmp;
        }
    }
}
