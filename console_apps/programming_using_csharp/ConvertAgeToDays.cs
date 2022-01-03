
/*  Write a program that asks the user to enter their age in years as input (assume that the user enters a positive
    integer) and calculates and prints how old the user is in terms of days. Assume that there are 365 days in a
    year. For example: if the user enters
*/

using System;

namespace ConsoleApps
{
    public class ConvertAgeToDays
    {
        private int age;
        public int Age;

        int getUserInput(){

            Console.Write("What is your age?  Enter a number: ");
            int.TryParse(Console.ReadLine(), out age); 
            return 0;
        }

        public int AgeToDays(){
            int age = getUserInput();

            if(age > 0){
                Age = age * 360;
            }else{
                Console.WriteLine("Enter a valid age!");
            }

            return Age;
        }
    }

}