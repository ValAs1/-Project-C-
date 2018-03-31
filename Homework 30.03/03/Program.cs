using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Հաշվել թվային զանգվածի էլեմենտների արտադրյալը։

            Console.WriteLine("введите размер массива");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] Array = new double[n];
            Console.WriteLine("введите элементы массива");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = double.Parse(Console.ReadLine());
            }
            double result = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                result *= Array[i];
            }
            Console.Write("Результат умножения элементов массива - " + result);
            Console.ReadLine();
        }
    }
}
