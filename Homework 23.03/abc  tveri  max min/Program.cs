using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc__tveri__max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            //ներմուծել   երեք  թիվ
            Console.WriteLine("Nermwucel  3  tiv");
            Console.Write("a =  ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            //Գտնել երեք թվերից մեծագույնը
            if (a != b & b != c)
            {
                Console.WriteLine("ereq  tveric  mecaguynn  e");
                string x = (a > b) & (a > c) ? $"{a}" : (b > a) & (b > c) ? $"{b}" : $"{c}";
                Console.WriteLine(x);
                ////Գտնել երեք թվերից փոքրագույնը
                Console.WriteLine("ereq  tveric  poqraguynn  e");
                string x1 = (a < b) & (a < c) ? $"{a}" : (b < a) & (b < c) ? $"{b}" : $"{c}";
                Console.WriteLine(x1);

                string a1 = Convert.ToString(a);
                string b1 = Convert.ToString(b);
                string c1 = Convert.ToString(c);

                // Արտածել a, b և c կամայական թվերը աճման կարգով։
                string x2 = (x != a1) & (a1 != x1) ? $"{a1}" : (x != b1) & (b1 != x1) ? $"{b1}" : $"{c1}";
                Console.WriteLine("min>>max");
                Console.WriteLine($"{x1},{x2}, {x}");
                //Արտածել a, b և c կամայական թվերը նվազման կարգով։
                Console.WriteLine("max>>min");
                Console.WriteLine($"{x},{x2}, {x1}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}
