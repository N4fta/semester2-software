using OOD___Animals___Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD___Animals___Inheritence
{
    public class PetShop
    {
        private List<Animal> _animals = new List<Animal>();

        public PetShop() 
        {
            Dog dog = new Dog("Doggo");
            _animals.Add(dog);
            Cat cat = new Cat("Catty");
            _animals.Add(cat);
            Turtle iWantATurtle = new Turtle("Wise sage", 199);
            _animals.Add(iWantATurtle);
        }
        public void Add(Animal animal)
        {
            _animals.Add(animal);
        }
        public void Remove(Animal animal)
        {
            _animals.Remove(animal);
        }
        public List<Animal> GetList()
        {
            return _animals;
        }
    }
}
