using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var PriceSkum = double.Parse(Console.ReadLine());
            var PriceCaca = double.Parse(Console.ReadLine());
            var kiloPalamud = double.Parse(Console.ReadLine());
            var kiloSafrid = double.Parse(Console.ReadLine());
            var kiloMidi = int.Parse(Console.ReadLine());

            var palamud = (PriceSkum + (PriceSkum / 0.6)) * 0.6;
            var PalamudPrice = (palamud * kiloPalamud);
            //Console.WriteLine(PalamudPrice);   - проверка
            var safrid = (PriceCaca + (PriceCaca / 0.8)) * 0.8;
            var safridPrice = kiloSafrid * safrid;
            //Console.WriteLine(safridPrice);    - проверка
            var midiPrice = kiloMidi * 7.50;
            var overall = PalamudPrice + safridPrice + midiPrice;
            Console.WriteLine("{0:F2}", overall);


        }
    }
}
