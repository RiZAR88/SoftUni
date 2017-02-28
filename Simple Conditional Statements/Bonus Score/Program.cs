using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (a <= 100)
            {
                bonus += 5;
            }
            else if (a <= 1000)
            {
                bonus += a * 0.2;
            }
            else if (a > 1000)
            {
                bonus += a * 0.1;
            }
            if (a % 2 == 0)
            {
                bonus += 1;
            }
            else if (a % 5 == 0)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(a + bonus);
        }
    }
}
