using System.Runtime.Versioning;

namespace Week10_Day3_3
{
    public partial class Form1 : Form
    {

        int changeInSpeed;
        Car Ferrari;
        Car Fiat;
        Car MainCar;
        List<string> locationsToImagesFerrari = new List<string>
        {
            "Resources/Ferrari_Slow_2.png",
            "Resources/Ferrari_Slow_1.png",
            "Resources/Ferrari_Medium_1.png",
            "Resources/Ferrari_Medium_2.png",
            "Resources/Ferrari_Fast_1.png",
            "Resources/Ferrari_Fast_2.png"
        };
        List<string> locationsToImagesFiat = new List<string>
        {
            "Resources/Fiat_Slow_1.png",
            "Resources/Fiat_Slow_2.png",
            "Resources/Fiat_Medium_1.png",
            "Resources/Fiat_Medium_2.png",
            "Resources/Fiat_Fast_1.png",
            "Resources/Fiat_Fast_2.png"
        };

        public Form1()
        {
            InitializeComponent();
            Ferrari = new Car("Ferrari", 240);
            Fiat = new Car("Fiat", 180);
        }

        public void StartUpSequence(object sender, EventArgs e)
        {
            if (rbFerrari.Checked)
            {
                lblDescription.Text = "Your Ferrari starts roaring";
                pbWindscreen.ImageLocation = "Resources/Ferrari_Garage.png";
                MainCar = Ferrari;
            }
            else if (rbFiatPanda.Checked)
            {
                lblDescription.Text = "Your Fiat Panda shows its hapiness";
                pbWindscreen.ImageLocation = "Resources/Fiat_Garage.png";
                MainCar = Fiat;
            }

            pbWindscreen.Enabled = true;
            lblSpeedDisplay.Enabled = true;
            btPedalBrake.Enabled = true;
            lblPedalBrake.Enabled = true;
            lblPedalGas.Enabled = true;
            btPedalGas.Enabled = true;
            tbSpeedControl.Enabled = true;
        }

        private void tImage_Tick(object sender, EventArgs e)
        {
            Random index = new Random();
            switch (Convert.ToDouble(MainCar.CurrentSpeed()) / Convert.ToDouble(MainCar.MaxSpeed()))
            {
                case 0:
                    ImageChange(0);
                    return;
                case < 0.10:
                    ImageChange(1);
                    return;
                case < 0.65:
                    ImageChange(index.Next(2, 4));
                    return;
                case < 1:
                    ImageChange(index.Next(4, 6));
                    return;
                case <= 1:
                    ImageChange(5);
                    return;
            }
        }
        private void ImageChange(int index)
        {
            if (MainCar.Brand() == "Ferrari")
            {
                pbWindscreen.ImageLocation = locationsToImagesFerrari[index];
            }
            else if (MainCar.Brand() == "Fiat")
            {
                pbWindscreen.ImageLocation = locationsToImagesFiat[index];
            }
        }

        private void tCooldown_Tick(object sender, EventArgs e)
        {
            MainCar.SpeedChange(changeInSpeed);
            lblSpeedDisplay.Text = Convert.ToString(MainCar.CurrentSpeed() + " Km/h");

        }

        private void btPedalGas_MouseDown(object sender, MouseEventArgs e)
        {

            changeInSpeed = tbSpeedControl.Value;
            tImage.Start();
            tCooldown.Start();
            lblDescription.Text = MainCar.ToString();

        }

        private void btPedalBrake_MouseDown(object sender, MouseEventArgs e)
        {
            changeInSpeed = -5;
            tImage.Start();
            tCooldown.Start();
            lblDescription.Text = MainCar.ToString();

        }

        private void btPedals_MouseUp(object sender, MouseEventArgs e)
        {
            tImage.Stop();
            tCooldown.Stop();
        }

        private void btPedalGas_KeyDown(object sender, KeyEventArgs e)
        {
            changeInSpeed = tbSpeedControl.Value;
            tImage.Start();
            tCooldown.Start();
            lblDescription.Text = MainCar.ToString();
        }
        private void btPedalBrake_KeyDown(object sender, KeyEventArgs e)
        {
            changeInSpeed = -5;
            tImage.Start();
            tCooldown.Start();
            lblDescription.Text = MainCar.ToString();
        }

        private void btPedals_KeyUp(object sender, KeyEventArgs e)
        {
            tImage.Stop();
            tCooldown.Stop();
        }

    }
}