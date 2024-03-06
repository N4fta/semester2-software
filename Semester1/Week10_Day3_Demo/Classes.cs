using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Day_3
{
    public class Students
    {

        private string name = "";
        private double grade = 0;

        public void SetGrade(double newGrade)
        {
            this.grade = newGrade;
        }
        public void SetName(string newName)
        {
            this.name = newName;
        }
        public double GetGrade()
        {
            return this.grade;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetInfo()
        {
            return $"{name} - {grade}";

        }
        public bool StudentHasPassed()
        {
            return false;
        }
    }

}
