using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a__b_c____tarber__tver
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

            //Կարտածի դրանցից մեծը, փոքրը,	
            Console.WriteLine("kartaci  Max  ev  Min");
            string max = (a > b & a > c) ? $"{a}" : (b > a & b > c) ? $"{b}" : $"{c}";
            string min = (a < b & a < c) ? $"{a}" : (b < a & b < c) ? $"{b}" : $"{c}";
            Console.WriteLine($"Max - {max}, Min - {min}");

            // Կարտածի true, եթե տրված թվերից գոնե մեկը հավասար է 1֊ի, հակառակ դեպքում՝ false
            Console.WriteLine("kartaci  true,  ete trvac tveric  gone  mek@ havasar e 1-i,  hakarak  depqum  false");
            string x = (a == 1 || b == 1 || c == 1) ? "true" : "false";
            Console.WriteLine(x);

            //Կարտածի true, եթե տրված թվերից երկուսը հավասար են երկուսի
            Console.WriteLine("kartaci  true,  ete trvac tveric  erkus@ havasar en 2-i, ");
            string x1 = ((a == 2 & b == 2) | (a == 2 & c == 2) | (b == 2 & c == 2)) ? "true" : "false";
            Console.WriteLine(x1);

            // Եթե այդպիսի երկարություն ունեցող հատվածներով հնարավոր է կազմել եռանկյունի, կարտածի true, հակառակ դեպքում՝ false
            Console.WriteLine("ete   ayd  hatvacnerov  hnaravor e  kazmel  erankyun, kartaci  true,  hakarak  depqum  false");
            string x2 = (a + b > c) || (b + c > a) || (a + c > b) ? "true" : "false";
            Console.WriteLine(x2);

            //Կարտածի true, եթե տվյալ թվերը  թվաբանական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false
            Console.WriteLine("Kartaci  true, ete tvabanakan  progresia  en  kazmum");
            string x3 = (a == (b + c) / 2) | (b == (a + c) / 2) | (c == (a + b) / 2) ? "true" : "false";
            Console.WriteLine(x3);

            // Կարտածի true, եթե տվյալ թվերը երկրաչափական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false
            Console.WriteLine("Kartaci  true, ete erkrachapakan  progresia  en  kazmum");
            string x4 = (a == Math.Sqrt(b * c)) | (b == Math.Sqrt(a * c)) | (c == Math.Sqrt(a * b)) ? "true" : "false";
            Console.WriteLine(x4);

            //Կարտածի տվյալ թվերը ըստ աճման կարգի
            if (a != b & b != c)
            {
                string a1 = Convert.ToString(a);
                string b1 = Convert.ToString(b);
                string c1 = Convert.ToString(c);
                string x5 = (max != a1) & (a1 != min) ? $"{a1}" : (max != b1) & (b1 != min) ? $"{b1}" : $"{c1}";
                Console.WriteLine("min>>max");
                Console.WriteLine($"{min},{x5}, {max}");
                //Կարտածի տվյալ թվերը ըստ նվազման կարգի
                Console.WriteLine("max>>min");
                Console.WriteLine($"{max},{x5}, {min}");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
