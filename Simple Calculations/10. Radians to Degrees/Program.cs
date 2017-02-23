using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad
{
    class Program
    {
        static void Main(string[] args)
        {
            // rad = ( deg * 180 ) / pi

            var deg = double.Parse(Console.ReadLine());
            var rad = (deg * 180) / Math.PI;
            var result = Math.Round(rad, 1);
            Console.WriteLine(result);
        }
    }
}
