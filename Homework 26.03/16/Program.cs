using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Տպել ամենափոքր եռանիշ թիվը, որը 16-ով բազմապատկելիս դառնում է բնական թվի քառակուսի։

            int b;
            for (int i = 100; i <= 999; i++)
            {
                b = i * 16;
                if (Math.Sqrt(b)%1 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
    
}
