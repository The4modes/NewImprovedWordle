using System;
using System.Collections.Generic;
using System.IO;

namespace NewImprovedWordle
{
    interface IWordle
    {
        public string? HiddenWord { get; } 
        public List<string> Words { get; set; }
        public List<char[]> AlphabetWithColors { get; set; }
        public void UpdateAlphabetColors(char character, char color);
    }

    //class Test : IWordle
    //{
    //    public string? HiddenWord { get; set; } = "hejsan";

    //    public List<string> Words { get; set; } = new List<string>() {"hejsan", "hestar"};
    //    public List<char[]> AlphabetWithColors { get; set; } = new List<char[]>();

    //    public Test()
    //    {
    //        if (Words.Count == 0)
    //        {
    //            throw new Exception("Word list have no values");
    //        }

    //        foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower())
    //        {
    //            AlphabetWithColors.Add(new char[] { letter, 'b' });
    //        }
    //    }

    //    public void UpdateAlphabetColors(char character, char color)
    //    {
    //        foreach (char[] letter in AlphabetWithColors)
    //        {
    //            if (character == letter[0] && letter[1] != 'g')
    //            {
    //                letter[1] = color;
    //            }
    //        }
    //    }
    //}
}
