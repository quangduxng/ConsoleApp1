using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinformm.Entities
{
    public class Faculty
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Address { get; set; }

        public static List<Faculty> getList()
        {
            List<Faculty> list = new List<Faculty>();
            list.Add(new Faculty
            {
                Id = "1",
                Name = "Khoa toán"
            }
             );
            list.Add(new Faculty
            {
                Id = "2",
                Name = "Khoa CNTT"
            });
            list.Add(new Faculty
            {
                Id = "3",
                Name = "Khoa Vật lí"
            }
             );
            list.Add(new Faculty
            {
                Id = "4",
                Name = "Khoa Báo"
            }
            );

            return list;
        }

    }
}
