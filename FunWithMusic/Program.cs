using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            HipHop,
            Rock,
            Metal,
            Rap,
            Electronic
        }

        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private double _Length;
            private Genre? _Genre;

            public Music(string title, string artist, string album, double length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }

            public void setTitle(string title)
            {
                _Title = title;
            }

            public void setLength(double length)
            {
                _Length = length;
            }

            public string Display()
            {
                return "Title: " + _Title + "\nArtist: " + _Artist +
                       "\nAlbum: " + _Album + "\nLength: " + _Length + " minutes" +
                       "\nGenre: " + _Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the song title:");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Who is the artist?:");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("What album is it on?:");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("What is the song length?:");
            double tempLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Select the genre of the song:");
            Console.WriteLine("H - HipHop\nR - Rock\nM - Metal\nP - Rap\nE - Electronic");
            Genre tempGenre = Genre.HipHop;
            char genreInput = char.ToUpper(char.Parse(Console.ReadLine()));

            switch (genreInput)
            {
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'P':
                    tempGenre = Genre.Rap;
                    break;
                case 'E':
                    tempGenre = Genre.Electronic;
                    break;
                default:
                    Console.WriteLine("Invalid genre. Defaulting to HipHop.");
                    break;
            }

            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music newMusic = music;
            newMusic.setTitle("Overdrive");
            newMusic.setLength(2.5);
            Console.WriteLine("\nHere's song #2:");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine("\nHere's song #1:");
            Console.WriteLine($"{music.Display()}");
        }
    }
}

