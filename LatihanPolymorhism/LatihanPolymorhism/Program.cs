using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            animal.Speak();

            Chicken chicken = new Chicken();
            animal = chicken;
            animal.Speak();

            Dog dog = new Dog();
            animal = dog;
            animal.Speak();

            Console.ReadKey();
        }
    }
}