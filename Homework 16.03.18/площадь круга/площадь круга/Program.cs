using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace площадь_круга
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("(см)  r = ");
            string input = Console.ReadLine();
            double r = double.Parse(input);
            const double pi = Math.PI;
            double s = pi * r * r ;
            Console.WriteLine(" S = " + s + "(см^2)");
            Console.ReadLine();
        }
    }
}
