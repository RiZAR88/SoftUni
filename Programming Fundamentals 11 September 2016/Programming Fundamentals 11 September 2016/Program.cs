using System;
using System.Collections.Generic;


namespace Programming_Fundamentals_11_September_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPictures = int.Parse(Console.ReadLine());  //5342снимки
            var filterTime = int.Parse(Console.ReadLine());     //2сек
            var filterPictures = int.Parse(Console.ReadLine()); //82проценти
            var uploadTime = int.Parse(Console.ReadLine());     //3сек

            float usefulPicutes = (float)(filterPictures * totalPictures) / 100;   // (82 * 5342) / 100 = 4380,44 снимки

            double timeForFiltred = totalPictures * filterTime;  //5342снимки *2 сек= 10684 секунди
            double timeForUpload = Math.Ceiling(usefulPicutes) * uploadTime;//Math.Ceiling закръгля нагоре usefulPictures = 4381 , но връща резултата в decimal затова слагам (int) отпред 

            double totalTime = timeForFiltred + timeForUpload;//резултата в секунди  = 10684 + 13143= 23827секунди

            int ostatukSekundi = (int)totalTime % 60; //когато делим с % взема само остатъка от деленето           
            int resultOfminutes = (int)totalTime / 60;
            int ostatukMinuti = resultOfminutes % 60;
            int resultOfHours = resultOfminutes / 60;
            int ostatukChasove = resultOfHours % 24;
            int resultOfDays = resultOfHours / 24;

            Console.WriteLine($"{resultOfDays}:{ostatukChasove:d2}:{ostatukMinuti:d2}:{ostatukSekundi:d2}");//най-после :D // :d2-означаваа извеждане на резултата с два знака пред десетичната запетая

        }
    }
}
