using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var AdultNumber = int.Parse(Console.ReadLine());
            var StudentsNumber = int.Parse(Console.ReadLine());
            var NightsNumber = int.Parse(Console.ReadLine());
            var SortTransportation = Console.ReadLine();


            var TotalPeople = AdultNumber + StudentsNumber;
            var Hotel = NightsNumber * 82.99;
            var TicketPrice = 0.0;

            if (SortTransportation == "train")
            {
                if (TotalPeople < 50)
                {
                    var Adults = 24.99;
                    var Student = 14.99;
                    TicketPrice = (AdultNumber * Adults + StudentsNumber * Student) * 2;
                }
                else
                {
                    var Adults = 24.99 / 2;
                    var Student = 14.99 / 2;
                    TicketPrice = (AdultNumber * Adults + StudentsNumber * Student) * 2;
                }
            }
            else if (SortTransportation == "bus")
            {
                var Adults = 32.50;
                var Student = 28.50;
                TicketPrice = (AdultNumber * Adults + StudentsNumber * Student) * 2;
            }
            else if (SortTransportation == "boat")
            {
                var Adults = 42.99;
                var Student = 39.99;
                TicketPrice = (AdultNumber * Adults + StudentsNumber * Student) * 2;
            }
            else if (SortTransportation == "airplane")
            {
                var Adults = 70.00;
                var Student = 50.00;
                TicketPrice = (AdultNumber * Adults + StudentsNumber * Student) * 2;
            }
            var comission = (TicketPrice + Hotel) * 0.10;
            var Total = TicketPrice + Hotel + comission;
            Console.WriteLine("{0:F2}", Total);

        }
    }
}