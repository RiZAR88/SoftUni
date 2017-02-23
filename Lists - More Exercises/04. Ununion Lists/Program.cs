using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                var commandLine = Console.ReadLine().Split().Select(int.Parse).ToList();

                foreach (var num in commandLine)
                {
                    if (primalList.Contains(num))
                    {
                        primalList.Remove(num);
                    }
                    else
                    {
                        primalList.Add(num);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}