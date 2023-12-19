namespace Week11_Day3_2___Dice_Rolling
{
    public partial class Form1 : Form
    {
        internal bool[] listOfFoundEasterEggs = { false, false, false, false, false, false, false, false };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollTheDice_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 10)
            {
                DialogResult buttonClicked = MessageBox.Show($"This will create {numericUpDown1.Value} pages, are you sure about this?\r\nTip: Close the main window to close all dice windows.", "tiiiiiiipppss", MessageBoxButtons.OKCancel);
                if (buttonClicked == DialogResult.Cancel) { return; }
            }

            if (numericUpDown1.Value == 69)
            {
                listOfFoundEasterEggs[2] = true;
                EasterEggFound();
            }
            if (numericUpDown1.Value == 0)
            {
                listOfFoundEasterEggs[1] = true;
                EasterEggFound();
            }

            for (int i = Convert.ToInt32(numericUpDown1.Value); i > 0; i--)
            {
                Dice_Form dice_Form = new Dice_Form();
                dice_Form.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            listOfFoundEasterEggs[0] = true;
            EasterEggFound();
        }
         
        public void EasterEggFound()
        {
            int easterEggsFound = 0;
            foreach (bool easterEgg in listOfFoundEasterEggs)
            {
                if (easterEgg) { easterEggsFound++; }
            }
            if (easterEggsFound == 3)
            {
                MessageBox.Show("something amazing");
                for (int i = 200; i > 0; i--)
                {
                    Dice_Form dice_Form = new Dice_Form();
                    dice_Form.Show();
                }
                Thread.Sleep(5000);
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1")
                        Application.OpenForms[i].Close();
                }

                MessageBox.Show("haha\r\nSorry did that scare you?\r\nAnyways congratulations! You found all Easter Eggs!");

            }
            else
            {
                MessageBox.Show($"You found Easter egg number {easterEggsFound}.\r\n Find all 8 Easter eggs to see something amazing.");
            }
        }
    }
}