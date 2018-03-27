using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնց բազմապատիկ չեն 5-ի։

            ulong a = 1;
            for (ulong i = 100; i <= 999; i++)
            {
                if (i % 5 != 0)
                {
                    a = a * i;

                   // Console.WriteLine(i);
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
