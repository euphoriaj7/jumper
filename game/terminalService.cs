using System;
// comment
namespace jumper.game
{
    public class TerminalService
    {
        public TerminalService()
        {
            string userGuess;
        }
        public string ReadLetter(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        private void displayJumper(int wrongGuesses)
        {
            // create the jumper
            if (wrongGuesses == 0)
            {
                Console.WriteLine(" _____ ");
            }
            if (wrongGuesses <= 1)
            {
                Console.WriteLine("/_____\\ ");
            }
            if (wrongGuesses <= 2)
            {
                Console.WriteLine("\\     /");
            }
            if (wrongGuesses <= 3)
            {
                Console.WriteLine(" \\   / ");
            }
            if (wrongGuesses < 4)
            {
                Console.WriteLine("   O   ");
            }
            else
            {
                Console.WriteLine("   x   ");
            } 
            Console.WriteLine("  /|\\  ");
            Console.WriteLine("  / \\  ");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^");
        }
        public string getUserGuess()
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            string userGuess = Console.ReadLine();
            return userGuess;
        }
    }
}