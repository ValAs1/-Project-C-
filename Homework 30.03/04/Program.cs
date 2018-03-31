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
            //Գտնել թվային զանգվածի էլեմենտներից փոքրագույնը։

            Console.WriteLine("введите размер массива");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] Array = new double[n];
            Console.WriteLine("введите элементы массива");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = double.Parse(Console.ReadLine());
            }
            double min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if(min>Array[i])
                {
                    min = Array[i];
                }
            }
            Console.Write(" Min - " + min);
            Console.ReadLine();
        }
    }
}
