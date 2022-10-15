using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class Student : IEquatable<Student>
    {
        public int StudentId { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }


        //This properties created after that I need for group join.
        public string StudentName { get; set; }
        public int CategoryId { get; set; }
        public int AddressId { get; internal set; }

        public bool Equals(Student other)
        {
            if (object.ReferenceEquals(other,null))
            {
                return false;
            }

            if (object.ReferenceEquals(other, this))
            {
                return true;
            }

            return StudentId.Equals(other.StudentId) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int idHashCode = StudentId.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }

}
