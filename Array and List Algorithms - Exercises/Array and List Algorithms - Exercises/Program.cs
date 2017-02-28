using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var listWords = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] freq = input[i].ToString().Split('.');
                int firstPart = Int32.Parse(freq[0]);
                int secondPart = Int32.Parse(freq[1]);

                var firstChar = (char)(firstPart);
                var secondChar = (char)(secondPart);


                if (firstPart != 0)
                {
                    listWords.Insert(i, firstChar);
                }
                if (secondPart != 0)
                {
                    listWords.Insert(i, secondChar);
                }

            }

            listWords.Reverse();

            Console.WriteLine(string.Join("", listWords));

        }
    }
}