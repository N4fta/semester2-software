using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    public class Employee
    {
        private static int _idSeeder = 0;
        private int _id;
        private string _ssn;
        private string _firstName;
        private string _lastName;
        private string _gender;
        private string _streetName;
        private int _streetNumber;
        private string _zipCode;
        private string _city;
        private string _email;
        private string _password;

        public Employee()
        {
            _id = _idSeeder++;
            _email = "test@gmail.com";
            _password = "password";
        }
        public Employee(string ssn, string firstName, string lastName, string gender, string streetName, int streetNumber, string zipCode, string city, string email, string password)
        {
            _id = _idSeeder++;
            _ssn = ssn;
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
            _streetName = streetName;
            _streetNumber = streetNumber;
            _zipCode = zipCode;
            _city = city;
            _email = email;
            _password = password;
        }
        public int Id { get => _id; }
        public string Ssn { get => _ssn; set => _ssn = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string StreetName { get => _streetName; set => _streetName = value; }
        public int StreetNumber { get => _streetNumber; set => _streetNumber = value; }
        public string ZipCode { get => _zipCode; set => _zipCode = value; }
        public string City { get => _city; set => _city = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { set => _password = value; }
        public CompanyTask[] GetTasks(List<CompanyTask> tasks, string filter = "")
        {
            return tasks.Where(task => task.ToString().Contains(filter)).ToArray();
        }
        public bool CheckPassword(string password)
        {
            if (_password == password) return true;
            else return false;
        }
    }
}
