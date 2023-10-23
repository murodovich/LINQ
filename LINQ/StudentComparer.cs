using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class StudentComparer : IEqualityComparer<Students>
    {
        public bool Equals(Students? x, Students? y)
        {
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y,null))
                return false;
            if(object.ReferenceEquals(x, y)) 
                return true; 
           
            return x.id == y.id && x.name == y.name;

        }

        public int GetHashCode([DisallowNull] Students obj)
        {
            if(object.ReferenceEquals (obj, null)) return 0;

            int hashCardId = obj.id.GetHashCode();


            int hashCarName = obj.name == null ? 0 : obj.name.GetHashCode();

            return hashCardId ^ hashCarName;
        }
    }
}
