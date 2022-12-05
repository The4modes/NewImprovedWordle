using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;

namespace NewImprovedWordle
{
    class GameManager
    {
        private IWordle? Wordle { get; set; }
        private DisplayManager DisplayManager { get; set; }

        public GameManager()
        {
            DisplayManager = new DisplayManager();
        }

        public void RunGame()
        {
            StartScript();

            Thread.Sleep(1000);

            Wordle = ChooseWordle();

            GuessManager guessManager = GenerateGuessManager();

            while(guessManager.GuessCount < guessManager.MaximumGuesses && !guessManager.Win)
            {
                guessManager.GuessWord(Wordle, DisplayManager);
            }
                
            if (guessManager.Win)
            {
                Console.WriteLine("Congratulations, you got the word correct!");
            }
            else
            {
                Console.WriteLine("You did not get the word...");
                Console.WriteLine($"Correct word was: {Wordle.HiddenWord}");
            }
        }

        public void StartScript()
        {
            Console.WriteLine("Welcome to Wordle");
            Console.WriteLine("Your objective with this game is to try to guess the hidden word.");
        }

        public IWordle ChooseWordle()
        {
            Console.WriteLine("Do you want to play wordle with:\n" +
                "1: four letter words\n" +
                "2: five letter words\n" +
                "3: Choose your own four or five letter word");
            Console.WriteLine("Choose either \"1\",\"2\" or \"3\" ");

            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    return new FourLetter();
                case 2:
                    return new FiveLetter();
                case 3:
                    return new OwnWord();
                default:
                    Console.Clear();
                    Console.WriteLine("You did not choose a legal value, lets try again...");
                    return new Test();
            }
        }

        private GuessManager GenerateGuessManager()
        {
            Console.Clear();

            Console.WriteLine("Do you want to play the standard experience or" +
                " change the amount of tries you get?\n" +
                "1: Standard\n" +
                "2: Choose amount of tries");

            switch (NumberChoice(2, "You can only choose between \"1 \" or \"2\""))
            {
                case 1:
                    return new GuessManager();
                case 2:
                    Console.Clear();
                    Console.WriteLine("How many tries do you want to have?");
                    return new GuessManager(NumberChoice(12, "Maximum tries is 12"));
                default:
                    return new GuessManager();
            }
        }

        private int NumberChoice(int availbleChoices, string failMessage)
        {
            int.TryParse(Console.ReadLine(), out int choice);

            for (int i = 1; i <= availbleChoices; i++)
            {
                if (choice == i)
                {
                    return i;
                }
            }

            Console.WriteLine(failMessage);

            return NumberChoice(availbleChoices, failMessage);
        }
    }
}
