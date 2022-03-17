using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBar
{
    public partial class DrinksPricesCalculationForm : Form
    {
        

        public List<string> orderSheet;
        public List<string> drinkSheet;

        public DrinksPricesCalculationForm()
        {
            InitializeComponent();
            orderSheet = new List<string>();
            drinkSheet = new List<string>();
        }

        private void CalculateActionButton_Click(object sender, EventArgs e)
        {
            orderSheet.Clear();
            double orderCost = 0;
            int counterSheet = 0;
            //////////////////////////////////////////////////////////////////////////////////////////////
            foreach (string drink in checkedListBoxDrinks.Items)
            {
                drinkSheet.Add(drink);
            }
            foreach (string i in checkedListBoxIngredients.CheckedItems)
            {

                orderSheet.Add(i);
                if (orderSheet[counterSheet] != null)
                {
                    orderCost += 5;
                    counterSheet++;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            orderSheet.Clear();
            foreach (string s in checkedListBoxDrinks.CheckedItems)
            {
                orderSheet.Add(s);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < orderSheet.Count; i++)
            {
                for (int j = 0; j < drinkSheet.Count; j++)
                {
                    if (orderSheet[i] == drinkSheet[j])
                    {
                        if (j == 0 || j == 1 || j == 2 || j == 3)
                        {
                            AlcoholicDrinks alcoholicDrink = new AlcoholicDrinks(j, Convert.ToDouble(textBoxValue.Text));
                            orderCost += alcoholicDrink.CostCalculationnAlcoholicDrinks();
                        }
                        if (j == 4 || j == 5 || j == 6)
                        {
                            SoftDrinks softDrink = new SoftDrinks(j, Convert.ToDouble(textBoxValue.Text));
                            orderCost += softDrink.CostCalculationnSoftDrinks();
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            labelPrice.Text = $"{orderCost} р";
        }
    }
}