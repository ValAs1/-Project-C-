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
            ////  Տպել ամենամեծ քառանիշ թիվը, որը 14-ով բազմապատկելիս դառնում է բնական թվի քառակուսի։

            int b;
            for (int i = 9999 - 1; i >= 1000; i--)
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
