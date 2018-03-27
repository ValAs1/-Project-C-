using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Տպել ամենափոքր քառանիշ թիվը, որը 26-ով բազմապատկելիս դառնում է բնական թվի քառակուսի։

            int b;
            for (int i = 1000; i <= 9999; i++)
            {
                b = i * 14;
                if (Math.Sqrt(b) % 1 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
