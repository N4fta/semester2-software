using OOD___Animals___Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOD___Animals___Inheritance
{

    public class Animal
    {
        protected string _name;
        protected int _age;

        public Animal(string name) : this(name, 1)
        {
        }
        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public virtual void CelebrateBirthday()
        {
            _age ++;
        }
        public override string ToString()
        {
            return $"{_name}({_age} year)";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public Cat(string name, int age) : base(name, age) { }
        public override void CelebrateBirthday()
        {
            if (_age < 25)
            {
                _age++;
            }
            else if (!_name.Contains(" :( ")) _name += " :( ";
        }
        public override string ToString()
        {
            return "Cat: " + base.ToString();
        }
    }
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public Dog(string name, int age) : base(name, age) { }
        public override void CelebrateBirthday()
        {
            if (_age < 20)
            {
                _age++;
            }
            else if (!_name.Contains(" :( ")) _name += " :( ";
        }
        public override string ToString()
        {
            return "Dog: " + base.ToString();
        }
    }
    public class Turtle : Animal
    {
        public Turtle(string name) : base(name) { }
        public Turtle(string name, int age) : base(name, age) { }
        public override void CelebrateBirthday()
        {
            if (_age < 200)
            {
                _age++;
            }
            else if (!_name.Contains(" :( ")) _name += " :( ";
        }
        public override string ToString()
        {
            return "Turtle: " + base.ToString();
        }
    }
}
