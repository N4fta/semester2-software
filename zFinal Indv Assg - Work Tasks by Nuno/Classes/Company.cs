using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    public class Company
    {
        private string _name = "admin";
        private string _password = "admin";
        private List<Employee> _employees = new List<Employee>();
        private List<CompanyTask> _companyTasks = new List<CompanyTask>();
        private string MOCK_EMPLOYEE_DATA = "./Resources/MOCK_EMPLOYEE_DATA.csv";

        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public List<Employee> Employees { get => _employees; set => _employees = value; }
        public List<CompanyTask> CompanyTasks { get => _companyTasks; set => _companyTasks = value; }

        public bool CheckPassword(string password)
        {
            if (_password == password) return true;
            else return false;
        }
        public bool CreateTask(CompanyTask task)
        {
            return false;
        }
        public bool ImportEmployees(string path = "")
        {
            if (path == "") path = MOCK_EMPLOYEE_DATA;
            if (File.Exists(path))
            {
                //FileStream fileStream = new FileStream(path, FileAccess.Read);
                _employees.Add(new Employee());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
