using System;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public static int GetTrans()
        {
            return _transactions;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            Book book30 = new Book();
            book30.SetTrans();
            book30.SetId(30);
            book30.SetTitle("Hachi");
            book30.SetAuthor("Kaneto Shindo");

            Book book40 = new Book();
            Console.WriteLine("Please enter the book ID: ");
            book40.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book40.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book40.SetAuthor(Console.ReadLine());
            book40.SetTrans();

            Book book50 = new Book(50, "Diary of a Wimpy Kid", "Jeff Kinney");
            book50.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int bookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string bookAuthor = Console.ReadLine();
            Book book60 = new Book(bookID, bookTitle, bookAuthor);
            book60.SetTrans();

            displayBooks(book30);
            displayBooks(book40);
            displayBooks(book50);
            displayBooks(book60);

            Console.WriteLine($"\nTotal transactions: {Book.GetTrans()}");
        }

        static void displayBooks(Book book)
        {
            Console.WriteLine("\nBook Information:");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        }
    }
}

