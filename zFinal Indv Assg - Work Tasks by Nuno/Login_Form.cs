using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Login_Form : Form
    {
        Company company;
        public Login_Form(Company newCompany)
        {
            InitializeComponent();
            company = newCompany;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                if (tbxUsername.Text ==  "admin" && company.CheckPassword(tbxPassword.Text))
                {
                    Dashboard_Form dashboard_Form = new Dashboard_Form();
                    dashboard_Form.Show();
                    this.Hide();
                    return;
                }
                if (company.Employees.Find(employee => employee.Email == tbxUsername.Text)!=null)
                {
                    Dashboard_Form dashboard_Form = new Dashboard_Form();
                    dashboard_Form.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Incorrect username and/or password");
            return;
        }
    }
}
