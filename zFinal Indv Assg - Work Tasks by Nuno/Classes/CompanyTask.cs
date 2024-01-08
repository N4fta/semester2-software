using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    public class CompanyTask
    {
        private static int _idSeeder = 0;
        private int _id;
        private string _title;
        private List<Departments> _departments;
        private Statuses _status;
        private string _deadline;
        private List<Employee> _employees;
        private string _description;

        public CompanyTask(string title) 
        { 
            _id = _idSeeder++;
            _title = title;
        }
        public CompanyTask(string title, List<Departments> departments, Statuses status, string deadline, List<Employee> employees, string description)
        {
            _id = _idSeeder++;
            _title = title;
            _departments = departments;
            _status = status;
            _deadline = deadline;
            _employees = employees;
            _description = description;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public List<Departments> Departments { get => _departments; set => _departments = value; }
        public Statuses Status { get => _status; set => _status = value; }
        public string Deadline { get => _deadline; set => _deadline = value; }
        public List<Employee> Employees { get => _employees; set => _employees = value; }
        public string Description { get => _description; set => _description = value; }

        public override string? ToString()
        {
            return _title;
        }
    }
}
