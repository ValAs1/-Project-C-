using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Длина_окружности_круга
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус круга r = ");
            string input = Console.ReadLine();
            double r = double.Parse(input);
            double pi = Math.PI;
            const int a = 2;
            double a1 = a;
            double c = a1 * pi * r;
            Console.WriteLine("C =  " + c + " (см)");
            Console.ReadLine();
        }
    }
}
