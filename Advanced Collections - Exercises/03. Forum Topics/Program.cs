using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();

            while (input != "filter")
            {
                string[] commands = input.Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = commands[0];

                if (!dictionary.ContainsKey(topic))
                {
                    dictionary[topic] = new HashSet<string>();
                }
                for (int i = 1; i < commands.Length; i++)
                {
                    dictionary[topic].Add(commands[i]);
                }
                input = Console.ReadLine();
            }

            string line = Console.ReadLine().ToString(); //read from the console after filtering
            string[] search = line.Split(','); //create new array for the search words
            foreach (var item in dictionary) //for each KVP in the dictionary
            {
                var topic = item.Key;
                var tags = item.Value;
                for (int i = 0; i < search.Length; i++) //iterate over the search array
                {
                    if (item.Value.Contains(search[i])) //if the KVP value contains a word from the search array
                    {
                        Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                    }
                }
            }
        }
    }

}