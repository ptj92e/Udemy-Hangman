using System;

namespace Hangman
{
    class MainClass
    {
        static string name;
        static int numberOfGuesses;
        static string correctWord = "hangman";
        static char[] letters;

        public static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
                letters[i] = '-';

            AskForUsername();
        }

        static string AskForUsername()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();

            if (input.Length >= 2)
                return name = input;
            else
                Console.WriteLine("Your name should be more than 2 characters.");
                return AskForUsername();
        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters));
        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if(guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                }
            }
        }

        private static void DisplayMaskedWord()
        {
            foreach (char c in letters)
            {
                Console.Write(c);
            }
        }

        private static char AskForLetter()
        {
            string input;
            do
            {
                Console.WriteLine("Enter a letter:");
                input = Console.ReadLine();
            } while (input.Length != 1);

            numberOfGuesses++;

            return input[0];
        }

        private static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine($"Thank you for playing {name}");
            Console.WriteLine($"You made {numberOfGuesses} guesses.");
        }
    }
}
