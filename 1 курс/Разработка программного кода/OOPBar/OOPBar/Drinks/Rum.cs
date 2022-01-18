using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Rum : AlcoholicDrinks
    {
        private double priceRum = 300;

        public Rum(int indexDrink, double volume) :
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceRum()
        {
            return priceRum * Volume;
        }
    }
}