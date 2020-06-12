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
            Console.WriteLine("Bitte ihre Vermutung eintyppen");
            char currGuess = Char.ToLower(Console.ReadLine());
            // invalid input
            while (!char.IsLetter(currGuess)
                {
                Console.WriteLine("Eingabe Fehler");
                Console.WriteLine("Bitte ihre Vermutung eintyppen");
                char currGuess = Char.ToLower(Console.ReadLine());
                }
     
            // guess has already been made
            if (guesses.Contains(currGuess))
                   {
                   Console.WriteLine("Bitte ihre Vermutung eintyppen");
                   char currGuess = Char.ToLower(Console.ReadLine());
                   }

            // guess is a valid new character (gamestate)
            if (hiddenWord.Contains(currGuess))
                   {
                   // update revealedWord
                   }
            else
                   {
                   // update hangman, chancesLeft = -1
                   }
            // check if game ends and call gameEnd
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
