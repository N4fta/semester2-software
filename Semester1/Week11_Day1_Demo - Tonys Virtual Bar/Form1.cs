namespace Demo_Week11_day1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string order = "", imageName = "default";

        private void cbOver18_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOver18.Checked == true)
            {
                MessageBox.Show("Are you reaally? Dont be irresponsable");
                rbRum.Visible = true;
                rbRum.Enabled = true;
                rbBeer.Visible = true;
                rbBeer.Enabled = true;
                imageName = "over18";
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
                pb1.Image = bmp;
            }
            else if (cbOver18.Checked == false)
            {
                rbRum.Visible = false;
                rbRum.Enabled = false;
                rbBeer.Visible = false;
                rbBeer.Enabled = false;
                imageName = "default";
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
                pb1.Image = bmp;

            }
        }

        private void rbRum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRum.Checked)
            {
                order = "Enjoy your Rum";
                imageName = "bartender1";
            }
        }

        private void rbLemonade_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLemonade.Checked)
            {
                order = "Enjoy your Lemonade";
                imageName = "bartender2";

            }

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            lblMessage.Text = order;
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
            pb1.Image = bmp;
        }

        private void rbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWater.Checked)
            {
                order = "Enjoy your Water";
                imageName = "bartender3";

            }
        }
        private void rbBeer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBeer.Checked)
            {
                order = "Enjoy your Beer";
                imageName = "bartender4";
            }
        }
        private void result_Thread()
        {
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
            pb1.Image = bmp;
        }
    }
}