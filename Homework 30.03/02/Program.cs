using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Հաշվե թվային զանգվածի էլեմենտների գումարը։

            int[] intArray = { 10, 20, 30, 4, 55, 67, 7, 8, 9, 17 };
            Console.Write("a=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int n1 = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % n == 0)
                {
                    a++;
                }
                if (intArray[i] % n1 == 0)

                {
                    b++;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
