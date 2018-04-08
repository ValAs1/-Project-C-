using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// 06 Գրել ֆունկցիա, որը արգումենտում փոխանցված թվային զանգվածը էլեմենտ առ
            //  էլեմենտ կբազմապատկի(կգումարի) արգումենտում փոխանցված թվով։

            
            Console.WriteLine("nermucel bnakan tiv ");
            Console.Write("K=");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            double[] arrayA = new double[n];

            Console.WriteLine("nermucel a zangvaci  tarer@");
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = double.Parse(Console.ReadLine());
            }

            
            arrayB(arrayA, n, k);
            arrayC(arrayA, n, k);
            Console.ReadLine();
        }

        static void arrayB(double[] arrayA, int n, int k)
        {
            double[] arrayB = new double[n];

            for (int i = 0; i < arrayB.Length; i++)
            {
                arrayB[i] = arrayA[i] + k;
            }
            Console.WriteLine(" array[i]+B zangvacner@");
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write(arrayB[i] + ", ");
            }
        }
        static void arrayC(double[] arrayA,  int n, int k)
        {
            double[] arrayC = new double[n];

            for (int i = 0; i < arrayC.Length; i++)
            {
                arrayC[i] = arrayA[i] * k;
            }
            Console.WriteLine("\narrat[i] * B  zangvacner@");
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.Write(arrayC[i] + ", ");
            }
        }
    }
}
