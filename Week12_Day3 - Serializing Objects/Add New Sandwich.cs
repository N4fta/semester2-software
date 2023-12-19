using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12_Day3___Serializing_Objects
{
    public partial class Add_New_Sandwich : Form
    {
        Bakery bakery;
        double BASEPRICE;

        public Add_New_Sandwich(Bakery b)
        {
            InitializeComponent();
            bakery = b;
            BASEPRICE = 5;
            cbxNewSandwichBread.DataSource = Enum.GetValues(typeof(BreadType));
            chlbxIngredients.DataSource = bakery.GetAvailableIngredients();
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNewSandwichName.Text) || bakery.GetAvailableSandwiches().Where(x => x.Name == tbxNewSandwichName.Text).Count() >= 1)
            {
                MessageBox.Show("Name invalid");
                return;
            }
            if (chlbxIngredients.CheckedItems.Count > 5)
            {
                MessageBox.Show("Please select 5 ingredients or less");
                return;
            }
            Sandwich newSandwich = new Sandwich(tbxNewSandwichName.Text, BASEPRICE, (BreadType)cbxNewSandwichBread.SelectedItem);
            foreach (Ingredient i in chlbxIngredients.CheckedItems)
            {
                newSandwich.AddIngredient(i);
            }
            bakery.AddSandwich(newSandwich);
            this.Close();
        }
    }
}
