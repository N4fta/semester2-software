using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Day3_2
{
    public class Course
    {
        // Instance variables     
        private string _name;
        private int _ec;

        //Constructor
        public Course(string name, int ec)
        { 
            this._name = name;
            this._ec = ec;
        }
        public Course(string name)
        {
            this._name = name;
            this._ec = 3;
        }

        // Methods     
        public void SetName(string name)
        { this._name = name; }

        public string GetName()
        { return this._name; }

        public void SetEc(int ec)
        { this._ec = ec; }

        public int GetEc()
        { return this._ec; }

        public override string ToString() 
        {
            return this._name;
        }
    }

}
