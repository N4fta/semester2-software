namespace Day2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change_In_Input(object sender, EventArgs e)
        {
            if (!rbTruckA.Checked && !rbTruckB.Checked && !rbTruckC.Checked) { lblResults.Visible = false; }
            else { lblResults.Visible = true; }

            decimal maxBoxesPerPallete = 0;
            decimal maxPalletesPerTruck = 0;
            string recommendedExtraTruck = "";

            if (rbTruckA.Checked)
            {
                recommendedExtraTruck = "A";
                maxBoxesPerPallete = nudBoxesTruckA.Value;
                maxPalletesPerTruck = nudPalletsTruckA.Value;
            }
            else if (rbTruckB.Checked)
            {
                recommendedExtraTruck = "B";
                maxBoxesPerPallete = nudBoxesTruckB.Value;
                maxPalletesPerTruck = nudPalletsTruckB.Value;
            }
            else if (rbTruckC.Checked)
            {
                recommendedExtraTruck = "C";
                maxBoxesPerPallete = nudBoxesTruckC.Value;
                maxPalletesPerTruck = nudPalletsTruckC.Value;
            }

            if (maxBoxesPerPallete == 0 || maxPalletesPerTruck == 0) { lblResults.Text = "Input Invalid"; }
            else
            {
                int totalPalletes = Convert.ToInt32(Math.Round(nudBoxesOrder.Value / maxBoxesPerPallete, 0, System.MidpointRounding.ToNegativeInfinity));
                int fullTrucks = Convert.ToInt32(Math.Round(totalPalletes / maxPalletesPerTruck, 0, System.MidpointRounding.ToNegativeInfinity));
                int fullPalletes = totalPalletes % Convert.ToInt32(maxPalletesPerTruck);
                int fullBoxes = Convert.ToInt32(nudBoxesOrder.Value - (totalPalletes * maxBoxesPerPallete));


                //calculate difference between boxes left over and boxes per truck, truck with smallest difference is recommended
                decimal smallestNumberOfBoxesThatWork = maxPalletesPerTruck*maxBoxesPerPallete;
                decimal boxesLeftOver = fullPalletes * maxBoxesPerPallete + fullBoxes;
                decimal boxesPerTruck = nudPalletsTruckA.Value * nudBoxesTruckA.Value;
                if (boxesLeftOver <= boxesPerTruck && boxesPerTruck < smallestNumberOfBoxesThatWork) { smallestNumberOfBoxesThatWork = boxesPerTruck; recommendedExtraTruck = "A"; }
                boxesPerTruck = nudPalletsTruckB.Value * nudBoxesTruckB.Value;
                if (boxesLeftOver <= boxesPerTruck && boxesPerTruck < smallestNumberOfBoxesThatWork) { smallestNumberOfBoxesThatWork = boxesPerTruck; recommendedExtraTruck = "B"; }
                boxesPerTruck = nudPalletsTruckC.Value * nudBoxesTruckC.Value;
                if (boxesLeftOver <= boxesPerTruck && boxesPerTruck < smallestNumberOfBoxesThatWork) { smallestNumberOfBoxesThatWork = boxesPerTruck; recommendedExtraTruck = "C"; }
                if (boxesLeftOver == 0)
                {
                    lblResults.Text = $"Results:\r\n - {fullTrucks} Full Trucks";
                }
                else 
                {
                    lblResults.Text = $"Results:\r\n - {fullTrucks} Full Trucks\r\n - 1 Partially filled Truck with:"
                        + $"\r\n    + {fullPalletes} Full Pallets"
                        + $"\r\n    + 1 Partially filled Pallet with {fullBoxes} boxes"
                        + $"\r\n \r\nRecommendation:\r\n Replace the partially filled truck with a(an) {recommendedExtraTruck} Type\r\n Truck for minimal wasted space";
                }
            }
        }
    }

}