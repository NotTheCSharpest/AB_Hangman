// Our gamestate class

using System;
namespace Hangman
{
    public class GameState
    {
        private string hiddenWord;
        private list revealedWord;
        private string guesses;
        public GameState()
        {
        }
    public void GameState()
    {
    }
    public void createHW()
    {
      Console.WriteLine("Bitte Ihre Geheimwort eintyppen");
      hiddenWord = Console.Readline();
      for (int i = 0; i < hiddenWord.Length; i++)
      {
        revealedWord.Add('*');
      }
    }
    public void guess(char curGuess);
    {
    }
      
      
    // end class  
    }    
// end namespace
}
