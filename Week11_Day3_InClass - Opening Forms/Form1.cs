using System.Windows.Forms;

namespace Week11_Day3_InClass
{
    public partial class Form1 : Form
    {
        public Form1(string newName)
        {
            InitializeComponent();
            this.Text = newName;

            if (newName == "Default")
            {
                this.listBox1.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                //code for child forms
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != null)
            {
                Form1 newForm = new Form1(listBox1.SelectedItem.ToString());
                newForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ActiveForm == null)
            {
                this.Visible = true;
            }
            else if (ActiveForm.Text == "Default")
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
        }
    }
}