using System;

namespace jumper.game
{
    public class Word
    {
        List<string> words = new List<string>();

        public Word()
        {
            string filename = "words.txt";

            words = File.ReadLines(filename)
                                    .ToList();
        }
        private string getRandomWord()
        {
            Random randomWord = new Random();
            // randomWord.Next(words.Count);
            return words[(randomWord.Next(words.Count))];
        }
    }
}
