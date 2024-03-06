namespace Week12_Day1_1___Pizza_Toppings
{
    public partial class Form1 : Form
    {
        Toppings toppings;
        List<Toppings> toppingsList = new List<Toppings>();

        public Form1()
        {
            InitializeComponent();
            toppings = new Toppings();
            cbPizzaToppings.DataSource = Enum.GetValues(typeof(Toppings));
        }

        private void btAddTopping_Click(object sender, EventArgs e)
        {
            if (toppingsList.Count > 7)
            {
                MessageBox.Show("Max amount of toppings is 7");
                return;
            }
            toppingsList.Add((Toppings)cbPizzaToppings.SelectedItem);

            UpdateLabels();
        }

        private void btRemoveTopping_Click(object sender, EventArgs e)
        {
            if (toppingsList.Count <= 0)
            {
                MessageBox.Show("No toppings to remove");
                return;
            }
            if (toppingsList.LastIndexOf((Toppings)cbPizzaToppings.SelectedItem) == -1)
            {
                MessageBox.Show("No such toppings found");
                return;
            }
            toppingsList.RemoveAt(toppingsList.LastIndexOf((Toppings)cbPizzaToppings.SelectedItem));

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            string newDescription = "Pizza with:  ";
            foreach (var item in toppingsList)
            {
                newDescription += item + ", ";
            }
            lblPizzaDescription.Text = newDescription.Remove(newDescription.Length - 2);
            lblPizzaPrice.Text = "Price: " + UpdatedPrice() + " euro";
        }

        private decimal UpdatedPrice()
        {
            decimal price = Convert.ToDecimal(5 + toppingsList.Count * 0.5);
            return decimal.Round(price, 1);
        }
    }
}