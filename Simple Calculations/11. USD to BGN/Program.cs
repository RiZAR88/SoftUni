using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valute
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 USD = 1.79549 BGN.

            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            var result = Math.Round(BGN, 2);
            Console.WriteLine(result);

        }
    }
}
