using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            ulong n = ulong.Parse(Console.ReadLine());

            ////  Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 3 մնացորդ։

            ulong y = 1;
            for (ulong i = 1; i <= 999; i++)
            {
                if (i % n == 3)
                {
                    Console.WriteLine(i);
                    y = y * i;
                }
            }
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
