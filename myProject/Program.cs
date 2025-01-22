using System;

namespace Fortnite
{
    class fortniteStats
    {
        private int _Username;
        private string _Gamemode;
        private int _Kills;
        private static int _Victorys = 0;

        public fortniteStats()
        {
            _Username = 0;
            _Gamemode = "";
            _Kills = 0;
        }

        public fortniteStats(int username, string gamemode, int kills)
        {
            _Username = username;
            _Gamemode = gamemode;
            _Kills = kills;
        }

        public int GetUsername()
        {
            return _Username;
        }

        public void SetUsername(int username)
        {
            _Username = username;
        }

        public string GetGamemode()
        {
            return _Gamemode;
        }

        public void SetGamemode(string gamemode)
        {
            _Gamemode = gamemode;
        }

        public int GetKills()
        {
            return _Kills;
        }

        public void SetKills(int kills)
        {
            _Kills = kills;
        }

        public void SetVictory()
        {
            _Victorys++;
        }

        public static int GetVictorys()
        {
            return _Victorys;
        }
    }

    class realStats
    {
        static void Main(string[] args)
        {
            fortniteStats player1 = new fortniteStats();
            player1.SetUsername(1);
            player1.SetGamemode("Solo");
            player1.SetKills(2);
            player1.SetVictory();

            fortniteStats player2 = new fortniteStats();
            Console.WriteLine("Please enter the Username: ");
            player2.SetUsername(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Gamemode: ");
            player2.SetGamemode(Console.ReadLine());
            Console.WriteLine("Please enter the Kills: ");
            player2.SetKills(int.Parse(Console.ReadLine()));
            player2.SetVictory();

            fortniteStats player3 = new fortniteStats(3, "Squads", 18);
            player3.SetVictory();

            Console.WriteLine("Please enter the Username: ");
            int username = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Gamemode: ");
            string gamemode = Console.ReadLine();
            Console.WriteLine("Please enter the Kills: ");
            int kills = int.Parse(Console.ReadLine());
            fortniteStats player4 = new fortniteStats(username, gamemode, kills);
            player4.SetVictory();

            displayStats(player1);
            displayStats(player2);
            displayStats(player3);
            displayStats(player4);

            Console.WriteLine($"\nTotal Victorys: {fortniteStats.GetVictorys()}");
        }

        static void displayStats(fortniteStats stats)
        {
            Console.WriteLine("\nPlayer Stats:");
            Console.WriteLine($"Username: {stats.GetUsername()}");
            Console.WriteLine($"Gamemode: {stats.GetGamemode()}");
            Console.WriteLine($"Kills: {stats.GetKills()}");
        }
    }
}


