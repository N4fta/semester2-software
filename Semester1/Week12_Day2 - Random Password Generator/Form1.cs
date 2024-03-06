namespace Week12_Day2___Random_Password_Generator
{
    public partial class Form1 : Form
    {
        List<string> Passwords = new List<string>();
        public Form1()
        {
            InitializeComponent();
            UpdatelbxPasswords();
        }

        private void btnGeneratePasswords_Click(object sender, EventArgs e)
        {
            int passwordLength = Convert.ToInt32(nudPasswordLenght.Value);
            int amountOfPasswords = Convert.ToInt32(nudAmountOfPasswords.Value);
            bool includeSymbols = chbkIncludeSymbols.Checked;

            if (chbxUniqueCharacters.Checked)
            {
                if (!includeSymbols && passwordLength>=63)
                {
                    MessageBox.Show("Not enough characters");
                    return;
                }
                Passwords.AddRange(PasswordGenerator.GeneratePasswordsWithNoDuplicateCharacters(passwordLength, amountOfPasswords, includeSymbols));
            }
            else
            {
                Passwords.AddRange(PasswordGenerator.GeneratePasswords(passwordLength, amountOfPasswords, includeSymbols));
            }
            UpdatelbxPasswords();
        }

        private void lbxPasswords_DoubleClick(object sender, EventArgs e)
        {
            if (lbxPasswords.SelectedItem != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Password?", "Confirm", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Passwords.Remove(lbxPasswords.SelectedItem.ToString());
                    UpdatelbxPasswords();
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void UpdatelbxPasswords()
        {
            lbxPasswords.DataSource = null;
            lbxPasswords.Items.Clear();
            lbxPasswords.DataSource = Passwords;
        }
    }
}