using System.Collections.Generic;
using System;

namespace NewImprovedWordle
{
    class GuessManager
    {
        public List<string> GuessedWords { get; private set; } = new List<string>();

        public int GuessCount { get; private set; } = 0;

        public int MaximumGuesses { get; private set; }

        public bool Win { get; private set; }

        public GuessManager() : this(6)
        {
            
        }

        public GuessManager(int tries)
        {
            MaximumGuesses = tries;
            Win = false;
        }

        public void GuessWord(IWordle wordle, DisplayManager displayManager)
        {
            if(wordle.HiddenWord is null)
            {
                throw new NullReferenceException("The hidden word is never set");
            }

            Console.WriteLine($"Guess a word with {wordle.HiddenWord.Length} letters");

            string guess = Console.ReadLine().ToLower();

            if (guess.Length != wordle.HiddenWord.Length)
            {
                Console.WriteLine($"Please write a word with {wordle.HiddenWord.Length} letters");
                GuessWord(wordle, displayManager);
            }
            else if (!wordle.Words.Contains(guess))
            {
                Console.WriteLine($"Please write a real word");
                GuessWord(wordle, displayManager);
            }
            else
            {
                wordle.Words.Remove(guess);
                GuessedWords.Add(guess);
                GuessCount++;
                Console.Clear();

                foreach (string word in GuessedWords)
                {
                    displayManager.DisplayWordColor(word, wordle);
                }
                Console.WriteLine();

                displayManager.DisplayWordColor(wordle.AlphabetWithColors);

                if (guess == wordle.HiddenWord)
                {
                    Win = true;
                }

                Console.WriteLine();
            }
            
        }

    }
}
