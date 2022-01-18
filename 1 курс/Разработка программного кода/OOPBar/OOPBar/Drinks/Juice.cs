using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Juice : SoftDrinks
    {
        private double priceJuice = 75;

        public Juice(int indexDrink, double volume) :
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceJuice()
        {
            return priceJuice * Volume;
        }
    }
}