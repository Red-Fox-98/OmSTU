using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar
{
    public class AlcoholicDrinks
    {
        private int drinkIndex;
        private double volume;

        public int DrinkIndex { get => drinkIndex; set => drinkIndex = value; }
        public double Volume { get => volume; set => volume = value; }

        public AlcoholicDrinks(int drinkIndex, double volume)
        {
            this.drinkIndex = drinkIndex;
            this.volume = volume;
        }

        public double CostCalculationnAlcoholicDrinks()
        {
            double result = 0;
            if (drinkIndex == 0)
            {
                Drinks.Wine wine = new Drinks.Wine(drinkIndex, volume);
                result = wine.CalculationPriceWine();
            }
            if (drinkIndex == 1)
            {
                Drinks.Tequila tequila = new Drinks.Tequila(drinkIndex, volume);
                result = tequila.CalculationPriceTequila();
            }
            if (drinkIndex == 2)
            {
                Drinks.Whiskey whiskey = new Drinks.Whiskey(drinkIndex, volume);
                result = whiskey.CalculationPriceWhiskey();
            }
            if (drinkIndex == 3)
            {
                Drinks.Rum rum = new Drinks.Rum(drinkIndex, volume);
                result = rum.CalculationPriceRum();
            }
            return result;
        }
    }
}