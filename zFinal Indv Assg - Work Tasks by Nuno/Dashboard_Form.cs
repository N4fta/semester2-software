namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
