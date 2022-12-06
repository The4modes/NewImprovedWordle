using System;
using System.IO;
using System.Linq;

namespace NewImprovedWordle
{
    class FourLetter : Wordle
    {
        public FourLetter()
        {
            Words = File.ReadAllLines(Path.GetFullPath(@"../../../textFiles/four-letter-words.txt")).ToList();

            if (Words.Count == 0)
            {
                throw new NotImplementedException("words");
            }

            SetHiddenWord();
        }
    }
}
