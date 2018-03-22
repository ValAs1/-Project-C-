using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a__b_c
{
    class Program
    {
        static void Main(string[] args)
        {
            // Տրված են իրարից տարբեր a,b,c թվերը, գրեք ծրագիր, որը՝
            Console.WriteLine("Nermucel iraric  tarber a,b,c tver");
            Console.Write("a =  ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Կարտածի true, եթե տրված թվերից գոնե մեկը հավասար է 1֊ի, հակառակ դեպքում՝ false
            Console.WriteLine("kartaci  true,  ete trvac tveric  gone  mek@ havasar e 1-i,  hakarak  depqum  false");
            string z = (a == 1 || b == 1 || c == 1) ? "true" : "false";
            Console.WriteLine(z);

            //Կարտածի true, եթե տրված թվերից երկուսը հավասար են երկուսի
            Console.WriteLine("kartaci  true,  ete trvac tveric  erkus@ havasar en 2-i, ");
            string x = ((a == 2 & b == 2) | (a == 2 & c == 2) | (b == 2 & c == 2)) ? "true" : "false";
            Console.WriteLine(x);

            // Եթե այդպիսի երկարություն ունեցող հատվածներով հնարավոր է կազմել եռանկյունի, կարտածի true, հակառակ դեպքում՝ false
            Console.WriteLine("ete   ayd  hatvacnerov  hnaravor e  kazmel  erankyun, kartaci  true,  hakarak  depqum  false");
            string y = (a + b > c) || (b + c > a) || (a + c > b) ? "true" : "false";
            Console.WriteLine(y);

            Console.ReadLine();
        }
    } 
}
