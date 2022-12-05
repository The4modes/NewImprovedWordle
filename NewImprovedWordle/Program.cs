using System;

namespace NewImprovedWordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            gameManager.RunGame();

            Environment.Exit(0);
        }
    }
}
