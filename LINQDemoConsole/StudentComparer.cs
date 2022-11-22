using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoConsole
{
    // Custom Comparer class with IEqualityComparer<T> implementation
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            //Return TRUE if the values are the SAME
            if (object.ReferenceEquals(x, y))
                return true;

            //If any one of the values is NULL, return FALSE
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                return false;

            //At last, match each property of each object one-by-one to determine euqlity
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            //if (obj == null)
            if (object.ReferenceEquals(obj, null))
                return 0;

            int idHashCode = obj.Id.GetHashCode();  //Way to get hashcode of any value (Inbuilt)
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode ^ nameHashCode;   // ^ - Bitwise Exclusive OR operation
        }
    }
}
