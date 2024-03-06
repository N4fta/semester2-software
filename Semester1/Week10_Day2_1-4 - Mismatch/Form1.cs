

namespace Day2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean firstEasterEgg = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstEasterEgg)
            {
                MessageBox.Show("You found an Easter Egg!\nHere you go 0, enjoy!");
            }
            else
            {
                MessageBox.Show("Your name is [REDACTED], you worked for [REDACTED, until [REDACTED] and you had no choice but to run. You MUST ***EA* T** W**D! REMMEMBER!");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void rbCRAZY_CheckedChanged(object sender, EventArgs e)
        {

            // Create a thread and call a background method
            Thread backgroundThread = new Thread(new ThreadStart(GoCrazy));
            // Start thread
            backgroundThread.Start();
        }
        private void GoCrazy()
        {
            int red = 255, green = 0, blue = 0;
            Random rnd = new Random();

            while (rbCRAZY.Checked)
            {
                if (red >= 225) { red += rnd.Next(-30, -10); }
                else if (red <= 30) { red += rnd.Next(10, 30); }
                else { red += rnd.Next(-30, 30); }
                if (green >= 225) { green += rnd.Next(-30, -10); }
                else if (green <= 30) { green += rnd.Next(10, 30); }
                else { green += rnd.Next(-30, 30); }
                if (blue >= 225) { blue += rnd.Next(-30, -10); }
                else if (blue <= 30) { blue += rnd.Next(10, 30); }
                else { blue += rnd.Next(-30, 30); }

                Thread.Sleep(50);
                BackColor = Color.FromArgb(red, green, blue);

                trackBar1.Value = rnd.Next(0, 101);
                progressBar1.Value = rnd.Next(0, 101);
                label1.Text = rnd.Next(0, 101).ToString();

            }

        }

        private void btnCycleBackgrounds_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red || BackColor == Color.WhiteSmoke) { BackColor = Color.Green; }
            else if (BackColor == Color.Green) { BackColor = Color.Blue; }
            else if (BackColor == Color.Blue) { BackColor = Color.Red; }
            else { firstEasterEgg = true; }
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            lblNotesBMI.Text = "Remember that BMI is different from person to person and is not a perfect measure.\r\nWhoever if you are in the Obese or Extremely Underweigth class please check with your doctor.\r\nBeing in one of those classes can lead to increased health risks.\r\n";

            try
            {
                string weightInput = tbWeightInput.Text.ToString();
                weightInput = weightInput.Replace(".", ",");
                string heightInput = tbHeightInput.Text.ToString();
                heightInput = heightInput.Replace(".", ",");
                double BMI = Convert.ToDouble(weightInput) / Math.Pow(Convert.ToDouble(heightInput), 2);
                switch (BMI)
                {
                    case < 18.5:
                        lblBMIResults.Text = $"Your BMI is {BMI.ToString("0.00")} and that would put you in the underweight class.";
                        break;
                    case < 25.0:
                        lblBMIResults.Text = $"Your BMI is {BMI.ToString("0.00")} and that would put you in the normal weight class.";
                        break;
                    case < 30.0:
                        lblBMIResults.Text = $"Your BMI is {BMI.ToString("0.00")} and that would put you in the overweight class.";
                        break;
                    default:
                        lblBMIResults.Text = $"Your BMI is {BMI.ToString("0.00")} and that would put you in the obese class.";
                        break;
                }
                if (Convert.ToDouble(weightInput) <= 0 || Convert.ToDouble(heightInput) <= 0) { lblBMIResults.Text = "Invalid Input"; }
            }
            catch
            {
                lblBMIResults.Text = "Invalid Input";
            }
        }
    }
}