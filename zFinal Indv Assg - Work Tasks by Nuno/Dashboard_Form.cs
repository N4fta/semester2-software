using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;
using System.Runtime.Serialization.Formatters.Binary;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Dashboard_Form : Form
    {
        Company company;
        public Dashboard_Form(Company newCompany, string user)
        {
            InitializeComponent();
            this.Text = user;
            company = newCompany;
            cbxDepartment.DataSource = Enum.GetValues(typeof(Departments));
            cbxStatus.DataSource = Enum.GetValues(typeof(Statuses));
            lstBxTasks.DataSource = company.GetTasks();
        }

        private void Dashboard_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void chckBxDepartment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstBxTasks_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btCreateTask_Click(object sender, EventArgs e)
        {
            if (lstBxTasks.SelectedItem != null)
            {
                Task_Form dashboard_Form = new Task_Form(company, (CompanyTask)lstBxTasks.SelectedItem);
                dashboard_Form.ShowDialog();
                lstBxTasks.DataSource = company.GetTasks();
            }
        }

        private void btImportEmployees_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
            else { return; }
            /*

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
            
             */
        }

        private void btExportEmployees_Click(object sender, EventArgs e)
        {
            string fileName;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
            }
            else { return; }
            /*
            
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
            
             */
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string title = "";
            Statuses status = Statuses.All;
            Departments department = Departments.All;
            if (chckBxTitle.Checked) title = txtBxTitle.Text;
            if (chckBxStatus.Checked) status = (Statuses)cbxStatus.SelectedItem;
            if (chckBxDepartment.Checked) department = (Departments)cbxDepartment.SelectedItem;
            lstBxTasks.DataSource = company.GetTasks(title, status, department);
        }
    }
}
