using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelBack = int.Parse(Console.ReadLine());

            var rounds = 0;

            while (building.Count > camelBack)
            {
                building.RemoveAt(0);
                building.RemoveAt(building.Count - 1);
                rounds++;
            }

            if (rounds == 0)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", building));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: {0}", string.Join(" ", building));
            }

        }
    }
}
