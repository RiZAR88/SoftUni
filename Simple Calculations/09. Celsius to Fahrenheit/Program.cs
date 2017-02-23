using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            // C  x  9/5 + 32 = F

            var C = double.Parse(Console.ReadLine());
            var F = C * 9 / 5 + 32;
            var result = Math.Round(F, 2);
            Console.WriteLine(result);
        }
    }
}
