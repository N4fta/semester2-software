namespace Week11_Day1_3
{
    public partial class Form1 : Form
    {
        List<Expenses> TransactionLog = new List<Expenses>();
        int userInputFilter;
        decimal userInputThreshold;

        public Form1()
        {
            InitializeComponent();
            userInputFilter = 0;
            userInputThreshold = 0;
        }

        private void RefreshListBox()
        {
            switch (userInputFilter)
            {
                case 0:
                    lbLog.Items.Clear();
                    foreach (Expenses expense in TransactionLog)
                    {
                        lbLog.Items.Add(expense.GetInfo());
                    }
                    return;
                case 1:
                    lbLog.Items.Clear();
                    foreach (Expenses expense in TransactionLog)
                    {
                        if (expense.GetValue() < userInputThreshold)
                        {
                            lbLog.Items.Add(expense.GetInfo());
                        }
                    }
                    return;
                case 2:
                    lbLog.Items.Clear();
                    foreach (Expenses expense in TransactionLog)
                    {
                        if (expense.GetValue() > userInputThreshold)
                        {
                            lbLog.Items.Add(expense.GetInfo());
                        }
                    }
                    return;
                case 3:
                    lbLog.Items.Clear();
                    foreach (Expenses expense in TransactionLog)
                    {
                        if (expense.GetValue() == userInputThreshold)
                        {
                            lbLog.Items.Add(expense.GetInfo());
                        }
                    }
                    return;
            }
        }

        private void btnAddToLog_Click(object sender, EventArgs e)
        {
            TransactionLog.Add(new Expenses(tbExpenseForm.Text, nupExpenseForm.Value));
            RefreshListBox();
        }

        private void btShowAllExpenses_Click(object sender, EventArgs e)
        {
            userInputFilter = 0;
            RefreshListBox();
        }

        private void btLess_Click(object sender, EventArgs e)
        {
            userInputFilter = 1;
            userInputThreshold = nupAmountFilter.Value;
            RefreshListBox();
        }

        private void btSame_Click(object sender, EventArgs e)
        {
            userInputFilter = 3;
            userInputThreshold = nupAmountFilter.Value;
            RefreshListBox();
        }

        private void btMore_Click(object sender, EventArgs e)
        {
            userInputFilter = 2;
            userInputThreshold = nupAmountFilter.Value;
            RefreshListBox();
        }
    }
}