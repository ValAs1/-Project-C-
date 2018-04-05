using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// 02 Ստեղծել երկչափ քառակուսաձև զանգված, որի անկյունագծի էլեմենտները հավասար կլինեն 1 - ի, իսկ մնացածները՝ 0 - ի։

            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i==j)
                    {
                        arr[i, j] = 1;
                        Console.Write(arr[i, j] + "\t");
                       // Console.Write(1 + "\t");
                    }
                    else
                    {
                        arr[i, j] = 0;
                        Console.Write(arr[i, j] + "\t"); ;
                       // Console.Write(0+ "\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
