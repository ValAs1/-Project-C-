using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_26._03._18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("n -  ");
            int n = int.Parse(Console.ReadLine());

            ////Արտածել 1-ից մինչև n բոլոր ամբողջ թվերը։

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            ////Արտածել 1-ից մինչև n բոլոր ամբողջ զույգ թվերը։

            for (int i = 1; i <= n; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            ////Արտածել 1-ից մինչև n բոլոր ամբողջ կենտ թվերը։

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            ////Հաշվել 1-ից մինչև n բոլոր ամբողջ թվերի գումարը և արտածել այն։

            int x = 0;
            for (int i = 1; i <=n; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);

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
