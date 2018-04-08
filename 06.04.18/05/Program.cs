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
            //////// 05 Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված երկու թվային
            ////    զանգվածների գումարը(արտադրյալը)։


            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            double[] arrayA = new double[n];

            Console.WriteLine("nermucel a zangvaci  tarer@");
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = double.Parse(Console.ReadLine());
            }

            double[] arrayB = new double[n];

            Console.WriteLine("nermucel b zangvaci  tarer@");
            for (int i = 0; i < arrayB.Length; i++)
            {
                arrayB[i] = double.Parse(Console.ReadLine());
            }
            arrayC(arrayA, arrayB, n);
            arrayCC( arrayA, arrayB, n);
            Console.ReadLine();

        }

        static void arrayC(double[] arrayA, double[] arrayB , int n)
        {
            double[] arrayC = new double[n];

            for (int i = 0; i < arrayC.Length; i++)
            {
                arrayC[i] = arrayA[i] + arrayB[i];
            }
            Console.WriteLine(" A+B zangvacner@");
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.Write(arrayC[i] + ", ");
            }
        }
        static void arrayCC(double[]arrayA, double[] arrayB, int n)
        {
            double[] arrayC = new double[n];

            for (int i = 0; i < arrayC.Length; i++)
            {
                arrayC[i] = arrayA[i] * arrayB[i];
            }
            Console.WriteLine("\nA * B  zangvacner@");
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.Write(arrayC[i] + ", ");
            }
        }
    }
}
