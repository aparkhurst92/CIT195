using System;
using System.Collections.Generic;

class UsingCollections
{
    static void UseQueue()
    {
        // Adding members
        Queue<string> animals = new Queue<string>();
        animals.Enqueue("Cat");
        animals.Enqueue("Dog");
        animals.Enqueue("Parrot");
        animals.Enqueue("Hamster");
        animals.Enqueue("Ox");
        
        // Checks for specific item and message
        Console.WriteLine(animals.Contains("Cat") ? "Queue contains Cat" : "Queue does not contain Cat");
        
        animals.Dequeue();
        
        // Counts animals
        Console.WriteLine($"Here are your {animals.Count} members");
        
        // Displays queue without removing anything
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
        Console.WriteLine();
    }

    static void UseStack()
    {
        // Adds to stack
        Stack<string> friends = new Stack<string>();
        friends.Push("Collin");
        friends.Push("Tyson");
        friends.Push("Chunt");
        friends.Push("Lebron");
        friends.Push("Rocket");

        // Checks for variable and sends message
        Console.WriteLine(friends.Contains("Collin") ? "Stack contains Collin" : "Stack does not contain Collin");

        // Removes friend
        friends.Pop();

        Console.WriteLine($"Here are your {friends.Count} friends");
        foreach (var item in friends)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    static void UseLinkedList()
    {
        // Adds to linked list
        string[] movies = { "Nemo", "Cars", "Cinderella", "Wild Robot", "Spiderman" };
        LinkedList<string> moviesList = new LinkedList<string>(movies);
        
        // Gets nodes
        Console.WriteLine("First node: " + moviesList.First.Value);
        Console.WriteLine("Last node: " + moviesList.Last.Value);
        //switches order and removes cinderella
        LinkedListNode<string> targetLocation = moviesList.Find("Cars");
        moviesList.AddAfter(targetLocation, "Pokemon");
        moviesList.Remove("Cinderella");

        Console.WriteLine("Count of items in the list: " + moviesList.Count);
        Console.WriteLine("Items in the linked list:");
        foreach (string movie in moviesList)
        {
            Console.WriteLine(movie);
        }
        Console.WriteLine();
    }
    static void UseDictionary()
    {
        Dictionary<int, string> countries = new Dictionary<int, string>();
        countries[100] = "America";
        countries[200] = "Canada";
        countries[300] = "China";
        countries[400] = "Mexico";
        countries[500] = "Africa";

        // Displaying Keys
        Console.WriteLine("Countries Dictionary Keys");
        foreach (var key in countries.Keys)
        {
            Console.WriteLine($"Key: {key}");
        }
        Console.WriteLine();

        // Display values
        Console.WriteLine("Countries Dictionary Values");
        foreach (var value in countries.Values)
        {
            Console.WriteLine($"Value: {value}");
        }
        Console.WriteLine();

        // Display keys/values
        Console.WriteLine("Countries Dictionary Key/Value Pairs");
        foreach (var pair in countries)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
        Console.WriteLine();

        // Removing China
        countries.Remove(300);
        Console.WriteLine("After Removal of Key 300 (China):");
        Console.WriteLine($"Dictionary count: {countries.Count}");
        Console.WriteLine();
    }
    static void UseHashSet()
    {
        HashSet<string> set1 = new HashSet<string> { "H", "E", "L", "L", "O" };
        HashSet<string> set2 = new HashSet<string> { "I", "A", "M", "H", "A" };
        HashSet<string> set3 = new HashSet<string> { "P", "P", "Y", ":", ")" };

        // Display combined sets
        Console.WriteLine("Combined list of sets:");
        set1.UnionWith(set2);
        set1.UnionWith(set3);
        foreach (var item in set1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Display common elements
        Console.WriteLine("Common elements between set1, set2, and set3:");
        HashSet<string> commonSet = new HashSet<string>(set1);
        commonSet.IntersectWith(set2);
        commonSet.IntersectWith(set3);
        foreach (var item in commonSet)
        {
            Console.WriteLine(item);
        }
    }

    static void Main()
    {
        UseQueue();
        UseStack();
        UseLinkedList();
        UseDictionary();
        UseHashSet();
    }
}




