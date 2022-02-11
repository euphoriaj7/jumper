using System;

namespace jumper.game
{
    public class Word
    {

        List<string> wordsList;
        List<char> currentWord;
        string correctWord;
        // string userGuess;
        // bool isLetterGuesses = true
        
        public Word()
        {
            this.wordsList = new List<string>();
            this.currentWord = new List<char>();
            this.correctWord = "";

            string filename = "words.txt";

            wordsList = File.ReadLines(filename).ToList();
        }

        public void getRandomWord()
        {
            Random random = new Random();
            // randomWord.Next(words.Count);
            this.correctWord = wordsList[random.Next(0, wordsList.Count)];
            
            // For every character in correct, add a dash into current

            foreach (char c in this.correctWord) 
            {
                currentWord.Add('_');
            }
        }
        
        // Fills in the correct guesses of the word in the letter spaces
        public bool IsCorrect(char userGuess)
        {
            // correct.Contains(userGuess);
            bool correct = false;
            for(int i = 0; i < correctWord.Length; i++)
            {
                if(userGuess == correctWord[i] && currentWord[i]=='_')
                {
                    currentWord[i] = userGuess;
                    correct = true;
                }
            }
            return correct;
        }

        // private void fillSpaceCorrectGuess()
        // {
        //     // puts the guess the user made correctly in the space of the chosen word
        // }
    }
}
