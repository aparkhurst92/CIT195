using System;

namespace Demo
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore book1 = new(1, "Minecraft: The Island", "Max Brooks", 19.99);
            Console.WriteLine(book1);
            Bookstore book2 = new(2, "Pokémon Super Deluxe Essential Handbook", "Scholastic", 9.99);
            Console.WriteLine(book2);
            Bookstore book3 = new(3, "Diary of a Wimpy Villager", "Cube Kid", 12.99);
            Console.WriteLine(book3);
        }
    }
}


