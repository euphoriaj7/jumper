using System;

namespace jumper.game
{
    public class Guesses
    {
        private int wrongGuesses;
        public Guesses()
        {
            wrongGuesses = 0;
        }

        private void countWrongGuesses()
        {
            wrongGuesses++;
        }
    }

}