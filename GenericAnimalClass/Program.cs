using System;

public class Animal<T>
{
    public T data;

    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Fido");

        Animal<string> animalHabitat = new Animal<string>("Grassland");

        Animal<int> averageLifespan = new Animal<int>(10);

        Animal<bool> endangered = new Animal<bool>(true);

        Animal<bool> extinct = new Animal<bool>(false);
    }
}
