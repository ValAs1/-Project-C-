using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21._03._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hayk's salary");
            string hayk = Console.ReadLine();
            double h = double.Parse(hayk);
            Console.Write("Vahan's salary");
            string vahan = Console.ReadLine();
            double v = double.Parse(vahan);
            Console.Write("Arsen's salary");
            string arsen = Console.ReadLine();
            double a = double.Parse(arsen);
            if(h>v & h>a)
            {
                if (v >a)
                {
                    Console.WriteLine(h - a);
                }
                else
                {
                    Console.WriteLine(h-v);
                }
            }
            else if(v>h & v>a)
            {
                if (h>a)
                {
                    Console.WriteLine(v - a);
                }
                else
                {
                    Console.WriteLine(v - h);
                }
            }
            else if(a>h & a>v)
            {
                if (h>v)
                {
                    Console.WriteLine(a - h);
                }
                else
                {
                    Console.WriteLine(a-v);
                }
            }
            
            Console.ReadLine();

        }
    }
}
