using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Wine : AlcoholicDrinks
    {
        private double priceWine = 200;

        public Wine(int indexDrink, double volume) : 
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceWine()
        {
            return priceWine * Volume;
        }
    }
}