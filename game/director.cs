namespace jumper.game
{
    public class Director
    {
        private Player player;
        private bool isPlaying;
        private Word word; 
        private TerminalService terminalService;
        string wordActual;

        public Director()
        {
            player = new Player();
            isPlaying = true;
            word = new Word();
            terminalService = new TerminalService();
        }
        
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                // DoUpdates();
                // DoOutputs();
            }
        }

        private void GetInputs()
        {
            string letter = terminalService.ReadLetter("Enter a letter [a-z]: ");
            if (word.Contains(letter) == true) 
            {
                Console.WriteLine("Word found!");
            }
            
        }
    }
}