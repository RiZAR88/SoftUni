using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.Keys.Contains(double.Parse(input[i])))
                {
                    numbers[double.Parse(input[i])] = 1;
                }
                else
                {
                    numbers[double.Parse(input[i])]++;
                }
            }

            foreach (var a in numbers)
            {
                Console.WriteLine(a.Key + " -> " + a.Value);
            }
        }
    }
