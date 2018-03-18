using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прямоугольник_P_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string input1 = Console.ReadLine();
            double a1 = double.Parse(input1);
            Console.Write("b = ");
            string input2 = Console.ReadLine();
            double b1 = double.Parse(input2);
            double p = 2 * a1 + 2 * b1;
            double s = a1 * b1;
            Console.WriteLine("P = " + p);
            Console.WriteLine("S = " + s);
            Console.ReadLine();
        }
    }
}
