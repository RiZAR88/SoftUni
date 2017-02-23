using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var idealNumberOfDigits = int.MaxValue;

            foreach ( var item in list1)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

        }

        private static object CalculateNumberOfDigits(int item)
        {
            number = Math.Abs(number);
            var numberOfDigits = 0;
            while (number > 0)
            {
                numberOfDigits++;
                number /= 10;
            }
            return numberOfDigits;
            return number;
        }
    }
}
