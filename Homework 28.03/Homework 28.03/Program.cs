using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //erankyun  c
            Console.Write("n  - ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {

                    ////for (int j = n; j > i; j--)
                    ////{
                    ////    Console.Write("#");
                    ////}
                    ////for (int k = n; k > n - 1; k--)
                    ////{
                    ////    Console.Write("*");
                    ////}
                 Console.Write("#");
                }
                for (int k = n; k > n-1; k--)
                {
                    Console.Write("*");
                }


                //for (int z = n; z > i; z++)
                //{
                //    Console.Write("*");
                //}


                Console.WriteLine();
            }
        

            Console.ReadLine();

        }
    }
}
