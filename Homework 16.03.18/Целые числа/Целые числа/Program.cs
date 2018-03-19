using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Целые_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string a = Console.ReadLine();
            double a1 = double.Parse(a);
            Console.Write("b = ");
            string b = Console.ReadLine();
            double b1 = double.Parse(b);
            double x = a1 + b1;
            int x1 = (int)x;
            Console.WriteLine(x1);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
