// Our gamestate class

using System;
namespace Hangman
{
    public class GameState
    {
        // create state-holding variables for our object
        private string hiddenWord;
        private list revealedWord;
        private string guesses;
        private int chancesLeft = 6;
        
        // not entirely sure why we need this but we do.
        public GameState(){}
        
        // create the target word with user input and instantiate the revealedWord
        public void createHW()
        {
            Console.WriteLine("Bitte Ihre Geheimwort eintyppen");
            hiddenWord = Console.Readline();
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                revealedWord.Add('*');
            }
        }
        
        // our core gameplay, take guess as input and work through possibilities
        public void guess();
        {
            // invalid input
            // guess has already been made
            // guess is a new character (gamestate)
        }
        
        public void gameEnd();
        {
            //if chancesLeft > 0 -> do winning thing
            //else ->> do losing thing
        }
        

      
    // end class  
    }    
// end namespace
}
