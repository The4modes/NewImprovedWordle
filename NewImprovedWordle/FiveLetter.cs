using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewImprovedWordle
{
    class FiveLetter : Wordle
    {
        public FiveLetter()
        {
            Words = File.ReadAllLines(Path.GetFullPath(@"../../../textFiles/five-letter-words.txt")).ToList();

            if (Words.Count == 0)
            {
                throw new NotImplementedException();
            }

            SetHiddenWord();
        }
    }
}
