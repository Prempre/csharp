using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class Degree
    {
        //Properties
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public double Cost { get; set; }
        public List<Course> Courses { get; set; }

        //Constructor
        public Degree(string name, int creditHours) 
        { 
            Name = name; 
            CreditHours = creditHours;
        }
    }
}
