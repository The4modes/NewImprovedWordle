using System.Collections.Generic;

namespace NewImprovedWordle
{
    interface IWordle
    {
        public string HiddenWord { get; } 
        public List<string> Words { get; set; }
        public List<char[]> AlphabetWithColors { get; set; }
        public void UpdateAlphabetColors(char character, char color);
    }
}
