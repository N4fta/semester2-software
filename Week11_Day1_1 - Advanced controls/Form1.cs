namespace Week11_Day1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddToList_Click(object sender, EventArgs e)
        {
            if (!cbColors.Items.Contains(cbColors.Text))
            {
                MessageBox.Show("very funny, im laughing so hard righ now.\r\n really. you deserve an oscar.");
                return;
            }
            cbColors.SelectedItem.ToString();
            string toAdd = cbColors.SelectedItem.ToString();

            if (toAdd == "Custom")
            {
                toAdd = tbCustomInput.Text;
            }

            if (ckbLowerCase.Checked && !ckbUpperCase.Checked)
            {
                toAdd = toAdd.ToLower();
            }
            else if (ckbUpperCase.Checked && !ckbLowerCase.Checked)
            {
                toAdd = toAdd.ToUpper();
            }
            lbColors.Items.Add(toAdd);
        }

        private void btClearListBox_Click(object sender, EventArgs e)
        {
            lbColors.Items.Clear();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lbColors.Items.Add("Apple");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lbColors.Items.Add("Bananas");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string toAdd = tbCustomInput.Text;
                lbColors.Items.Add(toAdd);
            }
        }
    }
}