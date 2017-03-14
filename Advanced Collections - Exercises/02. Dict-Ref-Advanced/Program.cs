using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            string InputLine = Console.ReadLine();
            while (InputLine != "end")
            {
                string[] inputParams = InputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                int firstValue = -1;
                string currentKey = inputParams[0];
                if (int.TryParse(inputParams[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }
                    for (int i = 0; i < inputParams.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    string otherKey = inputParams[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }
                InputLine = Console.ReadLine();
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0} === {1}", entry.Key, string.Join(", ", entry.Value));
            }

        }
    }
}