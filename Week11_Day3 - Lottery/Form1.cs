namespace Week11_Day3_3___Lottery
{
    public partial class Form1 : Form
    {
        Lottery currentLottery;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (nudMaxValue.Value != 0 && nudWantedNumbers.Value != 0 && nudMaxValue.Value >= nudWantedNumbers.Value)
            {
                currentLottery = new Lottery(Convert.ToInt32(nudMaxValue.Value), Convert.ToInt32(nudWantedNumbers.Value));
                groupBox1.Enabled = false;
                btCreate.Enabled = false;
                btNext.Enabled = true;
                btAll.Enabled = true;
                lbDraws.Items.Clear();
            }
            else { MessageBox.Show("Numbers must be bigger than 0\r\nand Max value bigger than ball draws"); }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentLottery.IsLotteryFinished())
            {
                groupBox1.Enabled = true;
                btCreate.Enabled = true;
                btNext.Enabled = false;
                btAll.Enabled = false;
                return;
            }
            lbDraws.Items.Add(currentLottery.DrawNextNumber());
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            // To add all of the Array elements at once we first convert each element of the int[] Array into a string and create a new string[] Array
            // Read Select() method description for the Magic Sauce that makes this all work
            lbDraws.Items.Clear();
            lbDraws.Items.AddRange(currentLottery.DrawAllNumbers().Select(x => x.ToString()).ToArray());
            groupBox1.Enabled = true;
            btCreate.Enabled = true;
            btNext.Enabled = false;
            btAll.Enabled = false;
        }
    }
}