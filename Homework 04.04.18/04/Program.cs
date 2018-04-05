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
            ////// 04    Ստեղծել երկչափ քառակուսաձև զանգված, որի էլեմենտները հավասար կլինեն 1 - ի, 
            //            եթե էլեմենտի ինդեքսների գումարը զույգ է, իսկ մնացածները՝ 0 - ի։

            int[,] arr = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        arr[i, j] = 1;
                        Console.Write(arr[i, j] + "\t");

                    }
                    else
                    {
                        arr[i, j] = 0;
                        Console.Write(arr[i, j] + "\t"); ;
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
