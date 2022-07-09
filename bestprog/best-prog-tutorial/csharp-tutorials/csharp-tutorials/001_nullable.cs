using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorials
{
    class _001_Nullable
    {
       public void Make_Nullable()
        {
            // 1. Declaring a variable of type System.Nullable<int>
            Nullable<int> d; // could be like this: int? d;

            // 2. Declaring a variable of type System.Nullable<double>
            double? t = null;

            // 3. Demonstration of the correct assignment
            // type int?
            d = null;
            int d2; // it is not Nullable-type

            if (d == null)
                d2 = 0;
            else
                d2 = d.Value;

            // type double?
            t = -10.55;
            double t2;
            if (t != null)
                t2 = t.Value;
            else
                t2 = 0.0;

            // 4. Property HasValue
            // Checking, is the variable t equal to null
            t = null;
            if (t.HasValue)
                Console.WriteLine("t != null");
            else
                Console.WriteLine("t == null");

            // 5. Method GetValueOrDefault() - You do not need to do the checking for null
            t = null;
            double t3 = t.GetValueOrDefault(); // t3 = 0 - default value

            Console.WriteLine("d2 + {0}", d2);
            Console.WriteLine("t2 + {0}", t2);
            Console.WriteLine("t3 + {0}", t3);

        }


    }
}
