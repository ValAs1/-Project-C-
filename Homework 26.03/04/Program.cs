using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("n -  ");
            int n = int.Parse(Console.ReadLine());
            
            ////Հաշվել 1-ից մինչև n բոլոր ամբողջ թվերի գումարը և արտածել այն։

            int x = 0;
            for (int i = 1; i <= n; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);

             Console.ReadLine();
        }
    }
}
