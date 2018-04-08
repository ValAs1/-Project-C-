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
            //////// 02 Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված զանգվածը հակադարձած։


            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("nermucel  zangvaci  tarer@");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
             RArray(array );
           Console.ReadLine();
        }
        static void RArray(int[] array)
        {
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
