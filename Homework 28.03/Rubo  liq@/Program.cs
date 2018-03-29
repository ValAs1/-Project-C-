using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubo__liq_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n  - ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else if (j == i)
                    {
                        Console.Write("*");
                    }
                }

                for (int k = 1; k < i; k++)

                {
                    Console.Write("*");
                }

                for (int h = 1; h <= i - 1; h++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int v = 2; v <= n; v++)
            {
                for (int j = 1; j <= v; j++)
                {
                    if (j < v)
                    {
                        Console.Write(" ");
                    }
                    else if (j == v)
                    {
                        Console.Write("*");
                    }
                }

                for (int k = n; k > v; k--)

                {
                    Console.Write("*");
                }

                for (int h = n - 2; h >= v - 1; h--)
                {
                    Console.Write("*");
                    
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
