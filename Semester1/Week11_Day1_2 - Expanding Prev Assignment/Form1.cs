namespace Week11_Day1_2
{
    public partial class Form1 : Form
    {
        BankAccount SavingsAccounts;
        BankAccount CheckingsAccounts;

        public Form1()
        {
            InitializeComponent();
            SavingsAccounts = new BankAccount();
            CheckingsAccounts = new BankAccount();
            lblCheckingsAccount.Text = CheckingsAccounts.ToString();
            lblSavingsAccount.Text = SavingsAccounts.ToString();
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (rbCheckings.Checked)
            {
                CheckingsAccounts.DepositMoney(Convert.ToInt32(nupAmount.Value * 100));
            }
            else if (rbSavings.Checked)
            {
                SavingsAccounts.DepositMoney(Convert.ToInt32(nupAmount.Value * 100));
            }
            else { return; }

            lblCheckingsAccount.Text = CheckingsAccounts.ToString();
            lblSavingsAccount.Text = SavingsAccounts.ToString();
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            bool operationSuccessful;
            if (rbCheckings.Checked)
            {
                operationSuccessful = CheckingsAccounts.WithdrawMoney(Convert.ToInt32(nupAmount.Value * 100));
            }
            else if (rbSavings.Checked)
            {
                operationSuccessful = SavingsAccounts.WithdrawMoney(Convert.ToInt32(nupAmount.Value * 100));
            }
            else { return; }

            if (!operationSuccessful)
            {
                MessageBox.Show("Operation failled\r\nPls check your balance");
            }

            lblCheckingsAccount.Text = CheckingsAccounts.ToString();
            lblSavingsAccount.Text = SavingsAccounts.ToString();
        }
    }
}