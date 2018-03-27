using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_____b
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  Հաշվել a-ից մինչև b բոլոր ամբողջ թվերի գումարը և արտածել այն։
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = a; i <= b; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
