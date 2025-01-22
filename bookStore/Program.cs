using System;

namespace bookStore
{
     class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;

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
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book book30 = new Book();
            book30.SetId(30);
            book30.SetTitle("Hachi");
            book30.SetAuthor("Kaneto Shindo");

            Book book40 = new Book();
            Console.WriteLine("Please enter the member ID: ");
            book40.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book40.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book40.SetAuthor(Console.ReadLine());

            Book book50 = new Book(50, "Diary of a Wimpy Kid", "Jeff Kinney");

            Console.WriteLine("Please enter the member ID: ");
            int bookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string bookAuthor = Console.ReadLine();
            Book book60 = new Book(bookID, bookTitle, bookAuthor);

            displayBooks(book30);
            displayBooks(book40);
            displayBooks(book50);
            displayBooks(book60);               
        }
        static void displayBooks(Book book)
            {
                Console.WriteLine("Here's your book information");
                Console.WriteLine($"Member ID: {book.GetId()}");
                Console.WriteLine($"Member Name: {book.GetTitle()}");
                Console.WriteLine($"Author: {book.GetAuthor()}");
            }

    }
}
