using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate three Student objects.
            Student student1 = new Student("Clinton", "Bartley")
            {
                Address = "10200 Gand Blvd N, Saint Petersburg FL 33702",
                Age = 39,                
            };
            // Create Stack<int> object to hold the grades that will be added to the Student.Grades stack<int>
            Stack<int> Grades1 = new Stack<int>(5);
            Grades1.Push(89);
            Grades1.Push(79);
            Grades1.Push(86);
            Grades1.Push(77);
            Grades1.Push(69);
            // Add the stack<int> list with the 5 grades to Student.Grades  .
            student1.Grades = Grades1;

            Student student2 = new Student("Greg","Morris")
            {
                Address = "127 Lee Height Fort Myers FL 11223",
                Age = 40,
            };
            // Create Stack<int> object to hold the grades that will be added to the Student.Grades stack<int>
            Stack<int> Grades2 = new Stack<int>(5);
            Grades1.Push(69);
            Grades1.Push(78);
            Grades1.Push(80);
            Grades1.Push(97);
            Grades1.Push(65);
            // Add the stack<int> list with the 5 grades to Student.Grades  .
            student2.Grades = Grades2;

            Student student3 = new Student("Wayne","Williams")
            {
                Address = "662 Cho Housing Scheme Port Moran, Saint Thomas, Jamaica",
                Age = 40,
                // Add 5 grades to the the Stack in the each Student object.
            };

            // Create Stack<int> object to hold the grades that will be added to the Student.Grades stack<int>
            Stack<int> Grades3 = new Stack<int>(5);
            Grades1.Push(83);
            Grades1.Push(70);
            Grades1.Push(88);
            Grades1.Push(93);
            Grades1.Push(95);
            // Add the stack<int> list with the 5 grades to Student.Grades  .
            student3.Grades = Grades3;

            // Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Charlie","Brown")
            {
                Address = " 908 Copper Road Hallandale FL 33113",
                Age = 44
            };

            // Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#", 3)
            {
                Cost = 983.56,
                OfferDuringSummer = "Yes",

                // Add the three Student objects to the Students ArrayList inside the Course object.
                Students = new ArrayList {student1, student2, student3},

                // Add that Teacher object to your Course object
                Teachers = new List<Teacher> { teacher }

            };    

            //Call the ListStudent method in Course Object instance
            course.ListStudents();

        }
    }
}
