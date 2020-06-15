using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // print greeting
            Console.WriteLine("Herzlich Wilkommen bei Hangman");
            // start game (create hidden word, etc.)
            GameState newGame = new GameState();
            newGame.createHW();
            // Start the actual game loop
            newGame.gameStart();
        }
    }
}
