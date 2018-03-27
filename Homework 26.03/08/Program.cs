using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            ulong n = ulong.Parse(Console.ReadLine());

            ////  Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։
            
            ulong y = 1;
            for (ulong i = 1; i < 1000; i++)
            {
                if (i % n == 0)
                {
                    y = y * i;
                }
            }
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
