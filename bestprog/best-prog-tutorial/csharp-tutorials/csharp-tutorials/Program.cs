using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Months mn;
            Months mn2;

            mn = Months.January;
            mn2 = mn + 1;

            Console.WriteLine($"{mn} - {mn2}");

            
        }
    }

    enum Months
    {
        January, February, Murch, April, May, Jun, July, August, September, October, November, December
    };

}
