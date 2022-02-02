namespace jumper.game
{
    public class Director
    {
        private Player player = new Player();
        private bool isPlaying = true;
        private Word word = new Word();
        private TerminalService terminalService = new TerminalService();
        public Director()
        {

        }
    }
}