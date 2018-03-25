using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayruravor_tasnavor_miavor
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Տրված է եռանիշ թիվ, 
            
            Console.Write("Nermucel  eranish  tiv    ");
            string r = Console.ReadLine();
            int g = int.Parse(r);
            int a = g / 100;                          // hayruravor
            int b = (g - (a * 100)) / 10;             //  tasnavor
            int c = g - (a * 100) - (b * 10);         //   miavor

            //    արտածել true եթե եռանիշ թվի միավորների թվանշանը հավասար է տասնավորների և 
            //    հարյուրավորների թվանշանների գումարին, հակառակ դեպքում՝ false։
            Console.WriteLine("hayruravori   ev   tasnavori  tvanshani  gumar@   havasar  e  miavorin  ");
            string x = (a + b == c) ? "true" : "false";
            Console.WriteLine(x);

            // արտածել true եթե եռանիշ թվի թվանշաների մեջ կան 
            //  իրար հավասար թվանշաններ, հակառակ դեպքոււմ՝ false:
            Console.WriteLine("tvanshanneri   mej   kan  irar  havasar  tver");
            string x1 = (a == b) | (b == c) | (a == c) ? "true" : "false";
            Console.WriteLine(x1);

            //  հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերությանն արժեքը։
            Console.WriteLine("tvanshanneri   mej   kan  irar  havasar  tver");
            double g1 = Convert.ToDouble(g);
            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);
            double x2 = g1 / (a1 + b1 + c1);
            Console.WriteLine(x2);

            // հաշվել և արտածել եռանիշ թվի թվանշաններից մեծագույնի/փոքրագույնի արժեքը։
            Console.WriteLine("ereq  tvanshanneric  mecaguynn  e");
            string x3 = (a > b) & (a > c) ? $"{a}" : (b > a) & (b > c) ? $"{b}" : $"{c}";
            Console.WriteLine(x3);
            Console.WriteLine("ereq  tvanshanneric  poqraguynn  e");
            string x4 = (a < b) & (a < c) ? $"{a}" : (b < a) & (b < c) ? $"{b}" : $"{c}";
            Console.WriteLine(x4);
            Console.ReadLine();
        }
    }
}
