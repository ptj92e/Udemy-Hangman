using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Player
    {
        public Player(string name)
        {
            this.name = name;
        }

        public string name;
        public int score;
        public List<char> guessedLetters = new List<char>();
    }
}
