using System;

namespace jumper.game
{
    public class Word
    {

        private List<string> wordsList;
        private List<char> currentWord;
        private string correctWord;
        // string userGuess;
        // bool isLetterGuesses = true
        
        public Word()
        {
            this.wordsList = new List<string>();
            this.currentWord = new List<char>();
            this.correctWord = "";

            string filename = "words.txt";

            wordsList = File.ReadLines(filename).ToList();
            getRandomWord();
        }
        public List<char> getcurrentWord()
        {
            return currentWord;
        }
        public string getCorrectWord()
        {
            return correctWord;
        }
        private void getRandomWord()
        {
            Random random = new Random();
            // randomWord.Next(words.Count);
            this.correctWord = wordsList[random.Next(0, wordsList.Count)];
            // Console.WriteLine(correctWord);
            
            // For every character in correct, add a dash into current

            foreach (char c in this.correctWord) 
            {
                currentWord.Add('_');
          
            }
        }
        public bool isGameWon()
        {
            for(int i = 0; i < currentWord.Count; i++)
            {
                if(currentWord[i] != correctWord[i])
                {
                    return false;
                }
            }
            return true;
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
    }
}
