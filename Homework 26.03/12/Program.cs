using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Տպել բոլոր երկնիշ թվերի արտադրյալը, որոնք բազմապատիկ են 3-ի և 5-ի։

            ulong b = 1;
            for (ulong i = 10; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    b = b * i;
                  //  Console.WriteLine(i);
                }
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
