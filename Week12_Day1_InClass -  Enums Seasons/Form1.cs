namespace Week12_Day1_InClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Name = "4 Seasons";
            InitializeComponent();
            label1.Text = currentSeason.ToString();
        }

        public enum Seasons
        {
            SUMMER,
            AUTUMN,
            WINTER,
            SPRING
        }
        Seasons currentSeason = new Seasons();


        private void button1_Click(object sender, EventArgs e)
        {
            currentSeason++;
            if (4 == (int)currentSeason)
            {
                currentSeason = (Seasons)0;
            }
            label1.Text = currentSeason.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentSeason--;
            if (-1 == (int)currentSeason)
            {
                currentSeason = (Seasons)3;
            }
            label1.Text = currentSeason.ToString();
        }

    }
}