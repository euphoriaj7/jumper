using System;

namespace jumper.game
{
    public class TerminalService
    {
        public TerminalService()
        {
            // empty constructor  
        }
        public string ReadLetter(string l)
        {
            Console.Write(l);
            return Console.ReadLine();
        }
        private void displayJumper(int wrongGuesses)
        {
            // create the jumper
            if (wrongGuesses == 0)
            {
                Console.WriteLine(" _____ ")
            }
            if (wrongGuesses <= 1)
            {
                Console.WriteLine("/_____\ ")
            }
            if (wrongGuesses <= 2)
            {
                Console.WriteLine("\     /")
            }
            if (wrongGuesses <= 3)
            {
                Console.WriteLine(" \   / ")
            }
            if (wrongGuesses < 4)
            {
                Console.WriteLine("   O   ")
            }
            else
            {
                Console.WriteLine("   x   ")
            }
             
            Console.WriteLine("  /|\  ")
            Console.WriteLine("  / \  ")
            Console.WriteLine("")
            Console.WriteLine("^^^^^^^")
        }
    }
}