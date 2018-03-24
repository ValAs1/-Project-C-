using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_23._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ներմուծել  երկու  թիվ
            Console.WriteLine("Nermwucel  2  tiv");
            Console.Write("a =  ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());


            ////Գտնել երկու թվերից մեծագույնը
            Console.WriteLine("erku  tveric  mecaguynn  e");
            string x = (a > b) ? $"{a}" : $"{b}";
            Console.WriteLine(x);
            ////Գտնել երկու թվերից փոքրագույնը
            Console.WriteLine("erku  tveric  poqraguynn  e");
            string x1 = (a < b) ? $"{a}" : $"{b}";
            Console.WriteLine(x1);
            Console.ReadLine();



        }
    }
}
