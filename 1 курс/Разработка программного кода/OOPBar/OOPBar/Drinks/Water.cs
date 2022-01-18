using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Water : SoftDrinks
    {
        private double priceWater = 50;

        public Water(int indexDrink, double volume) : 
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceWater()
        {
            return priceWater * Volume;
        }
    }
}