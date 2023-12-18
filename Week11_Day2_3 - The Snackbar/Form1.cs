namespace Week11_Day2_3
{
    public partial class Form1 : Form
    {
        SnackBar snackBar;
        List<int> orderItemQuantities;
        List<string> orderItemNames;

        public Form1()
        {
            InitializeComponent();
            orderItemNames = new List<string>();
            orderItemQuantities = new List<int>();
            snackBar = new SnackBar(new Snack("Nachos", 5, 13), new Snack("Fritas", 3, 23), new Snack("Water", 2, 21));

            //Clearing all elements, just in case
            cbClient.Items.Clear();
            cbManagement.Items.Clear();
            lbManagementInventory.Items.Clear();
            foreach (Snack sn in snackBar.GetSnacks())
            {
                lbManagementInventory.Items.Add(sn.GetListBoxFormat());
                cbManagement.Items.Add(sn.GetName());
                cbClient.Items.Add(sn.GetName());
            }
            cbManagement.Items.Add("Add");
        }

        private void btnClientAddToCart_Click(object sender, EventArgs e)
        {
            if (cbClient.FindString(cbClient.Text) != -1 && cbClient.Text != "" && nupClient.Value != 0)
            {
                Snack selectedSnack = snackBar.findSnackThroughName(cbClient.Text);
                if (nupClient.Value<=selectedSnack.GetStock())
                {
                    orderItemNames.Add(cbClient.Text);
                    orderItemQuantities.Add((int)nupClient.Value);
                }
                else
                {
                    MessageBox.Show("There is no more stock");
                }
            }
            RefreshLbClientCart();
        }

        private void RefreshLbClientCart()
        {
            if (orderItemQuantities != null && orderItemNames != null)
            {
                lbClientCart.Items.Clear();
                decimal totalPrice = 0;
                for (int i = 0; i < orderItemQuantities.Count; i++)
                {
                    var snack = snackBar.findSnackThroughName(orderItemNames[i]);
                    lbClientCart.Items.Add($"{snack.GetName()} - {orderItemQuantities[i]} x {snack.GetPrice()} - {orderItemQuantities[i] * snack.GetPrice()} euros");
                    totalPrice = totalPrice + Convert.ToDecimal(orderItemQuantities[i] * snack.GetPrice());
                }
                lblClientTotalPrice.Text = $"{totalPrice} euros";
            }
            else
            {
                lbClientCart.Items.Clear();
                lblClientTotalPrice.Text = "";
            }
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClient.FindString(cbClient.Text) != -1 && cbClient.Text != "")
            {
                var snack = snackBar.findSnackThroughName(cbClient.Text);
                lblClientName.Text = snack.GetName();
                lblClientPrice.Text = $"{snack.GetPrice()} euros";
                lblClientStock.Text = $"{snack.GetStock()} units left";
                lblClientDescription.Text = snack.GetDescription();
                nupClient.Maximum = snack.GetStock();
            }
            else
            {
                lblClientName.Text = "";
                lblClientPrice.Text = "";
                lblClientStock.Text = "";
                lblClientDescription.Text = "";
            }
        }

        private void btClientOrder_Click(object sender, EventArgs e)
        {
            decimal ProcessOrderResult = snackBar.ProcessOrder(orderItemNames, orderItemQuantities);
            if (ProcessOrderResult > 0)
            {
                MessageBox.Show($"Your order was successfully processed.\r\nYour bill comes out to {ProcessOrderResult}\r\nPlease head to the counter to pay and receive your order.");
            }
            else
            {
                ProcessOrderResult *= -1;
                MessageBox.Show($"{orderItemNames[(int)ProcessOrderResult]} has run out of stock.\r\nModify your order and try again.");
            }
            cbClient_SelectedIndexChanged(new object(), new EventArgs());
            orderItemNames.Clear();
            orderItemQuantities.Clear();
            RefreshLbClientCart();

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            cbClient.Items.Clear();
            cbManagement.Items.Clear();
            lbManagementInventory.Items.Clear();
            foreach (Snack sn in snackBar.GetSnacks())
            {
                lbManagementInventory.Items.Add(sn.GetListBoxFormat());
                cbManagement.Items.Add(sn.GetName());
                cbClient.Items.Add(sn.GetName());
            }
            cbManagement.Items.Add("Add");
            lblManagementRevenue.Text = $"Total Revenue: {snackBar.GetRevenue()} euros";
        }

        private void cbManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbManagementSnack.Visible = false;
            btnManagementAdd.Visible = false;
            if (cbManagement.FindString(cbManagement.Text) != -1 && cbManagement.Text != "")
            {
                gbManagementSnack.Visible = true;
                if (cbManagement.Text == "Add")
                {
                    btnManagementAdd.Visible = true;
                    tbManagementName.Text = "Name";
                    nupManagementPrice.Value = 0;
                    nupManagementStock.Value = 0;
                    rtbManagementDescription.Text = "Description";
                }
                else
                {
                    btnManagementRemove.Visible = true;
                    var snack = snackBar.findSnackThroughName(cbManagement.Text);
                    tbManagementName.Text = snack.GetName();
                    nupManagementPrice.Value = snack.GetPrice();
                    nupManagementStock.Value = snack.GetStock();
                    rtbManagementDescription.Text = snack.GetDescription();
                }
            }
        }

        private void btnManagementAdd_Click(object sender, EventArgs e)
        {
            snackBar.AddToMenu(new Snack(tbManagementName.Text, nupManagementPrice.Value, Convert.ToInt32(nupManagementStock.Value), rtbManagementDescription.Text));
            cbManagement.Text = "";
            tbManagementName.Text = "";
            nupManagementPrice.Value = 0;
            nupManagementStock.Value = 0;
            rtbManagementDescription.Text = "";
            gbManagementSnack.Visible = false;
            btnManagementAdd.Visible = false;
            cbManagement.Items.Clear();
            lbManagementInventory.Items.Clear();
            foreach (Snack sn in snackBar.GetSnacks())
            {
                lbManagementInventory.Items.Add(sn.GetListBoxFormat());
                cbManagement.Items.Add(sn.GetName());
            }
            cbManagement.Items.Add("Add");
            lblManagementRevenue.Text = $"Total Revenue: {snackBar.GetRevenue()} euros";
        }

        private void btnManagementRemove_Click(object sender, EventArgs e)
        {
            snackBar.DeleteSnack(tbManagementName.Text);
            cbManagement.Text = "";
            tbManagementName.Text = "";
            nupManagementPrice.Value = 0;
            nupManagementStock.Value = 0;
            rtbManagementDescription.Text = "";
            gbManagementSnack.Visible = false;
            btnManagementRemove.Visible = false;
            cbManagement.Items.Clear();
            lbManagementInventory.Items.Clear();
            foreach (Snack sn in snackBar.GetSnacks())
            {
                lbManagementInventory.Items.Add(sn.GetListBoxFormat());
                cbManagement.Items.Add(sn.GetName());
            }
            cbManagement.Items.Add("Add");
            lblManagementRevenue.Text = $"Total Revenue: {snackBar.GetRevenue()} euros";
        }
    }
}