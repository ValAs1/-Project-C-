using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трехзначное_число
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ներմուծեք եռանիշ թիվ և տպեք դրա նիշերը՝ առանձին-առանձին
            Console.Write("введите трехзначное число ");
            string r = Console.ReadLine();
            int g = int.Parse(r);
            int a = g / 100;
            int b = (g -(a * 100))/10;
            int c = g - (a * 100) - (b * 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
               
        }
    }
    
}
