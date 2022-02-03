namespace jumper.game
{
    public class Director
    {
        private Player player;
        private bool isPlaying;
        private Word word; 
        private TerminalService terminalService;
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
                // GetInputs();
                // DoUpdates();
                // DoOutputs();
            }
        }
    }
}