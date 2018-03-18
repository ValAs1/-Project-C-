using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSurname
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Volodya";
            string surname = "Asatryan";
            string age = "26";

            Console.WriteLine("Имя - " + name);
            Console.WriteLine("Фамилия - " + surname);
            Console.WriteLine("возраст - " + age);
            Console.WriteLine($"Имя -{name}, Фамилия - {surname}, возраст - {age}, ");
            Console.ReadLine();
        }
    }
}
