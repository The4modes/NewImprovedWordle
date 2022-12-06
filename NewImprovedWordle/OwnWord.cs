using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewImprovedWordle
{
    class OwnWord : Wordle
    {
        public OwnWord()
        {
            Words = ChooseAvailableWords();

            if (Words.Count == 0)
            {
                throw new NotImplementedException();
            }

            SetHiddenWord();
        }

        protected override void SetHiddenWord()
        {
            Console.WriteLine("Write the word you want the other player to guess");

            string choice = Console.ReadLine().ToLower();

            if (Words.Contains(choice))
            {
                HiddenWord = choice;
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You did not choose real word or a word that has already been guessed");
                SetHiddenWord();
            }
        }

        private List<string> ChooseAvailableWords()
        {
            Console.WriteLine("Do you want a four letter word, or five letter word?\n" +
                "1: four letter\n" +
                "2: five letter");

            switch (Console.ReadLine())
            {
                case "1":
                    return File.ReadAllLines(Path.GetFullPath(@"../../../textFiles/four-letter-words.txt")).ToList();
                case "2":
                    return File.ReadAllLines(Path.GetFullPath(@"../../../textFiles/five-letter-words.txt")).ToList();
                default:
                    Console.Clear();
                    Console.WriteLine("You did not choose a legal value...");
                    return ChooseAvailableWords();
            }
        }
    }
}
