namespace jumper.game
{
    public class Director
    {
        private Guesses guesses;
        private bool isPlaying;
        private Word word; 
        private TerminalService terminalService;
        string wordActual;

        public Director()
        {
            guesses = new Guesses();
            isPlaying = true;
            word = new Word();
            terminalService = new TerminalService();
        }
        
        public void StartGame()
        {
            while (isPlaying)
            {
                // GetInputs();
                // DoUpdates();
                // DoOutputs();
            }
        }
    }
}