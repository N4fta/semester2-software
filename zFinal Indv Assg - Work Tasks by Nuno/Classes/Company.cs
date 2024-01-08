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
        public List<Employee> Employees { get => _employees; }
        public List<CompanyTask> CompanyTasks { get => _companyTasks; }

        public bool CheckPassword(string password)
        {
            if (_password == password) return true;
            else return false;
        }
        public bool CreateTask(CompanyTask task)
        {
            return false;
        }
        public CompanyTask[] GetTasks(string title = "", Statuses status = Statuses.All, Departments department = Departments.All)
        {
            List<CompanyTask> result = _companyTasks;

            if (!string.IsNullOrWhiteSpace(title))
            {
                result = result.Where(task => task.Title.Contains(title)).ToList();
            }
            if (status != Statuses.All)
            {
                result = result.Where(task => task.Status == status).ToList();
            }
            if (department != Departments.All)
            {
                result = result.Where(task => task.Departments != null && task.Departments.Contains(department)).ToList();
            }
            return result.ToArray();
        }
        public bool ImportEmployees(string path = "")
        {
            if (path == "") path = MOCK_EMPLOYEE_DATA;
            if (File.Exists(path))
            {
                //FileStream fileStream = new FileStream(path, FileAccess.Read);
                _employees.Add(new Employee("test@gmail.com", "12345"));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
