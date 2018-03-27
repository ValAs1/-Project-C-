using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            //// Տպել 1 - 999 միջակայքի այն թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։

            int x = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % n == 0)
                {
                    x = x + i;
                }
            }
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
