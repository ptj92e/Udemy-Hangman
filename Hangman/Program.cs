using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Starting Game");
            AskForUsername();
        }

        private static void AskForUsername()
        {
            Console.WriteLine("Asking User For Name");
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
        }

        private static void EndGame()
        {
            Console.WriteLine("Game Over");
        }
    }
}
