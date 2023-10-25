using System.Net.Cache;

namespace LINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Credite { get; set; }
        public decimal Contract { get; set; }
        public string UniversityBranch { get; set; }
        public string UniversityName { get; set; }
        public string UniversityFaculty { get; set; }
        public string Talimshakli { get; set; }
        public int Course { get; set; }
        
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, FirstName = "AbduRustambek",
                    LastName = "Jurayev", Age = 23, 
                    Credite = 8,Contract = 9_000_000,
                    UniversityBranch = "Toshkent", UniversityName = "Irrigatsiya",
                    UniversityFaculty = "Qishloq xo'jaligi", Course = 5,Talimshakli = "Sirtqi" },

                new Student { Id = 2, FirstName = "Nurmuhammad", 
                    LastName = "SHarobiddinov", Age = 20,
                    Credite = 8, Contract = 9_000_000,
                    UniversityBranch = "Anjan", UniversityName = "ADU",
                    UniversityFaculty = "Komputer Science", Course = 3 ,Talimshakli = "Kunduzgi"},

                new Student { Id = 3, FirstName = "Hushnud",
                    LastName = "Kamolov", Age = 33, 
                    Credite = 21,Contract = 10_200_000, 
                    UniversityBranch = "Samarqand", UniversityName = "SAMDU",
                    UniversityFaculty = "Fizika", Course = 2,Talimshakli = "Kechki" },

                new Student { Id = 4, FirstName = "Mirqosim",
                    LastName = "Uzoqov", Age = 28,
                    Credite = 40,Contract = 7_000_100,
                    UniversityBranch = "Buhoro", UniversityName = "INHA",
                    UniversityFaculty = "Logistika", Course = 4, Talimshakli = "Sirtqi" },

                new Student { Id = 4, FirstName = "Abdusalom", 
                    LastName = "Abdusalomov", Age = 28, 
                    Credite = 40, Contract = 7_000_100,
                    UniversityBranch = "Buhoro", UniversityName = "INHA",
                    UniversityFaculty = "Logistika", Course = 4,Talimshakli = "Kunduzgi" },

                new Student { Id = 4, FirstName = "Bahriddin",
                    LastName = "Axunov", Age = 28, 
                    Credite = 40,Contract = 7_000_100, 
                    UniversityBranch = "Buhoro", UniversityName = "INHA",
                    UniversityFaculty = "Logistika", Course = 4,Talimshakli="Kechki" },

                new Student { Id = 5, FirstName = "Jonpo'lat", 
                    LastName = "Jurayev", Age = 23, 
                    Credite = 10, Contract = 9_000_000,
                    UniversityBranch = "Namangan", UniversityName = "Madrasa",
                    UniversityFaculty = "Tafseer", Course = 1 , Talimshakli = "Sirtqi"},

                new Student { Id = 6, FirstName = "Sevinch",
                    LastName = "Xayriddinova", Age = 31, 
                    Credite = 15,Contract = 15_300_700,
                    UniversityBranch = "Qashqadaryo", UniversityName = "TATU",
                    UniversityFaculty = "Komputer Injiniringi", Course = 3, Talimshakli = "Masofaviy" },

                new Student { Id = 7, FirstName = "Farxodbek",
                    LastName = "Madrahimov", Age = 27, 
                    Credite = 32,Contract = 4_000_000,
                    UniversityBranch = "Horazim", UniversityName = "Urganch University",
                    UniversityFaculty = "Matematika", Course = 4,Talimshakli = "Sirtqi" },

                new Student { Id = 8, FirstName = "Farxodbek", 
                    LastName = "Rustamov", Age = 19, 
                    Credite = 57,Contract = 13_000_000, 
                    UniversityBranch = "Farg'ona", UniversityName = "KIUF",
                    UniversityFaculty = "Kareys tili", Course = 2 , Talimshakli = "Kunduzgi"},
            };

            return students;
        }


        

    }

    

}
