using System;
using System.Collections.Generic;
using System.Linq;

namespace NewImprovedWordle
{
    class DisplayManager
    {
        public void DisplayWordColor(List<char[]> chars)
        {
            foreach (char[] character in chars)
            {
                if (character.Length != 2)
                {
                    throw new NotImplementedException("not correct format of [char, color]");
                }

                switch (character[1])
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(character[0]);
                        break;
                    case 'y':
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write(character[0]);
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(character[0]);
                        break;
                    default:
                        throw new Exception("A color was never assigned to the letter");
                }
            }

            Console.ResetColor();
        }

        public void DisplayWordColor(string words, IWordle wordle)
        {
            if(wordle.HiddenWord is null)
            {
                throw new NullReferenceException();
            }

            List<char[]> wordWithColor = new List<char[]>();

            for(int i = 0; i < words.Length; i++)
            {
                char[] chars = new char[2];
                chars[0] = words[i];
                
                if (wordle.HiddenWord[i] == words[i])
                {
                    wordle.UpdateAlphabetColors(chars[0], 'g');
                    chars[1] = 'g';
                }
                else if (wordle.HiddenWord.Contains(words[i]))
                {
                    wordle.UpdateAlphabetColors(chars[0], 'y');
                    chars[1] = 'y';
                }
                else
                {
                    chars[1] = 'b';
                }

                wordWithColor.Add(chars);
            }
            Console.WriteLine();
            DisplayWordColor(wordWithColor);
        }

    }
}
