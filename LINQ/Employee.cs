
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public int Age { get; set; }
        public float Selery { get; set; }
        public string? Position { get; set; }
        public List<string>? Language { get; set; }
        public List<string>? ProgrammingLanguage { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1,FirstName = "Sarvar",LastName = "G'ulomjonov",
                    Age = 20, Selery = 3000, Position = "Strong Midle",
                    ProgrammingLanguage = new List<string> {"C","C#","Python" },
                    Language = new List<string> {"Ingliz tili","Rus tili"}},
                new Employee { Id = 2,FirstName = "Bahriddin", LastName = "Abdusalomov",
                    Age = 20, Selery = 3000, Position = "Strong Midle",
                    ProgrammingLanguage = new List<string> {"C","C#","Python" },
                    Language = new List<string> { "Ingliz tili", "Rus tili" } },
                new Employee { Id = 3,FirstName = "Sanjarbek", LastName = "Berdiqulov", 
                    Age = 17, Selery = 3000, Position = "Strong Midle",
                    ProgrammingLanguage = new List<string> {"C","C#","Python" },
                    Language = new List<string> { "Ingliz tili", "Rus tili" } },
                new Employee { Id = 4,FirstName = "Sardor", LastName = "Shukurov", 
                    Age = 20, Selery = 2000, Position = "Midle",
                    ProgrammingLanguage = new List<string> {"C++","Python" },
                    Language = new List<string> { "Ingliz tili", "Rus tili" } },
                new Employee { Id = 5,FirstName = "Said", LastName = "eshmatov", 
                    Age = 15, Selery = 700, Position = "Junior",
                    ProgrammingLanguage = new List < string > { "C", "C#", "Python" }},
                new Employee { Id = 6,FirstName = "Nodir", LastName = "Ollonazarov",
                    Age = 20, Selery = 1500, Position = "Strong Junior",
                    ProgrammingLanguage = new List<string> {"C","C#","Python" },
                    Language = new List<string> { "Ingliz tili", "Rus tili" } },
                new Employee { Id = 7,FirstName = "Bobur", LastName = "Turginboev", 
                    Age = 25, Selery = 2000, Position = "Midle",
                    ProgrammingLanguage = new List < string > { "C", "C#", "Python" },
                    Language = new List<string> { "Ingliz tili", "Rus tili" }}

            };
            return employees;

        }



    }
}
