using System;

namespace Inheritance
{
    class Animal
    {
        public string name;

        public Animal()
        {
            name = "";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // Derived class of Animal
    class Cat : Animal
    {
        public string type;
        public string color;
        public double age;
        public double weight;

        // Default constructor
        public Cat() : base() // Calls the Animal class constructor
        {
            type = "Unknown";
            color = "Unknown";
            age = 0;
            weight = 0;
        }

        // Parameterized constructor
        public Cat(string name, string type, string color, double age, double weight) : base(name)
        {
            this.type = type;
            this.color = color;
            this.age = age;
            this.weight = weight;
        }

        public void displayCatInfo()
        {
            Console.WriteLine("Cat Information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
        }
    }
    // Derived class of Animal
    class Rabbit : Animal
    {
        public int age;
        public double height;
        public double weight;

        // Default constructor
        public Rabbit() : base()
        {
            age = 0;
            height = 0;
            weight = 0;
        }

        // Parameterized constructor
        public Rabbit(string name, int age, double height, double weight) : base(name)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public void displayRabbitInfo()
        {
            Console.WriteLine("Rabbit Information.");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            Console.WriteLine();

            // Derived class object using default constructor
            Cat kitten = new Cat();
            kitten.name = "Meowy";
            kitten.type = "Cat";
            kitten.color = "White";
            kitten.age = 0.5;
            kitten.weight = 2.0;
            kitten.displayCatInfo();
            Console.WriteLine();

            Rabbit hare = new Rabbit();
            hare.name = "O'Hare";
            hare.age = 1;
            hare.height = 4.5;
            hare.weight = 2;
            hare.displayRabbitInfo();
            Console.WriteLine();

            // Derived class object using parameterized constructor
            Cat purr = new Cat("Purr", "Cat", "Black", 4.5, 3);
            purr.displayCatInfo();
            Console.WriteLine();

            Rabbit rabby = new Rabbit("Thumper", 9, 3.75, 3);
            rabby.displayRabbitInfo();
            Console.WriteLine();

            Console.ReadLine(); // Pauses end of program display
        }
    }
}



