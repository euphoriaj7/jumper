using System;

namespace jumper.game
{
    public class Player
    {
        private int wrongGuesses;
        public Player()
        {
            wrongGuesses = 0;

        }

        private void countWrongGuesses()
        {
            wrongGuesses++;
        }

        private void looseParachute()
        {
            // Remove sections of the parachute
        }
        private void createJumper()
        {
            // create the jumper
            Console.WriteLine(" _____ ")
            Console.Writeline("/_____\ ")
            Console.WriteLine("\     /")
            Console.WriteLine(" \   / ")
            Console.WriteLine("   O   ")
            Console.WriteLine("  /|\  ")
            Console.WriteLine("  / \  ")
            Console.WriteLine("")
            Console.WriteLine("^^^^^^^")
        }
    }

}