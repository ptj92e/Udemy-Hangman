using System;
using System.Collections.Generic;
using System.IO;

namespace Hangman
{
    class MainClass
    {
        static string correctWord;
        static char[] letters;
        static Player player;
        
        public static void Main(string[] args)
        {
            try
            {
                StartGame();
                PlayGame();
                EndGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Oops, something went wrong...");
            }
        }

        private static void StartGame()
        {
            string[] words;

            try
            {
                string path = "/Users/phillipjones/Desktop/Words.txt";
                Console.WriteLine(path);
                words = File.ReadAllLines(path);
            }
            catch
            {
                words = new string[] { "tree", "dog", "cat" };
            }

            Random random = new Random();

            correctWord = words[random.Next(0, words.Length)];

            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
                letters[i] = '-';

            AskForUsername();
        }

        static void AskForUsername()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();

            if (input.Length >= 2)
                player = new Player(input);
            else
            {
                Console.WriteLine("Your name should be more than 1 character long.");
                AskForUsername();
            }
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
                    player.Score++;
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

            var letter = input[0];

            if (!player.GuessedLetters.Contains(letter))
                player.GuessedLetters.Add(letter);

            return letter;
        }

        private static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Congratulations!");
            Console.WriteLine($"Thank you for playing {player.Name}");
            Console.WriteLine($"You made {player.GuessedLetters.Count} guesses. Score: {player.Score}");
        }
    }
}
