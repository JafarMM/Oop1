using System;

namespace OOpstask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Azerbaycan", "Baku", 100123142) { SeaName = "CaspianSea" };
            country.SeaName ??= "There is no sea";
            Console.WriteLine(country.Capital);
            Console.WriteLine(country.population);
            Console.WriteLine(country.Name);
            Console.WriteLine(country.SeaName);
            
        }
    }
}
