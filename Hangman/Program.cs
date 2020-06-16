using System;

namespace Hangman
{
    class MainClass
    {
        static string name;
        static int numberOfGuesses;

        public static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Starting game...");
            AskForUsername();
        }

        static string AskForUsername()
        {
            Console.WriteLine("What is your name?");
            return name = Console.ReadLine();
        }

        private static void PlayGame()
        {
            Console.WriteLine("Playing Game");
            DisplayMaskedWord();
            AskForLetter();
        }

        private static void DisplayMaskedWord()
        {
            Console.WriteLine("Display the masked word");
        }

        private static void AskForLetter()
        {
            Console.WriteLine("Ask for letter.");
            numberOfGuesses++;
        }

        private static void EndGame()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine($"Thank you for playing {name}");
            Console.WriteLine($"You made {numberOfGuesses} guesses.");
        }
    }
}
