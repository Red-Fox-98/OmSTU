using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar
{
    public class AlcoholicDrinks
    {
        private double volume;
        private double price;

        public double Volume { get => volume; set => volume = value; }
        public double Price { get => price; set => price = value; }

        public AlcoholicDrinks(string name, double volume, double price)
        {
            this.volume = volume;
            this.price = price;
        }

        public double CostCalculationnAlcoholicDrinks()
        {
            return volume * price;
        }
    }
}