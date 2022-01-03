using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class Course
    {
 
        //Properties
        public string Name { get; set; }
        public int Credit { get; set; }
        public double Cost { get; set; }
        public string OfferDuringSummer { get; set; }
        public List<Teacher> Teachers  { get; set; }
        public ArrayList Students { get; set; }

        //Constructors
        public Course(string name, int credit)
        { 
            Name = name;
            Credit = credit;
        }

        public void ListStudents()
        {
            if (Students.Count != 0)
            {
                foreach(Student s in Students)
                {
                    Console.WriteLine("Student: {0}, {1}", s.FirstName, s.LastName);
                }
            }
            else
            {
                Console.WriteLine("No students are added to the course as yet");
            }
        }

    }
}
