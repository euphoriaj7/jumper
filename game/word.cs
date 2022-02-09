using System;

namespace jumper.game
{
    public class Word
    {
        /*********************************************************
        * - 
        **********************************************************/
        List<string> wordsList;
        List<string> current;
        string correct;
        
        public Word()
        {
            this.wordsList = new List<string>();
            this.current = new list<string>();
            this.correct = "";

            string filename = "words.txt";

            wordsList = File.ReadLines(filename).ToList();
        }

        public void getRandomWord()
        {
            Random random = new Random();
            // randomWord.Next(words.Count);
            this.correct = wordsList[random.Next(0, wordsList.Count)];
            
            // For every character in correct, add a dash into current

            foreach (char c in this.correct) 
            {
                current.Add("_");
            }
        }

        private void trackWord()
        {
            if
            {
                correct == wordActual
            }
        }

        private void fillSpaceCorrectGuess()
        {
            // puts the guess the user made correctly in the space of the chosen word
        }
    }
}
