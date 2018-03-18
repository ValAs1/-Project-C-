using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace процент_a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);
            double a1 = a;
            
            Console.Write("b = ");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);
            double b1 = b;
                       
            double p =  100 * a1 / b1;
           

            Console.WriteLine(p + " %");

            Console.ReadLine();

        }
    }
}
