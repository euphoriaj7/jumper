using System;

namespace jumper.game
{
    public class TerminalService
    {
        public TerminalService()
        {  
        }
        public string ReadLetter(string l)
        {
            Console.Write(l);
            return Console.ReadLine();
        }
    }
}