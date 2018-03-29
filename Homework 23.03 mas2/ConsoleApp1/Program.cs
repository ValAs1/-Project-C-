using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ներմուծեք շաբաթվա օրերին համապատասխան թիվը, արտածեք համապատասխան օրը՝ 2>երեքշաբթի
            Console.WriteLine("Nermwucel   shabatva  or 1-7 ");

            Console.Write("a =  ");
            string x= Console.ReadLine();
            // int x = int.Parse(num);
            
            int  a, b, c, d;
           string  k = x.Split (  out a, out b, out c, out d);

            
                Console.WriteLine(k);
                Console.WriteLine( b);
                //Console.WriteLine(c);

                //Console.WriteLine(d);
            

            //int digits = (int)Math.Log10(x); // 9

            //Console.WriteLine(digits);

            //int i = int.Parse(Console.ReadLine());
            //int digits = (int)Math.Log10(i);
            //i = i % (int)Math.Pow(10, digits);
            //Console.WriteLine(i);

            ////int F = 546830715;

            ////for (int i = 0, Pw = (int)Math.Log10(F); i <= Pw; i++)
            ////{
            ////    int u = F / (int)Math.Pow(10, Pw - i);
            ////    u = u - (u / 10 * 10);
            ////    Console.WriteLine(u);
            ////}


            //double x = Convert.ToDouble(a);
            //DateTime d = DateTime.FromOADate(x);



            //  Console.WriteLine(d.DayOfWeek);  //shabatva  or



            //Console.WriteLine(d.Date);   //amsativ
            //Console.WriteLine(d.Day);  //amsva   or
            //Console.WriteLine(d.DayOfWeek);  //shabatva  or
            //Console.WriteLine(d.DayOfYear);  //tarva  or
            //Console.WriteLine(d.TimeOfDay);  //jam
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToUniversalTime());
            //Console.WriteLine(d.Month);
            //Console.WriteLine(d.Minute);

            Console.ReadLine();

        }
    }
}
