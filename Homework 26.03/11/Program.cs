using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Տպել բոլոր երկնիշ թվերի գումարը, որոնք բազմապատիկ են 3 - ի։

            int a = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    a = a + i;
                }
            }
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
