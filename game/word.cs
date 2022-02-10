using System;

namespace jumper.game
{
    public class Word
    {

        List<string> wordsList;
        List<string> current;
        // List<string> 
        string correct;
        string userGuess;
        // bool isLetterGuesses = true
        
        public Word()
        {
            this.wordsList = new List<string>();
            this.current = new List<string>();
            this.correct = "";
            
            string userGuess = getUserGuess();

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

        public void trackWord()
        {
            correct.Contains(userGuess);
            if(current = correct)
            // (word.Contains(letter) == true)
            {
                
            }
        }

        // private void fillSpaceCorrectGuess()
        // {
        //     // puts the guess the user made correctly in the space of the chosen word
        // }
    }
}
