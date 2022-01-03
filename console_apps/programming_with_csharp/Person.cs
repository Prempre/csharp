using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class Person
    {
        // Field
        public static int Instances = 0;

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //Constructors 
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Instances++;
        }
        public Person()
        {
            Instances++;
        }


        public override string ToString()
        {
            return "Person: " + FirstName + " " + LastName + ", Age: " + Age.ToString();
        }

    

    }
}
