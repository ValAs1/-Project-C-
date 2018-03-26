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
            string a = Console.ReadLine();
            //int x = int.Parse(a);
            double x = Convert.ToDouble(a);
            DateTime d = DateTime.FromOADate(x);
          


          //  Console.WriteLine(d.DayOfWeek);  //shabatva  or



            Console.WriteLine(d.Date);   //amsativ
            Console.WriteLine(d.Day);  //amsva   or
            Console.WriteLine(d.DayOfWeek);  //shabatva  or
            Console.WriteLine(d.DayOfYear);  //tarva  or
            Console.WriteLine(d.TimeOfDay);  //jam
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToUniversalTime());
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Minute);

            Console.ReadLine();

        }
    }
}
