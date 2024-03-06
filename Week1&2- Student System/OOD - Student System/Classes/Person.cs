using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD___Student_System.Classes
{
    public class Person
    {
        protected string _name;
        protected int _age;
        protected int _pcn;
        protected int _yearsAtSchool;

        public Person(string name, int age, int pcn, int yearsAtSchool)
        {
            _name = name;
            _age = age;
            _pcn = pcn;
            _yearsAtSchool = yearsAtSchool;
        }
        public void CelebrateBirthday()
        {
            _age++;
        }
        public virtual void StartAnotherSchoolyear()
        {
            _yearsAtSchool++;
        }
        public int GetPCN()
        {
            return _pcn;
        }
        public string GetName()
        {  
            return _name; 
        }
        public override string ToString()
        {
            return $"{_name} ({_age} years old) - Years In School: {_yearsAtSchool} - PCN: {_pcn}";
        }
    }

    public class Teacher : Person
    {
        private JobPosition _position;
        private double _salary;

        public Teacher(string name, int age, int pcn, int yearsAtSchool, double salary, JobPosition position = JobPosition.juniorTeacher) : base(name, age, pcn, yearsAtSchool)
        {
            _salary = salary;
            _position = position;
        }
        public override void StartAnotherSchoolyear()
        {
            base.StartAnotherSchoolyear();
            if (_yearsAtSchool%3 == 0)
            {
                _salary *= 1.1;
            }
        }
        public void MakePromotion()
        {
            if (_position != JobPosition.director) _position++;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Position: {_position} - Salary: {_salary.ToString("0.00")}";
        }
    }

    public class Student : Person
    {
        private int _nrOfECs;

        public Student(string name, int age, int pcn, int yearsAtSchool, int nrOfECs) : base(name, age, pcn, yearsAtSchool)
        {
            _nrOfECs = nrOfECs;
        }
        public void AddECs(int n)
        {
            _nrOfECs += n;
        }
        public override string ToString()
        {
            return base.ToString() + $" - NrOfECs: {_nrOfECs}";
        }
    }
}
