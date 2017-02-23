using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = float.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine(area);
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine(perimeter);

        }
    }
}
