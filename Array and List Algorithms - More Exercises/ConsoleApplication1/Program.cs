using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> result = new List<int> { 1, 2, 12, 15, 16, 17 };
            List<int> sequenceForInsertInResult = new List<int> { 13, 14, 15, 16, 17, 18, 19 };

            int count = 0;
            int nextNum = 0;

            for (int l = 0; l < result.Count; l++)
            {
                if (sequenceForInsertInResult[0] <= result[l])
                {
                    nextNum = result[l];
                    break;
                }
            }

            for (int m = 0; m < sequenceForInsertInResult.Count; m++)
            {
                if (sequenceForInsertInResult[m] <= nextNum)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            sequenceForInsertInResult.RemoveRange(count, sequenceForInsertInResult.Count - count);

            Console.WriteLine(string.Join(" ", sequenceForInsertInResult));
        }
    }
}