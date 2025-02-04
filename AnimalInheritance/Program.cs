using System;

namespace Inheritance
{
    // Base Class
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; // accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    // Derived class
    class Hamster : Animal
    {
        public string breed;  // accessible from any class
        public double height; // accessible from any class
        public double weight; // accessible from any class

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public override string getName()
        {
            return base.getName();
        }

        public override string getType()
        {
            return type;
        }

        public void displayHamsterInfo()
        {
            Console.WriteLine("Hamster Information");
            Console.WriteLine($"Name= {getName()}");
            Console.WriteLine($"Type= {getType()}");
            Console.WriteLine($"Color= {color}");
            Console.WriteLine($"Breed= {breed}");
            Console.WriteLine($"Height= {height} Hands");
            Console.WriteLine($"Weight= {weight}");
        }
    }

    // Derived class Dog
    class Cat : Animal
    {
        public string breed;  // accessible from any class
        protected int age;  // accessible from derived classes

        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }

        // Access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // Access type directly because it is protected and this is a derived class
        public override string getType()
        {
            return type;
        }

        public virtual string sound()
        {
            return "meow a lot";
        }

        // Display Dog info
        public void displayCatInfo()
        {
            Console.WriteLine("Animal Information");
            Console.WriteLine($"Name= {getName()}");
            Console.WriteLine($"Type= {getType()}");
            Console.WriteLine($"Color= {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object of the base class Animal
            Cat kitty1 = new Cat();
            kitty1.setName("Meowy");
            kitty1.setType("Cat");
            kitty1.color = "White";
            kitty1.displayCatInfo();
            Console.WriteLine();

            Hamster hammy1 = new Hamster();
            hammy1.setName("Pipsqueak");
            hammy1.setType("Hamster");
            hammy1.color = "Brown";
            hammy1.setBreed("Guniea Pig");
            hammy1.setHeight(7);
            hammy1.setWeight(1500);
            hammy1.displayHamsterInfo();

            Console.ReadLine(); // Pauses end of program display
        }
    }
}

