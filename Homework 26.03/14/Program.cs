using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնց բազմապատիկ չեն 2-ի և 3-ի։

            ulong b = 1;
            for (ulong i = 100; i <= 999; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    b = b * i;

                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
