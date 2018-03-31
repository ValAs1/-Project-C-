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
            //Գրել ծրագիր, որը կպատճենի a զանգվածը b զանգվածի մեջ։

            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] Array = new double[n];

            Console.WriteLine("nermucel  zangvaci  tarer@");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array   zangvac@");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ", ");
            }
            double[] NewArray = new double[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                NewArray[i] = Array[i];
            }
            Console.WriteLine("\nNewArray   zangvac@");
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write(NewArray[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
