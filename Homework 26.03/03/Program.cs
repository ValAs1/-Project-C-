using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n -  ");
            int n = int.Parse(Console.ReadLine());

            ////Արտածել 1-ից մինչև n բոլոր ամբողջ կենտ թվերը։

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
