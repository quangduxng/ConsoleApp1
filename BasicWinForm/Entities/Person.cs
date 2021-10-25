using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinformm.Entities
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public EGioiTinh Sex { get; set; }
        public string HowTown { get; set; }

        public string FullName {
           get => $"{LastName} {FirstName}";
        }
       
        public string IdFaculty   { get; set; }

        public static List<Person> GetList()
        {
            List<Person> ls = new List<Person>();

            ls.Add(new Person
            {
                Id = "1",
                FirstName = "Truong",
                LastName = "Phuc",
                DOB = new DateTime(2000, 4, 23),
                Sex = EGioiTinh.Nam,
                HowTown = "Thua Thien Hue",
                IdFaculty = "1"

            }); ;
            ls.Add(new Person
            {
                Id = "2",
                FirstName = "Pham",
                LastName = "Tu",
                DOB = new DateTime(2002, 5, 5),
                Sex = EGioiTinh.Nu,
                HowTown = "Quang Nam",
                IdFaculty = "2"
            });
            

            return ls;

        }
        /// <summary>
        /// Lấy một sinh viên từ CSDL
        /// </summary>
        /// <param name="Mã sinh viên cần lấy"></param>
        /// <returns>
        /// Sinh viên có mã tương ứng hoặc null nếu không tìm thấy
        /// </returns>
        
        public static List<Person> GetList(string idFaculty)
        {
            var ls = GetList();
            var rs = ls.Where(e => e.IdFaculty == idFaculty).ToList();

            return rs;
        }

        public static Person Get(string id)
        {
            var dbPerson = GetList();
            //Ling to SQL
            //Lamda exspression
            var person = dbPerson.Where(p=>p.Id == id).FirstOrDefault();

            return person;
        }

    }

    public enum EGioiTinh {
         Nam , Nu
    }
}
