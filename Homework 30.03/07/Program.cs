using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գրել ծրագիր, որը կհակադարձի զանգվածը։


            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("nermucel  zangvaci  tarer@");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array   zangvac@");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Array.Reverse(array);

            Console.WriteLine("\nArray revers  zangvac@");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
