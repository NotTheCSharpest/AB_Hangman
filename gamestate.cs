// Our gamestate class

using System;
namespace Hangman
{
    public class GameState
    {
        // create state-holding variables for our object
        private string eingabe;
        private string hiddenWord = eingabe.ToLower();
        private list revealedWord;
        private string guesses;
        private int chancesLeft = 6;
        
        // not entirely sure why we need this but we do.
        public GameState(){}
        
        // create the target word with user input and instantiate the revealedWord
        public void createHW()
        {
            Console.WriteLine("Bitte Ihre Geheimwort eintyppen");
            eingabe = Console.Readline();
            
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                revealedWord.Add('*');
            }
        }
        
        // our core gameplay, take guess as input and work through possibilities
        public void gameStart();
        {
            while ((!chancesLeft = 0) & (revealedWord.Contains(*)))
            {
                Console.WriteLine("Bitte ihre Vermutung eintyppen");
                char currGuess = Char.ToLower(Console.ReadLine());
                // invalid input
                if (!char.IsLetter(currGuess)
                    {
                    Console.WriteLine("Eingabe Fehler");
                    continue;
                    //Console.WriteLine("Bitte ihre Vermutung eintyppen");
                    //char currGuess = Char.ToLower(Console.ReadLine());
                    }

                // guess has already been made
                else if (guesses.Contains(currGuess))
                       {
                       Console.WriteLine("Sie haben das schon probiert!");
                       continue;
                       //char currGuess = Char.ToLower(Console.ReadLine());
                       }

                // guess is a valid new character (gamestate)
                else if (hiddenWord.Contains(currGuess))
                       {
                       // update revealedWord from asterix to letter
                           for (int i = 0; while i > hiddenWord.Length; i++)
                           {
                               if (hiddenWord[i] = currGuess)
                               {
                               revealedword[i] = currGuess
                               }
                           }
                           continue;
                           
                       }
                else if (!hiddenWord.Contains(currGuess))
                       {
                       // update hangman, chancesLeft = -1
                           chancesLeft = chancesLeft-1;
                       }
            //ends while loop
            }
        // game end loop
           
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
