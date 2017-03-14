using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, int>();
            while (input[0] != "end")
            {
                var name = input[0];
                var isValue = Regex.IsMatch(input[1], @"^\d+$");

                if (isValue)
                {
                    var value = int.Parse(input[1]);
                    dictionary[name] = value;
                }
                else
                {
                    var secondName = input[1];
                    if (dictionary.ContainsKey(secondName))
                    {
                        var value = 0;
                        dictionary.TryGetValue(secondName, out value);
                        dictionary[name] = value;
                    }
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} === {pair.Value}");
            }
        }
    }
}
