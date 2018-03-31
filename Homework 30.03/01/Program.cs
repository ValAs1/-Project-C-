using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ստեղծել զանգված, որի էլեմենտները կպարունակեն 1-ից մինչև n ամբողջ թվերի քառակուսիները։

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            int a = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] =(int)Math.Pow(a,2);
                a++;
                Console.Write(Array[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
