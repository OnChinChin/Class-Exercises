using System;
using System.Collections;

namespace AIE_23_Animals
{
    class Program
    {
        class Person
        {
            public void FeedAnimal(Animal animal)
            {
                animal.EatFood();
            }
        }

        class Animal
        {
            public string name = "";

            // Constructor
            public Animal(string name)
            {
                this.name = name;
            }

            public virtual void MakeNoise()
            {
                Console.WriteLine(name + ": makes noise");
            }

            // Added the EatFood method
            public virtual void EatFood()
            {
                MakeNoise();
            }
        }

        class Dog : Animal
        {
            // dog constructor
            public Dog() : base("dog")
            {

            }
            public override void MakeNoise()
            {
                Console.WriteLine("woof woof woof");
                //base.makenoise(); // calls the animal.makenoise method
            }
        }

        class Cat : Animal
        {
            // dog constructor
            public Cat() : base("Cat")
            {

            }
            public override void MakeNoise()
            {
                Console.WriteLine("meow meow meow");
                //base.makenoise(); // calls the animal.makenoise method
            }
        }

        class Bird : Animal
        {
            // dog constructor
            public Bird() : base("bird")
            {

            }

            public override void EatFood()
            {
                MakeNoise();
                Fly();
            }

            public void Fly()
            {
                Console.WriteLine("Flap Flap");
            }
        }


        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Bird());

            foreach (var a in animals)
                a.MakeNoise();


            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal bird = new Bird();

            Person bob = new Person();
            bob.FeedAnimal(dog);    // What should be written to console?
            bob.FeedAnimal(cat);    // What should be written to console?
            bob.FeedAnimal(bird);   // What should be written to console?

        }
    }
}
