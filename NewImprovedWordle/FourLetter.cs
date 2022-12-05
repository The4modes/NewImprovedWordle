using System;
using System.Collections.Generic;
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
                throw new Exception("Word list have no values");
            }

            SetHiddenWord();
        }
    }

    class ThreeLetter
    {

    }
}
