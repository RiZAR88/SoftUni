using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(' ').ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < inputList.Count; i++)
            {
                    if(i % 2 != 0)
                {
                        result.Add(inputList[i]);
                }
            }
          
            Console.WriteLine(string.Join("", result));
        }
    }
}