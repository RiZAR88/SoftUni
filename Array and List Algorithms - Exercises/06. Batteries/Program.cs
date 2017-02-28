using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> mAh = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> mili = Console.ReadLine().Split().Select(double.Parse).ToList();
            int hours = int.Parse(Console.ReadLine());

            for (int i = 0; i < mAh.Count; i++)
            {
                double used = mili[i] * hours;
                double left = mAh[i] - used;
                double procent = left / (mAh[i] / 100.0);

                if (left >= 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, left, procent);
                }
                else
                {
                    int dead = (int)(mAh[i] / mili[i]) + 1;
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, dead);
                }
            }
        }
    }
}