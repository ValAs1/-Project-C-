using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a__tiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //ներմուծել   1 թիվ
            Console.WriteLine("Nermwucel   tiv");
            Console.Write("a =  ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Պարզել ներմուծված թիվը զու՞յգ է, թե՞ կենտ։
            Console.WriteLine("nermucvac   tiv@  zuyg  e te  kent ");
            string z = (a % 2 == 0) ? "true" : "false";
            Console.WriteLine(z);
            //Պարզել ներմուծված թիվը արդյոք բաժանվու՞մ է առանց մնացորդի 5-ի վրա։
            Console.WriteLine("nermucvac tiv@  bajanvum  e   aranc  mnacord  5-i ");
            string z1 = (a % 5 == 0) ? "true" : "false";
            Console.WriteLine(z1);
            // Ներմուծված թիվը բազմապատկել 2-ով, եթե այն զու՞յգ է և առանց մնացորդի բաժանվու՞մ է 3-ի վրա։
            Console.WriteLine("bazmapatkel 2-ov ete  zuyg e  ev aranc  mnacord bajanvum e 3-i");
            string z2 = (a % 2 == 0) & (a % 3 == 0) ? $"{a * 2}" : "false";
            Console.WriteLine(z2);
            // Ներմուծված թիվը բազմապատկել 2-ով, եթե այն կենտ է կամ առանց մնացորդի բաժանվում է 3-ի վրա։
            Console.WriteLine("bazmapatkel 2-ov ete  kent e kam aranc  mnacord bajanvum e 3-i");
            string z3 = (a % 2 != 0) | (a % 3 == 0) ? $"{a * 2}" : "false";
            Console.WriteLine(z3);




            Console.ReadLine();
        }
    }
}
