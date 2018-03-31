using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գրել ծրագիր, որը կգումարի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։


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

             double[] arrayC = new double[n];

            for (int i = 0; i < arrayC.Length; i++)
            {
                arrayC[i] = arrayA[i] + arrayB[i];
            }
            Console.WriteLine("arrayC   zangvac@");
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.Write(arrayC[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
