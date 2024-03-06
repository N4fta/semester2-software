namespace Week12_Day1___Planet_Information
{
    public partial class Form1 : Form
    {
        enum PlanetsName
        {
            SUN,
            MERCURY,
            VENUS,
            EARTH,
            MARS,
            JUPITER,
            SATURN,
            URANUS,
            NEPTUNE
        }

        List<string> listGravities = new List<string>(){
            "274.0 m/s^2",
            "3.7 m/s^2",
            "8.9 m/s^2",
            "9.8 m/s^2",
            "3.7 m/s^2",
            "24.8 m/s^2",
            "9.0 m/s^2",
            "8.7 m/s^2",
            "11.2 m/s^2"

        };

        List<string> listDiameters = new List<string>(){
            "1,392,000 Km",
            "4,879.4 Km",
            "12,103.6 Km",
            "12,742 Km",
            "6,792.4 Km",
            "142,984 Km",
            "120,536 Km",
            "51,118 Km",
            "49,528 Km"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btSun_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.SUN);
        }
        private void btMercury_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.MERCURY);
        }

        private void btVenus_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.VENUS);
        }

        private void btEarth_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.EARTH);
        }

        private void btMars_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.MARS);
        }

        private void btJupiter_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.JUPITER);
        }

        private void btSaturn_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.SATURN);
        }

        private void btUranus_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.URANUS);
        }

        private void btNeptune_Click(object sender, EventArgs e)
        {
            UpdateLabels(PlanetsName.NEPTUNE);
        }

        private void UpdateLabels(Enum planet)
        {
            string planetName = planet.ToString();
            planetName = planetName.ToLower();
            tbGravity.Text = $"The gravity on {planetName} is {listGravities[Convert.ToInt32(planet)]}";
            planetName = planetName[0].ToString().ToUpper() + planetName.Remove(0, 1);
            tbDiameter.Text = $"{planetName}'s diameter is {listDiameters[Convert.ToInt32(planet)]}";
        }

    }
}