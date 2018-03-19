using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string input1 = Console.ReadLine();
            double a = double.Parse(input1);
            Console.Write("b = ");
            string input2 = Console.ReadLine();
            double b = double.Parse(input2);
            double c;
            if (a > b)
            {
                 c = a / b;
            }
            else
            {
                c = b / a;
            }
           
            Console.WriteLine("Max/Min = " + c);
            Console.ReadLine();

        }
    }
}
