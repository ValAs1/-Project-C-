using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Հաշվել 1-ից մինչև 15 բոլոր ամբողջ թվերի արտադրյալը և արտածել այն։

            int x1 = 1;
            for (int i = 1; i <= 15; i++)
            {
                x1 = x1 * i;
            }
            Console.WriteLine(x1);

            Console.ReadLine();
        }
    }
}
