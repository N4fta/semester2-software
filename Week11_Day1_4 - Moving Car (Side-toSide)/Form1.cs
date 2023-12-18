using System.ComponentModel;

namespace Week11_Day1_4
{
    public partial class Form1 : Form
    {
        int xPositionCar;
        int carVelocity;
        int randomCarDirectionCounter;

        public Form1()
        {
            InitializeComponent();
            xPositionCar = 12;
            carVelocity = 10;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrCar.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrCar.Stop();
        }

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            if (xPositionCar > this.Size.Width - 122) { carVelocity = -10; }
            else if (xPositionCar < 12) { carVelocity = 10; }
            else if (randomCarDirectionCounter>200)
            {
                Random random = new Random();
                if (random.Next(2) == 1)  { carVelocity = -10; }
                else { carVelocity = 10; }
                randomCarDirectionCounter = 0;
            }

            xPositionCar = xPositionCar + carVelocity;
            randomCarDirectionCounter +=Math.Abs(carVelocity);
            picboxCar.Location = new Point(xPositionCar, 12);
        }
    }
}