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
    }

}