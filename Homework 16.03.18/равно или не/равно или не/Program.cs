using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace равно_или_не
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            Console.Write("b = ");
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            if (a1 == b1)
            {
                Console.WriteLine("a = b,  true");
            }
            else
            {
                Console.WriteLine("a = b,  false");
            }
                Console.ReadLine();
            
        }
    }
}
