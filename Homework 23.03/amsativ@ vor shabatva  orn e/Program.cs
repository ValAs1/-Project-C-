using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amsativ__vor_shabatva__orn_e
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ներմուծեք ամսաթիվը, արտածեք թե ամսվա որ շաբաթվա օրն է դա՝ 15>3
            //Console.WriteLine("Nermwucel   shabatva  or 1-7 ");
            //Console.Write("a =  ");
            //string a = Console.ReadLine();
            ////int x = int.Parse(a);
            //double x = Convert.ToDouble(a);
            //DateTime d = DateTime.FromOADate(x);

            // DateTime d = DateTime.Now;
            // Console.WriteLine(d.Date);   //amsativ
            // Console.WriteLine(d.Day);  //amsva   or
            //Console.WriteLine(d.DayOfWeek);  //shabatva  or




            //Console.WriteLine(d.Date);   //amsativ
            //Console.WriteLine(d.Day);  //amsva   or
            //  Console.WriteLine(d.DayOfWeek);  //shabatva  or


            //Console.WriteLine(d.Date);   //amsativ
            //Console.WriteLine(d.Day);  //amsva   or
            //Console.WriteLine(d.DayOfWeek);  //shabatva  or
            //Console.WriteLine(d.DayOfYear);  //tarva  or
            //Console.WriteLine(d.TimeOfDay);  //jam
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToUniversalTime());

            //Console.WriteLine("Using the Gregorian calendar:");
            //Console.WriteLine("Date: {0:d}", d);
            //Console.WriteLine("Year: {0}", d.Year);
            //Console.WriteLine("Leap year: {0}", DateTime.IsLeapYear(d.Year));


            Console.WriteLine("Тип System.DateTime:");

            Console.WriteLine("Диапазон значений от {0} до {1}",

                                        DateTime.MinValue, DateTime.MaxValue);

            DateTime d1 = DateTime.Now;

            Console.WriteLine("Текущие дата и время: {0}", d1.ToString());

            Console.WriteLine("Тики: {0}", d1.Ticks);

            Console.WriteLine("День недели: {0}", d1.DayOfWeek);

            Console.WriteLine("Номер дня в году {0}", d1.DayOfYear);

            Console.WriteLine("ToLongDateString: {0}", d1.ToLongDateString());

            Console.WriteLine("ToShortDateString; {0}", d1.ToShortDateString());

            Console.WriteLine("ToLongTimeString: {0}", d1.ToLongTimeString());

            Console.WriteLine("ToShortTimeString: {0}", d1.ToShortTimeString());

            Console.ReadLine();

            //Console.ReadLine();


        }
    }
}
