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
        Company company;
        CompanyTask task;
        public Task_Form(Company company, CompanyTask newTask = null)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            chkLstBxEmployees.Items.AddRange(company.Employees.ToArray());
            cmbBxStatus.DataSource = Enum.GetValues(typeof(Statuses));
            this.company = company;

            if (!company.User.Admin)
            {
                txtBxTitle.Enabled = false;
                chkBxAll.Enabled = false;
                chkBxHumanResources.Enabled = false;
                chkBxMarketing.Enabled = false;
                chkBxResearchAndDevelopment.Enabled = false;
                chkBxSales.Enabled = false;
                chkBxSupport.Enabled = false;
                dtTmPckDeadline.Enabled = false;
                rchTxtBxDescription.Enabled = false;
                chkLstBxEmployees.Enabled = false;
                btRemove.Enabled = false;
            }

            if (newTask == null)
            {
                this.Text = "New Task";
                return;
            }

            task = newTask;
            this.Text = task.Title;
            if (task.Departments == null) chkBxAll.Checked = true;
            else
            {
                if (task.Departments.Contains(Departments.HumanResources)) chkBxHumanResources.Checked = true;
                if (task.Departments.Contains(Departments.Marketing)) chkBxMarketing.Checked = true;
                if (task.Departments.Contains(Departments.ResearchandDevelopment)) chkBxResearchAndDevelopment.Checked = true;
                if (task.Departments.Contains(Departments.Sales)) chkBxSales.Checked = true;
                if (task.Departments.Contains(Departments.Support)) chkBxSupport.Checked = true;
            }
            txtBxTitle.Text = task.Title;
            cmbBxStatus.SelectedItem = task.Status;
            dtTmPckDeadline.Value = task.Deadline;
            rchTxtBxDescription.Text = task.Description;
            foreach (Employee employee in task.Employees)
            {
                try
                {
                    chkLstBxEmployees.SetItemChecked(chkLstBxEmployees.Items.IndexOf(employee), true);
                }
                catch
                {
                    // Employee not in Employee list
                }
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
            if ((Statuses)cmbBxStatus.SelectedItem == Statuses.All)
            {
                MessageBox.Show("Please choose a Status");
                return;
            }
            if (chkBxHumanResources.Checked == false && chkBxMarketing.Checked == false && chkBxResearchAndDevelopment.Checked == false && chkBxSales.Checked == false && chkBxSupport.Checked == false)
            {
                MessageBox.Show("Please add at least one Department");
                return;
            }
            List<Departments> departments = new List<Departments>();
            if (chkBxHumanResources.Checked) departments.Add(Departments.HumanResources);
            if (chkBxMarketing.Checked) departments.Add(Departments.Marketing);
            if (chkBxSales.Checked) departments.Add(Departments.Sales);
            if (chkBxSupport.Checked) departments.Add(Departments.Support);
            if (chkBxResearchAndDevelopment.Checked) departments.Add(Departments.ResearchandDevelopment);

            if (chkLstBxEmployees.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please add at least one Employee");
                return;
            }
            List<Employee> employees = new List<Employee>();
            foreach (Employee employee in chkLstBxEmployees.CheckedItems) employees.Add((Employee)employee);
            CompanyTask newTask = new CompanyTask(txtBxTitle.Text, departments, (Statuses)cmbBxStatus.SelectedItem, dtTmPckDeadline.Value, employees, rchTxtBxDescription.Text);
            if (this.Text != "New Task")
            {
                CompanyTask? oldTask = company.CompanyTasks.Find(x => x.Title == this.Text);
                company.CompanyTasks.Remove(oldTask);
                company.CompanyTasks.Add(newTask);
            }
            else company.CompanyTasks.Add(newTask);

            // Generating string representation of new Task
            string message = $"Title: ({newTask.Id}) {newTask.Title}" +
                $"\r\nStatus: {newTask.Status}" +
                $"\r\nDeadline: {newTask.Deadline}" +
                $"\r\nDescription: {newTask.Description}" +
                "\r\nDepartments: ";
            foreach (Departments department in newTask.Departments) message += department.ToString() + ", ";
            message += "\r\nEmployees: ";
            foreach (Employee employee in newTask.Employees) message += employee.ToString() + ", ";
            MessageBox.Show(message);

            Close();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if ((Statuses)cmbBxStatus.SelectedItem == Statuses.Open && chkLstBxEmployees.CheckedItems.Count <= 0)
            {
                CompanyTask? oldTask = company.CompanyTasks.Find(x => x.Title == this.Text);
                company.CompanyTasks.Remove(oldTask);
                Close();
            }
            else
            {
                MessageBox.Show("Only Tasks with Open status and 0 employees can be removed");
            }
            
        }
    }
}
