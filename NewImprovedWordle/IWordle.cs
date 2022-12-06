using System;
using System.Collections.Generic;
using System.IO;

namespace NewImprovedWordle
{
    interface IWordle
    {
        public string? HiddenWord { get; } 
        public List<string> Words { get; }
        public List<char[]> AlphabetWithColors { get; }
        public void UpdateAlphabetColors(char character, char color);
    }
}
