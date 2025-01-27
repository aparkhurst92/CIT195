using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers do you want to enter?");
        int size = int.Parse(Console.ReadLine());
        int[] collection = new int[size];

        for (int i = 0; i < size; i++)
        {
            collection[i] = r.Next(1,1000);
        }

        Console.WriteLine("The numbers produced:");
        foreach (int number in collection)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Total of the numbers array = {Add(collection)}");
        Console.WriteLine($"Product of the numbers array = {Multiply(collection)}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
