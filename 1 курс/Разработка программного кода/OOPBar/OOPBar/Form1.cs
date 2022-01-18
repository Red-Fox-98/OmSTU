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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> orderSheet = new List<string>();
            List<string> drinkSheet = new List<string>();
            double orderCost = 0;
            int counter = 0;
            //////////////////////////////////////////////////////////////////////////////////////////////
            foreach (string drink in comboBoxDrinks.Items)
            {
                drinkSheet.Add(drink);
            }
            foreach (string i in checkedListBoxIngredients.CheckedItems)
            {
                orderSheet.Add(i);
                if (orderSheet[counter] != null)
                {
                    orderCost += 5;
                    counter++;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            orderSheet.Clear();
            foreach (string s in checkedListBoxDrinks.CheckedItems)
            {
                orderSheet.Add(s);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < comboBoxDrinks.Items.Count; i++)
            {
                if (i == 0 || i == 1 || i == 2 || i == 3)
                {
                    AlcoholicDrinks alcoholicDrink = new AlcoholicDrinks(i, Convert.ToDouble(textBoxValue.Text));
                    if (comboBoxDrinks.SelectedIndex == i)
                    {
                        orderCost += alcoholicDrink.CostCalculationnAlcoholicDrinks();
                    }
                }
                if (i == 4 || i == 5 || i == 6)
                {
                    SoftDrinks softDrink = new SoftDrinks(i, Convert.ToDouble(textBoxValue.Text));
                    if (comboBoxDrinks.SelectedIndex == i)
                    {
                        orderCost += softDrink.CostCalculationnSoftDrinks();
                    }
                }
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