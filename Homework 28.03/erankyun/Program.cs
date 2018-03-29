using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erankyun
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("n  - ");
            int n = int.Parse(Console.ReadLine());

            ////  erankyun  a

            for (int i = 0; i <= n; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------");
            ////erankyun   b

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < n-i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------");
            ////  erankyun  c


            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------");
            ////erankyun  d

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = n; k > n - i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }


    }
}
