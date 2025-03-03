﻿using System;

namespace delegatesAndEvents
{
     // create a delegate
     public delegate void raceDel();

    public class Race
    {
        // create a delegate event object
        public delegate void Notify(int winner);
        public event Notify Raceee;

        public void Racing(int contestants, int laps)
        {
            Console.WriteLine("Ready\nSet\nGo!");
            Random r = new Random();
            int[] participants = new int[contestants];
            bool done = false;
            int champ = -1;
            // first to finish specified number of laps wins
            while (!done)
            {
                for (int i = 0; i < contestants; i++)
                {

                    if (participants[i] <= laps)
                    {
                        participants[i] += r.Next(1, 5);
                    }
                    else
                    {
                        champ = i;
                        done = true;
                        continue;
                    }
                }

            }

            TheWinner(champ);
        }
        private void TheWinner(int champ)
        {
            Console.WriteLine("We have a winner!");
            // invoke the delegate event object and pass champ to the method
            Raceee?.Invoke(champ);

        }
    }
    class Program
    {
        public static void Main()
        {
            // create a class object
            Race round1 = new Race();
            // register with the footRace event
            round1.Raceee += footRace;
            // trigger the event
            round1.Racing(5, 10);
            // register with the carRace event
            round1.Raceee += carRace;
            //trigger the event
            round1.Racing(3, 5);
            // register a bike race event using a lambda expression
            round1.Raceee += (winner) => Console.WriteLine($"Biker {winner} is the winner.");
            // trigger the event
            round1.Racing(4, 8);
        }

        // event handlers
        public static void carRace(int winner)
        {
            Console.WriteLine($"Car number {winner} is the winner.");
        }
        public static void footRace(int winner)
        {
            Console.WriteLine($"Racer number {winner} is the winner.");
        }
    }
}
