using System;

namespace Indexer_example1
{
    class Program
    {
        public const int Size = 15;  // global variable

        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // Constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            // Indexer to get and set members
            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < Size)
                    {
                        return Members[index];
                    }
                    else
                    {
                        return "Invalid index";
                    }
                }
                set
                {
                    if (index >= 0 && index < Size)
                    {
                        Members[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();
            bool end = false;

            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club member do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }

                Console.WriteLine("Enter the name of the club member");
                club[sub - 1] = Console.ReadLine();

                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }

            Console.WriteLine("What is the club's type?");
            club.ClubType = Console.ReadLine();
            Console.WriteLine("What is the club's location?");
            club.ClubLocation = Console.ReadLine();
            Console.WriteLine("What is the meeting date?");
            club.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is information on the club:");
            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Location: {club.ClubLocation}");
            Console.WriteLine($"Meeting Date: {club.MeetingDate}");
            Console.WriteLine("Club Members:");

            for (int i = 0; i < Size; i++)
            {
                if (!string.IsNullOrEmpty(club[i]))
                    Console.WriteLine(club[i]);
            }
        }
    }
}






