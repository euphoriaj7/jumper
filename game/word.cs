using System;

namespace jumper.game
{
    public class Word
    {
        List<string> wordsActual = new List<string>();
        List<string> wordsGuessed = new List<string>();
        
        public Word()
        {
            string filename = "words.txt";

            wordsActual = File.ReadLines(filename).ToList();
            Random random = new Random();
        }

        private string getRandomWord()
        {
            Random random = new Random();
            // randomWord.Next(words.Count);
            word = wordsActual[random.Next(0, wordsActual.Count)];

            return word;
        }

        private void trackWord()
        {
            // Track the number of correct guesses
        }

        private void fillSpaceCorrectGuess()
        {
            // puts the guess the user made correctly in the space of the chosen word
        }
    }
}
