using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = Console.ReadLine().Split(' ').ToList();
            listOne.Reverse();

            var first = listOne[0];
            var last = listOne[listOne.Count - 1];

            listOne[0] = last;
            listOne[listOne.Count - 1] = first;

            Console.WriteLine(string.Join(" ", listOne));
        }
    }
}
