using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace день_недели
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nermwucel   shabatva  or 1-7 ");
            Console.Write("a =  ");
           string  a = Console.ReadLine();
            //int x = int.Parse(a);
            double x = Convert.ToDouble(a);
            DateTime d = DateTime.FromOADate(x);
            //if (x == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (x == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (x == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (x == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //else if (x == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //else if (x == 6)
            //{
            //    Console.WriteLine("Saturday");
            //}
            //else
            //{
            //    Console.WriteLine("Sunday");
            //}


            //DateTime d = DateTime.Now;
            //Console.WriteLine(d.Date);   //amsativ
            //Console.WriteLine(d.Day);  //amsva   or
            //Console.WriteLine(d.DayOfWeek);  //shabatva  or


            Console.WriteLine(d.Date);   //amsativ
            Console.WriteLine(d.Day);  //amsva   or
            Console.WriteLine(d.DayOfWeek);  //shabatva  or

            Console.ReadLine();
        }
    }
}
