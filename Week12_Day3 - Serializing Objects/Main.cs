using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace Week12_Day3___Serializing_Objects
{
    public enum BreadType
    {
        CIABATTA,
        FOCACCIA,
        SOUR_DOUGH,
        RYE,
        WHOLE_WHEAT
    }

    public partial class Main : Form
    {
        Bakery bakery;

        public Main()
        {
            InitializeComponent();
            cbxBreadFilter.DataSource = Enum.GetValues(typeof(BreadType));
            bakery = new Bakery("Mario's Bakery");
        }

        private void btnAddNewSandwich_Click(object sender, EventArgs e)
        {
            Form AddSandwichForm = new Add_New_Sandwich(bakery);
            AddSandwichForm.ShowDialog();
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            lbxMenu.DataSource = bakery.GetAvailableSandwiches();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string fileName;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
            }
            else { return; }


            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, bakery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
            else { return; }

            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                bakery = (Bakery)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            lbxMenu.DataSource = bakery.GetAvailableSandwiches();
        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedItems == null)
            {
                return;
            }
            lblSandwichData.Text = ((Sandwich)lbxMenu.SelectedItem).GetInfo();
        }

        private void btnSellSelectedSandwich_Click(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedItems == null)
            {
                return;
            }
            MessageBox.Show(bakery.SellSandwich(((Sandwich)lbxMenu.SelectedItem)).ToString("F") + " euros");
        }

        private void btnShowTotalRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total revenue is {bakery.CalculateRevenue(chbxIncludeVAT.Checked).ToString("F")} euros");
        }

    }
}