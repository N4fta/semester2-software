using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD___Student_System.Classes
{
    public class Administration
    {
        private List<Person> _persons = new List<Person>();

        public bool AddPerson(Person p) 
        {
            if (GetPerson(p.GetPCN()) == null)
            {
                _persons.Add(p);
                return true;
            }
            else return false;
        }

        public Person? GetPerson(int pcn) { return _persons.Find(p => p.GetPCN() == pcn); }

        public Person[] GetPersons() { return _persons.ToArray(); }
        public Person[] GetPersons(string partialText) { return _persons.Where(p => p.GetName().Contains(partialText)).ToArray(); }
        public Student[] GetStudents() { return _persons.Where(p => p is Student).Cast<Student>().ToArray(); }
        public Student[] GetStudents(string partialText) { return _persons.Where(p => p is Student && p.GetName().Contains(partialText)).Cast<Student>().ToArray(); }
        public Teacher[] GetTeachers() { return _persons.Where(p => p is Teacher).Cast<Teacher>().ToArray(); }
        public Teacher[] GetTeachers(string partialText) { return _persons.Where(p => p is Teacher && p.GetName().Contains(partialText)).Cast<Teacher>().ToArray(); }
    }
}
