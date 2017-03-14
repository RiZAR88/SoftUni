using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var average = numbers.Average();
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number > average)
                {
                    result.Add(number);
                }
            }
            result.Sort();
            result.Reverse();

            if (result.Count < 1)
            {
                Console.WriteLine("No");
            }

            if (result.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
