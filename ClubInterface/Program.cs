using System;
namespace Animals
{
    interface IAnimals
    {
        //Properties
        int Id { get; set; }
        string Name { get; set; }
        string Species { get; set; }

        //Methods
        string AnimalInfo();
    }
    class Program
    {
        class Cat : IAnimals
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Species { get; set; }
            public string Breed { get; set; }
            public int Age { get; set; }

            public Cat()
            {
                Id = 0;
                Name = string.Empty;
                Species = "Cat";
                Breed = string.Empty;
                Age = 0;
            }
            public Cat(int id, string name, string breed, int age)
            {
                Id = id;
                Name = name;
                Species = "Cat";
                Breed = breed;
                Age = age;
            }

            public string AnimalInfo()
            {
                return Name + " " + Species;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Species: {Species}");
                Console.WriteLine($"Breed: {Breed}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Info: {AnimalInfo()}");
            }
        }
        static void Main(string[] args)
        {
            // Worker object created using parameterized constructor
            Cat meowy = new Cat(1, "Meowy", "Callico", 6);
            meowy.DisplayInfo();
            Console.WriteLine();

            //Worker object created using the default constructor
            //values are assigned using properties
            Cat tom = new Cat();
            tom.Id = 3;
            tom.Name = "Tom";
            tom.Breed = "Persian";
            tom.Age = 2;
            tom.DisplayInfo();
            Console.WriteLine();

        }
    }
}