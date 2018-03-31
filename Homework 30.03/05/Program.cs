using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գտնել թվային զանգվածի էլեմենտներից մեծագույնը։

            Console.WriteLine("введите размер массива");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] Array = new double[n];
            Console.WriteLine("введите элементы массива");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = double.Parse(Console.ReadLine());
            }
            double max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }
            Console.Write(" Max - " + max);
            Console.ReadLine();
        }
    }
}
