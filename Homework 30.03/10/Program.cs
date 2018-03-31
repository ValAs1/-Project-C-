using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ունենք ամբողջ թվերի զանգված, դասավորոլ զանգվածի տարրերը ըստ աճման կարգի


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

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int a = array[j];
                        array[j] = array[i];
                        array[i] = a;
                    }
                }
            }
            Console.WriteLine("\nzangvac@   ajman   kargov");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
