using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Տպել ամենափոքր եռանիշ թիվը, որի քառակուսի արմատը մեծ է տրված n բնական թվից։
            
            Console.Write("n - ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 100; i <= 999; i++)
            {
                if (Math.Sqrt(i) > n)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
