using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// 01 Ստեղծել երկչափ զանգված, որը կպարունակի 1 - 9 թվերի բազմապատկման աղյուսակը։

           
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write((i + 1) * (j + 1) + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
