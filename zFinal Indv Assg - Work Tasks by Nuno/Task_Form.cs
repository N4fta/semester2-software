using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Task_Form : Form
    {
        CompanyTask task;
        public Task_Form(Company company, CompanyTask newTask = null)
        {
            InitializeComponent();
            chkLstBxEmployees.Items.AddRange(company.Employees.ToArray());
            cmbBxStatus.DataSource = Enum.GetValues(typeof(Statuses));
            if (newTask != null)
            {
                task = newTask;
                this.Text = task.Title;
                if (task.Departments == null) chkBxAll.Checked = true;
                else
                {
                    if (task.Departments.Contains(Departments.HumanResources)) chkBxHumanResources.Checked = true;
                    if (task.Departments.Contains(Departments.Marketing)) chkBxMarketing.Checked = true;
                    if (task.Departments.Contains(Departments.ResearchAndDevelopment)) chkBxResearchAndDevelopment.Checked = true;
                    if (task.Departments.Contains(Departments.Sales)) chkBxSales.Checked = true;
                    if (task.Departments.Contains(Departments.Support)) chkBxSupport.Checked = true;
                }
                cmbBxStatus.SelectedItem = task.Status;
                dtTmPckDeadline.Value = Convert.ToDateTime(task.Deadline);
                rchTxtBxDescription.Text = task.Description;
            }
            else
            {
                this.Text = "New Task";
            }
        }
        private void chkBxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxAll.Checked)
            {
                chkBxHumanResources.Checked = false;
                chkBxMarketing.Checked = false;
                chkBxResearchAndDevelopment.Checked = false;
                chkBxSales.Checked = false;
                chkBxSupport.Checked = false;
            }
        }
        private void chkBxResearchAndDevelopment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxAll.Checked) chkBxAll.Checked = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxTitle.Text))
            {
                MessageBox.Show("Please add a Title");
                return;
            }
            task
        }
    }
}
