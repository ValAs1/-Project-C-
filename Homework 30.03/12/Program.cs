using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Այն  տարրերի   արտադրյալը, որոնց արժեքի  և ինդեքսի   տարբերությունը   դրական   թիվ  է։

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int result = 1;
            for (int i = 0; i < arr.Length-1; i++)
            {
               if(arr[i] -i > 0)
                {
                    result *= arr[i];
                    Console.WriteLine(result);
                }
                
            }
            Console.ReadLine();
        }
    }
}
