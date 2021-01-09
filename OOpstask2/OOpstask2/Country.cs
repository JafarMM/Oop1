using System;
using System.Collections.Generic;
using System.Text;

namespace OOpstask2
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int population { get; set; }
        public string SeaName { get; set; }

        public Country(string name, string capital, int population)
        {
            Name = name;
            Capital = capital;
            this.population = population;
        }
        
    }
}
