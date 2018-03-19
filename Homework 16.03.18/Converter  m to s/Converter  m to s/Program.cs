using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter__m_to_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("вводите минуту - ");
            string input = Console.ReadLine();
            double t = double.Parse(input);
            const double a = 60;
            double t2 = t * a;
            Console.WriteLine(t2 + "  секунд");
            Console.ReadLine();

        }
    }
}
