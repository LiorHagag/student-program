using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SqlConnectionLior;
namespace SqlConnectionLior
{
    class Courses
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Student> Students { get; set; }
        public List<Courses> courseslist { get; set; }
        public override string ToString()
        {
            return Name;
        }
    
    }
}
