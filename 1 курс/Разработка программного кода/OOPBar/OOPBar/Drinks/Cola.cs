using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Cola : SoftDrinks
    {
        private double priceCola = 75;

        public Cola(int indexDrink, double volume) :
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceCola()
        {
            return priceCola * Volume;
        }
    }
}