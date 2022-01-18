using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar
{
    public class SoftDrinks
    {
        private double volume;
        private double price;

        public double Volume { get => volume; set => volume = value; }
        public double Price { get => price; set => price = value; }

        public SoftDrinks(double volume, double price)
        {
            this.volume = volume;
            this.price = price;
        }

        public double CostCalculationnSoftDrinks()
        {
            return volume * price;
        }
    }
}