using System;
using System.Collections.Generic;

namespace NewImprovedWordle
{
    abstract class Wordle : IWordle
    {
        public string? HiddenWord { get; protected set; }
        public List<string> Words { get; set; } = new List<string>();
        public List<char[]> AlphabetWithColors { get; set; } = new List<char[]>();

        public Wordle()
        {
            foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower())
            {
                AlphabetWithColors.Add(new char[] { letter, 'b' });
            }
        }

        protected virtual void SetHiddenWord()
        {
            Random random = new Random();

            HiddenWord = Words[random.Next(Words.Count)];
        }

        public void UpdateAlphabetColors(char character, char color)
        {
            foreach (char[] letter in AlphabetWithColors)
            {
                if (character == letter[0] && letter[1] != 'g')
                {
                    letter[1] = color;
                }
            }
        }
    }
}
