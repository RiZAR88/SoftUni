using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam__20_Nov_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberDays = int.Parse(Console.ReadLine());
            var KiloFoodLeft = int.Parse(Console.ReadLine());
            var FoodForDogKilo = double.Parse(Console.ReadLine());
            var FoorForCatKilo = double.Parse(Console.ReadLine());
            var FoodTurtlesGrams = double.Parse(Console.ReadLine());

            var FoodForDog = NumberDays * FoodForDogKilo;
            var FoodForCat = NumberDays * FoorForCatKilo;
            var FoodTurtles = (NumberDays * FoodTurtlesGrams) / 1000;
            var AllFood = FoodForDog + FoodForCat + FoodTurtles;

            if (AllFood <= KiloFoodLeft)
            {
                var Left = KiloFoodLeft - AllFood;
                Console.WriteLine("{0} kilos of food left.", (int)Left);
            }
            else
            {
                var Need = Math.Ceiling(AllFood - KiloFoodLeft);
                Console.WriteLine("{0} more kilos of food are needed.", Need);
            }
        }
    }
}