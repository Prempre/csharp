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
            _002_Indexer d = new _002_Indexer(15);
            char c;

            c = d[0];  // c = 'A'
            Console.WriteLine("Result of 0: {0}", c);
            c = d[3];  // c = 'D'
            Console.WriteLine("Result of 3: {0}", c);
            c = d[10]; // c = 'K'
            Console.WriteLine("Result of 10: {0}", c);
            c = d[14]; // c = 'O'
            Console.WriteLine("Result of 14: {0}", c);
            c = d[15]; // c = 'A' - access attempt beyond limits
            Console.WriteLine("Result of 15: {0}", c);
            c = d[30]; // c = 'A' - access attempt beyond limits
            Console.WriteLine("Result of 30: {0}", c);
            c = d[50]; // c = 'A' - access attempt beyond limits
            Console.WriteLine("Result of 50: {0}", c);
            d[0] = 'Z';  // c = 'A'
            c = d[0];
            Console.WriteLine("Result of 0: {0}", c);
            Console.ReadKey();

        }
    }


}
