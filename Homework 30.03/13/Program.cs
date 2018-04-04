using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Console.Write("Введите n: ");
            ////int n = int.Parse(Console.ReadLine());
            ////Console.Write("Введите m: ");
            ////int m = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Заполнение матрици:");
            ////int[,] mas = new int[n, m];
            ////for (int i = 0; i < n; ++i)
            ////{
            ////    for (  int j = 0; j < m; ++j)
            ////    {
            ////        mas[i, j] = Convert.ToInt32(Console.ReadLine());
            ////    }
            ////}
            ////Console.WriteLine("Полученная матрица:");
            ////for (int i = 0; i < n; ++i)
            ////{
            ////    for (int j = 0; j < m; ++j)
            ////    {
            ////        Console.Write(mas[i, j] + "\t");
            ////    }
            ////    Console.WriteLine("\n");
            ////}

            int N = 10, M = 10;
            int[,] a = new int[N, M];

            int count = 1;

            for (int i = 0; i < N; i++)
            {
                count = 1;
                for (int j = 0; j < M; j++)
                {
                    if ((count + i) != 10) a[i, j] = (count + i) % M;
                    else a[i, j] = (count + i);
                    count++;
                }

            }


            Console.WriteLine("исходный массив:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
