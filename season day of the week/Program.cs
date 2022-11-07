using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace season_day_of_the_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(year, month, day);

            if (month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("Зима, ");
            }
            if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Весна, ");
            }
            if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Лето, ");
            }
            else
            {
                Console.Write("Осень, ");
            }
            Console.WriteLine(dt.ToString("dddd"));
            Console.ReadLine();
        }
    }
}
