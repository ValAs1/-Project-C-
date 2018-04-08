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
            //////// 04 Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված թվային զանգվածի ամենամեծ(ամենափոքր) էլեմենտի ինդեքսը։

            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("nermucel  zangvaci  tarer@");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());


            }
            Ind(array);
           
            Console.ReadLine();
        }
        static void Ind(int[] array)
        {
            int max = array[0];
            int mx=0;
            int min = array[0];
            int mn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max <array[i])
                {
                    max = array[i];
                    mx = i;
                }
                if (min > array[i])
                {
                    min = array[i];
                    mn = i;
                }
            }
            Console.Write("MaxInd - " + mx);
            Console.Write("\nMinInd - " + mn);
        }
    }
}
