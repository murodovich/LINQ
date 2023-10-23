using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Teacher
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public int Age { get; set; }
            public string Spetiality { get; set; }
            public int TechCourse { get; set; }
            public string Talimshakli { get; set; }

        


        public static List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher { Id = 1, FirstName = "Asror", Age = 27, Spetiality = "Dasturlash", TechCourse = 1,Talimshakli = "Sirtqi" },
                new Teacher { Id = 2, FirstName = "Muhammad Abdulloh", Age = 23, Spetiality = "DotNet", TechCourse = 2,Talimshakli = "Kunduzgi"},
                new Teacher { Id = 3, FirstName = "Rustambek", Age = 15, Spetiality = "Backend", TechCourse = 4, Talimshakli = "Sirtqi" },
                new Teacher { Id = 4, FirstName = "Nodir", Age = 29, Spetiality = "Frontend", TechCourse = 3,Talimshakli = "Masofaviy" }
            };

            return teachers;

        }
    }
}
