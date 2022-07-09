using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorials
{
    class _002_Indexer
    {
        public char[] A;

        // constructor
        public _002_Indexer(int size)
        {
            if (size > 26) size = 26;
            A = new char[size];
            for (int i = 0; i < A.Length; i++)
                A[i] = (char)((int)'A' + i);
        }

        // implementation of indexer
        public char this[int index]
        {
            get // read at 'index' position
            {
                if ((index >= 0) && (index < A.Length))
                    return A[index];
                else
                    return 'A';
            }
            set // save to 'index' position
            {
                if ((index >= 0) && (index < A.Length))
                    A[index] = value;
            }
        }
    }
}
