using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            ////   Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնք 3-ի բաժանելիս կմնա 1 մնացորդ, իսկ 4-ի բաժանելիս՝ 2 մնացորդ։

            ulong c = 1;
            for (ulong i = 100; i <= 999; i++)
            {
                if (i % 3 != 1 & i % 4 != 2)
                {
                    c = c * i;

                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
