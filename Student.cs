using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionLior
{
    internal class Student
    {
        

        public string Name { get; set; }
        public int Id { get; set; }

        public Dictionary<Courses, int> Grades { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
