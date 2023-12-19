using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Day1___Extending_Student_Group
{
    public class Member
    {
        private int? _studentNumber;
        private string _name;

        public Member(string name)
        {
            _name = name;
        }
        public Member(string name, int studentNumber)
        {
            if (studentNumber == 100000)
            {
                _name = name;
                return;
            }
            _name = name;
            _studentNumber = studentNumber;

        }

        public int? StudentNumber { get => _studentNumber; }
        public string Name { get => _name; }

        public string GetInfo()
        {
            if (StudentNumber == null)
            {
                return Name;
            }
            
            return $"{Name} (nr. {StudentNumber})";
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
