using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class Student : Person
    {
        //Field
        public new static int Instances = 0;

        //Properties
        public Stack<int> Grades { get; set; }

        //Constructors 
        public Student(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Instances++;
        }
        
        //Method to provide information about the student. 
        public void StudentDetails()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.  I am {Age.ToString()} years old and live at {Address}.");
        }

        public void TakeTest()
        {
            Console.WriteLine($"{FirstName} {LastName} is taking exams.");
        }
   

    }
}
