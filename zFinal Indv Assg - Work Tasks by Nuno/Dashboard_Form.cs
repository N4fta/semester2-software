using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Dashboard_Form : Form
    {
        Company company;
        public Dashboard_Form(Company newCompany)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            company = newCompany;
            this.Text = company.User.Email;
            cbxDepartment.DataSource = Enum.GetValues(typeof(Departments));
            cbxStatus.DataSource = Enum.GetValues(typeof(Statuses));
            lstBxTasks.DataSource = company.GetTasks();
            if (!company.User.Admin) btCreateTask.Enabled = false;
        }
        private void Dashboard_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
        private void lstBxTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lstBxTasks.SelectedItem != null)
            {
                Task_Form task_Form = new Task_Form(company, (CompanyTask)lstBxTasks.SelectedItem);
                task_Form.ShowDialog();
                lstBxTasks.DataSource = null;
                lstBxTasks.DataSource = company.GetTasks();
            }
        }
        private void btCreateTask_Click(object sender, EventArgs e)
        {
            Task_Form task_Form = new Task_Form(company);
            task_Form.ShowDialog();
            lstBxTasks.DataSource = null;
            lstBxTasks.DataSource = company.GetTasks();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string title = "";
            Statuses status = Statuses.All;
            Departments department = Departments.All;
            if (chckBxTitle.Checked) title = txtBxTitle.Text;
            if (chckBxStatus.Checked && cbxStatus.SelectedItem != null) status = (Statuses)cbxStatus.SelectedItem;
            if (chckBxDepartment.Checked && cbxDepartment.SelectedItem != null) department = (Departments)cbxDepartment.SelectedItem;
            lstBxTasks.DataSource = null;
            lstBxTasks.DataSource = company.GetTasks(title, status, department);
        }

        private void btImportEmployees_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Choose a file",
                Filter = "CSV files (*.csv)|*.csv",
                DefaultExt = ".csv",
                InitialDirectory = ".\\Resources\\"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                company.Load("CSV", ofd.FileName);
            }
            else return;
        }
        private void btExportEmployees_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Choose a location",
                Filter = "CSV files (*.csv)|*.csv",
                DefaultExt = ".csv",
                InitialDirectory = ".\\Resources\\"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                company.Save("CSV", sfd.FileName);
            }
            else return;

        }
        private void btSaveAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Choose a location",
                Filter = "BF files (*.bf)|*.bf",
                DefaultExt = ".bf",
                InitialDirectory = ".\\Resources\\"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                company.Save("Binary", sfd.FileName);
            }
            else return;

        }
#pragma warning disable SYSLIB0011
        private void btLoadAll_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Choose a file",
                Filter = "BF files (*.bf)|*.bf",
                DefaultExt = ".bf",
                InitialDirectory = ".\\Resources\\"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    company = (Company)bf.Deserialize(fs); // Function in Form since it assigns a new value to company
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
            else return;
        }
#pragma warning restore SYSLIB0011
    }
}
