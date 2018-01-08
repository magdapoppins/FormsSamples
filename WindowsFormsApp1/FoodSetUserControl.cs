using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FoodSetUserControl : UserControl
    {
        public FoodSet MyFoodSet
        {
            get
            {
                MyFoodSet.Starter = starterTextBox.Text;
                MyFoodSet.Main = mainTextBox.Text;
                MyFoodSet.Price = Convert.ToDouble(priceTextBox.Text);
                MyFoodSet.DessertIncluded = dessertCheckBox.Checked;
                return MyFoodSet;
            }
            set
            {
                starterTextBox.Text = value.Starter;
                mainTextBox.Text = value.Main;
                priceTextBox.Text = value.Price.ToString();
                dessertCheckBox.Checked = value.DessertIncluded;
                MyFoodSet = value;
            }
        }

        public FoodSetUserControl()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
