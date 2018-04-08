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
            //////// 01 Գրել ֆունկցիա, որը կվերադարձնի true, եթե արգումենտում փոխանցված ամբողջ թիվը զույգ է և false՝ եթե կենտ է։

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool res = num( n );
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static bool num( int n)
        {                      
                if (n%2==0)
                {
                    return true;
                }
            return false;
        }
    }
}
