using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar.Drinks
{
    public class Tequila : AlcoholicDrinks
    {
        private double priceTequila = 300;

        public Tequila(int indexDrink, double volume) :
            base(indexDrink, volume)
        {
        }

        public double CalculationPriceTequila()
        {
            return priceTequila * Volume;
        }
    }
}