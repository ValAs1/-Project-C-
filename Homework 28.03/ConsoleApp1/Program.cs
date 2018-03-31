using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n  - ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    //for (int s = 0; s < n; s++)
                    //{
                    //    Console.Write("*");
                    //}
                }
                else if (0 < i & i < n)
                {
                    for (int j = i - 1; j <= i; j++)
                    {
                        if (j < i)
                        {
                            Console.Write("*");
                        }
                        else if (j == i)
                        {
                            for (int k = 1; k < n - 1; k++)
                            {
                                Console.Write(" ");
                            }
                            for (int v = n - 1; v < n; v++)
                            {
                                Console.Write("*");
                            }
                        }
                    }
                }
                //else if (i == n)
                //{
                //    for (int s = 0; s < n; s++)
                //    {
                //        Console.Write("*");
                //    }
                //}
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
