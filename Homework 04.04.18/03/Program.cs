using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// 03 Ստեղծել երկչափ քառակուսաձև զանգված, որի զույգ համարով տողերի էլեմենտները հավասար կլինեն 1 - ի, իսկ կենտերը՝ 0 - ի։

            int[,] arr = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i  % 2 == 0)
                    {
                        arr[i, j] = 1;
                        Console.Write(arr[i, j] +"\t");

                    }
                    else
                    {
                        arr[i, j] = 0;
                        Console.Write(arr[i, j] +"\t"); ;
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
