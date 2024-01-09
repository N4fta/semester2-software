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
#pragma warning disable SYSLIB0011
            if (true)  // Auto-load binary save
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream("./Resources/AllMightySave.bf", FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    company = (Company)bf.Deserialize(fs); // Function in Form since it assigns a new value to company
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't find saveFile");
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
#pragma warning restore SYSLIB0011
            // Auto-load example CSV
            //company.ImportCSV();
            company.Employees.Add(new Employee("Test", "Gmail", "test@gmail.com", "12345"));
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
    }
}
