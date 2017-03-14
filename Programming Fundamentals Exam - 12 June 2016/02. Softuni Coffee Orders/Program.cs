using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var Order = int.Parse(Console.ReadLine());
            var TotalPrice = 0.0;


            for (int i = 0; i < Order; i++)
            {
                var Price = float.Parse(Console.ReadLine());

                string d = Console.ReadLine();
                string pattern = "d/M/yyyy";
                DateTime date = new DateTime();
                DateTime.TryParseExact(d, pattern, null, DateTimeStyles.None, out date);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var Capsule = int.Parse(Console.ReadLine());


                var pricesPerCoffe = ((daysInMonth * Capsule) * Price);

                TotalPrice += pricesPerCoffe;
                Console.WriteLine("The price for the coffee is: ${0:f2}", pricesPerCoffe);

            }
            Console.WriteLine("Total: ${0:f2}" , TotalPrice);
        }
    }
}
