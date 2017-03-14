using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var resultDictionary = new SortedDictionary<string, long>();

            while (!input[0].Equals("Over"))
            {
                string firstParam = input[0];
                string secondParam = input[1];

                var phoneNumber = 0L;
                if (long.TryParse(firstParam, out phoneNumber))
                {
                    resultDictionary[secondParam] = phoneNumber;
                }
                else if (long.TryParse(secondParam, out phoneNumber))
                {
                    resultDictionary[firstParam] = phoneNumber;
                }

                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var result in resultDictionary)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}