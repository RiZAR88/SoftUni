using System;
using System.Linq;

namespace distinctList
{
    class distinctList
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList()));
        }
    }
}
