using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class Teacher : Person
    {
        //Field
        public new static int Instances = 0;

         //Constructors 
        public Teacher(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Instances++;
        }

        //Method to provide information about the student. 
        public void TeacherDetails()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.  I am {Age.ToString()} years old and live at {Address}.");
        }

        public void GradeTest()
        {
            Console.WriteLine($"{FirstName} {LastName} is grading exams.");
        }

    }
}
