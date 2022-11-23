using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoConsole
{
    //A self-comparing class
    //public class Student : IEquatable<Student>
    //{
    //    //public int StudentId { get; set; }
    //    //public string StudentFullName { get; set; }
    //    //public string StudentEmail { get; set; }

    //    //public int Marks { get; set; }
    //    //public List<Subject> Subject { get; set; }

    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public bool Equals(Student? other)
    //    {
    //        if (object.ReferenceEquals(other, null))
    //            return false;

    //        if (object.ReferenceEquals(this, other))
    //            return true;

    //        return Id.Equals(other.Id) && Name.Equals(other.Name);
    //    }

    //    public override int GetHashCode()
    //    {
    //        int idHashCode = Id.GetHashCode();
    //        int nameHashCode = Name.GetHashCode();

    //        return idHashCode ^ nameHashCode;
    //    }
    //}

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        //public int AddressId { get; set; }
    }
}
