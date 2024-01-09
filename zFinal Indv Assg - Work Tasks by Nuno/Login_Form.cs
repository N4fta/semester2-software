using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    public partial class Login_Form : Form
    {
        Company company;
        public Login_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            company = new Company();

            // Auto-Load Method
            company.Load("Database");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                Employee? user = company.Employees.Find(employee => employee.Email == tbxUsername.Text);
                if (user != null && user.CheckPassword(tbxPassword.Text))
                {
                    company.User = user;
                    Dashboard_Form dashboard_Form = new Dashboard_Form(company);
                    dashboard_Form.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Incorrect username and/or password");
            return;
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            company.Save("Database");
        }
    }
}
