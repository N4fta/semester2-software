namespace Day2_Demo
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string firstName = txtbxName.Text;
            //MessageBox.Show(txtbxName.Text);
            string message = "Hello " + firstName + "!";
            lblMessage.Text = message;
        }
    }
}