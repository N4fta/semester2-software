using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    [Serializable]
    public class Employee
    {
        [Ignore]
        private static int[] _takenIDs = new int[150];
        
        [Name("id")]
        public int Id { get; set; } = 1;
        [Name("ssn")]
        public string Ssn { get; set; } = "";
        [Name("first_name")]
        public string FirstName { get; set; } = "";
        [Name("last_name")]
        public string LastName { get; set; } = "";
        [Name("gender")]
        public string Gender { get; set; } = "";
        [Name("street_name")]
        public string StreetName { get; set; } = "";
        [Name("street_number")]
        public int StreetNumber { get; set; } = 0;
        [Name("zipcode")]
        public string ZipCode { get; set; } = "";
        [Name("city")]
        public string City { get; set; } = "";
        [Name("email")]
        public string Email { get; set; } = "";
        public Departments Department { get; set; } = Departments.All;
        [Ignore]
        public string Password { get; set; } = "11111";
        [Ignore]
        public bool Admin { get; } = false;

        public Employee(string first_name, string last_name, string email, string password, bool admin = false)
        {
            while (Array.IndexOf(_takenIDs, Id) != -1) Id++;
            FirstName = first_name;
            LastName = last_name;
            Email = email;
            Password = password;
            Admin = admin;
        }
        public Employee(int id, string ssn, string first_name, string last_name, string gender, string street_name, int street_number, string zipcode, string city, string email, Departments Department, string password = "54321", bool admin = false)
        {
            if (_takenIDs.Contains(id)) MessageBox.Show("Failed to assign ID to new Employee");
            else
            {
                _takenIDs[Array.IndexOf(_takenIDs, 0)] = id;
                Id = id;
            }
            Ssn = ssn;
            FirstName = first_name;
            LastName = last_name;
            Gender = gender;
            StreetName = street_name;
            StreetNumber = street_number;
            ZipCode = zipcode;
            City = city;
            Email = email;
            this.Department = Department;
            Password = password;
            Admin = admin;
        }
        public static void ResetTakenIDs()
        {
            for (int i = 0; i < 150; i++) _takenIDs[i] = 0;
        }

        public bool CheckPassword(string password)
        {
            if (Password == password) return true;
            else return false;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
