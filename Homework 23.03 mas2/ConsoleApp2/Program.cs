using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ներմուծեք շաբաթվա օրերին համապատասխան թիվը, արտածեք համապատասխան օրը՝ 2>երեքշաբթի
            Console.WriteLine("Nermwucel   shabatva  or 1-7 ");
            Console.Write("num  -  ");
            string num = Console.ReadLine();
           int d2 = int.Parse( num);
           switch (d2)
           {  
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.ReadLine();
        } 
    }
}
