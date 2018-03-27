using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            ////  Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 2 մնացորդ։

            int y = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                    y = y + i;
                }
            }
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
