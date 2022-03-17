using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBar
{
    public class SoftDrinks
    {
        private int drinkIndex;
        private double volume;

        public int DrinkIndex { get => drinkIndex; set => drinkIndex = value; }
        public double Volume { get => volume; set => volume = value; }

        public SoftDrinks(int drinkIndex, double volume)
        {
            this.drinkIndex = drinkIndex;
            this.volume = volume;
        }

        public double CostCalculationnSoftDrinks(double result = 0)
        {
            if (drinkIndex == 4)
            {
                Drinks.Juice juice = new Drinks.Juice(drinkIndex, volume);
                result = juice.CalculationPriceJuice();
            }
            if (drinkIndex == 5)
            {
                Drinks.Cola cola = new Drinks.Cola(drinkIndex, volume);
                result = cola.CalculationPriceCola();
            }
            if (drinkIndex == 6)
            {
                Drinks.Water water = new Drinks.Water(drinkIndex, volume);
                result = water.CalculationPriceWater();
            }
            return result;
        }
    }
}