using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__999
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());

            //// Տպել 1 - 999 միջակայքի այն թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։

            //int x = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % n == 0)
            //    {
            //        x = x + i;
            //    }
            //}
            //Console.WriteLine(x);

            ////  Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։
          ulong n1 = 45;
            ulong y = 1;
            //for (long i = 1; i < 1000; i++)
            //{
            //    if (i % n1 == 0)
            //    {
            //        y = y * i;
            //    }
            //}
            //Console.WriteLine(y);
            ulong  i = 1;
            while(i < 1000)
            {
                if (i % n1 == 0)
                {
                    y = y * i;
                }
               
                i++;
            }
            Console.WriteLine(y);

            ////  Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 2 մնացորդ։

            //int y1 = 1;
            //for (int i = 1; i < 999; i++)
            //{
            //    if (i % n == 2)
            //    {
            //        y1 = y1 * i;
            //    }
            //}
            //Console.WriteLine(y1);


            Console.ReadLine();

        }
    }
}
