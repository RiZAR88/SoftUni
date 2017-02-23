using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date1000Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateFromConsole = Console.ReadLine();
            var format = "dd-MM-yyyy";

            DateTime dateTime = DateTime.ParseExact(dateFromConsole, format, CultureInfo.InvariantCulture);
            dateTime = dateTime.AddDays(999);
            Console.WriteLine(dateTime.ToString(format));
        }
    }
}