using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b_c_d__tver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Տրված են իրարից տարբեր a,b,c,d թվերը, գրեք ծրագիր, որը՝
            Console.WriteLine("Nermucel iraric  tarber a,b,c,d tver");
            Console.Write("a =  ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d = ");
            double d = Convert.ToDouble(Console.ReadLine());

            //Կարտածի դրանցից մեծը, փոքրը,	
            Console.WriteLine("kartaci  Max  ev  Min");
            string max = (a > b & a > c & a > d) ? $"{a}" : (b > a & b > c & b > d) ? $"{b}" : (c > a & c > b & c > d) ? $"{c}" : $"{d}";
            string min = (a < b & a < c & a < d) ? $"{a}" : (b < a & b < c & b < d) ? $"{b}" : (c < a & c < b & c < d) ? $"{c}" : $"{d}";
            Console.WriteLine($"Max - {max}, Min - {min}");

            // Եթե դրանցից գոնե մեկը հավասար է 1-ի, տպել true, հակառակ դեպքում՝ false
            Console.WriteLine("kartaci  true,  ete trvac tveric  gone  mek@ havasar e 1-i,  hakarak  depqum  false");
            string x = (a == 1 || b == 1 || c == 1 || d == 1) ? "true" : "false";
            Console.WriteLine(x);

            //Եթե դրանցից գոնե երկուսը հավասար են 2-ի, տպել true, հակառակ դեպքում՝ false
            Console.WriteLine("kartaci  true,  ete trvac tveric  gone  erkus@  havasar en  2-i,  hakarak  depqum  false");
            string x1 = (a == 2 & b == 2) || (b == 2 & d == 2) || (c == 2 & d == 2) || (a == 2 & c == 2) || (a == 2 & d == 2) || (b == 2 & c == 2) ? "true" : "false";
            Console.WriteLine(x1);

            //Եթե տրված թվերից երկուսի գումարը հավասար է մյուս երկուսի գումարի, կարտածի true, հակառակ դեպքում՝ false
            Console.WriteLine("kartaci  true,  ete trvac tveric  gone  erkus@  havasar en  2-i,  hakarak  depqum  false");
            string x2 = (a + b) == (c + d) ? "true" : "false";
            Console.WriteLine(x2);

            Console.ReadLine();
        }
    }
}
