using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Whiskey : AlcoholicDrinks
    {
        private double priceWhiskey = 300;

        public Whiskey(int indexDrink, double volume) :
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceWhiskey()
        {
            return priceWhiskey * Volume;
        }
    }
}