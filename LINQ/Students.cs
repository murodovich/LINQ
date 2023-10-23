using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Students
    {
        public int id { get; set; }
        public string name { get; set; }

        List<Students> student1 = new List<Students>()
        {
            new Students() {id = 1, name = "Sarvar"},
            new Students() {id = 2, name = "Sarvar1"},
            new Students() {id = 3, name = "Sarvar2"},
            new Students() {id = 4, name = "Sarvar3"},
            new Students() {id = 5, name = "Sarvar4"},
            new Students() {id = 6, name = "Sarvar5"},
        };

        List<Students> student2 = new List<Students>()
        {
            new Students() {id = 1, name = "Sardor"},
            new Students() {id = 2, name = "Sardor1"},
            new Students() {id = 3, name = "Sardor2"},
            new Students() {id = 4, name = "Sardor3"},
            new Students() {id = 5, name = "Sardor4"},
            new Students() {id = 6, name = "Sardor5"}
        };

        
    }
    
}
