using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewImprovedWordle
{
    class AnimalGame : IWordle
    {
        public AnimalGame()
        {
            Words = File.ReadAllLines(Path.GetFullPath(@"../../../textFiles/six-letter-words.txt")).ToList();

            if (Words.Count == 0)
            {
                throw new Exception("Word list have no values");
            }

        }

        public string HiddenWord => throw new NotImplementedException();

        public List<string> Words { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<char[]> AlphabetWithColors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void UpdateAlphabetColors(char character, char color)
        {
            throw new NotImplementedException();
        }
    }
}
