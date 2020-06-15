// Our gamestate class

using System;
using System.Collections.Generic;
namespace Hangman
{
    public class GameState
    {
        // create state-holding variables for our object
        public string hiddenWord;
        public List<char> revealedWord = new List<char>();
        public string guesses = "";
        public int chancesLeft = 6;
        public char currGuess;
        
        // not entirely sure why we need this but we do.
        public GameState(){}
        
        // create the target word with user input and instantiate the revealedWord
        public void createHW()
        {
            Console.WriteLine("Bitte Ihre Geheimwort eintyppen");
            hiddenWord = Console.ReadLine().ToLower();
            Console.Clear();
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                revealedWord.Add('*');
            }
        }
        
        // our core gameplay, take guess as input and work through possibilities
        public void gameStart()
        {
            bool isRevealed = revealedWord.Contains('*');
            bool prevGuesses = guesses.Contains(currGuess);
            while ((chancesLeft != 0) & isRevealed)
            {
                // call drawScreen
                drawScreen();
                // print revealedWord thus far
                for (int i = 0; i < revealedWord.Count; i++)
                {
                    Console.Write(revealedWord[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("Bitte ihre Vermutung eintyppen");
                char currGuess = Console.ReadKey().KeyChar;
                // invalid input
                if (!char.IsLetter(currGuess))
                {
                    Console.WriteLine("Eingabe Fehler");
                    continue;
                    //Console.WriteLine("Bitte ihre Vermutung eintyppen");
                    //char currGuess = Char.ToLower(Console.ReadLine());
                }

                // guess has already been made
                else if (prevGuesses)
                {
                    Console.WriteLine("Sie haben das schon probiert!");
                    continue;
                    //char currGuess = Char.ToLower(Console.ReadLine());
                }

                // guess is a valid new character (gamestate)
                else if (hiddenWord.Contains(currGuess))
                {
                    // update revealedWord from asterix to letter
                    for (int i = 0; i <= hiddenWord.Length - 1; i++)
                    {
                        if (currGuess == hiddenWord[i])
                        {
                            revealedWord[i] = currGuess;
                            if (revealedWord.Contains('*') == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Sie haben gewonnen");
                                return;
                            }
                        }

                    }
                    /*
                    //call game-end condition
                 if (isRevealed == false)
                         {
                         Console.Clear();

                         Console.WriteLine("Sie haben gewonnen!");
                         }*/
                }

                
                
                else if (!hiddenWord.Contains(currGuess))
                       {
                       // update hangman, chancesLeft = -1
                           chancesLeft = chancesLeft-1;
                    if (chancesLeft <= 0)
                        {
                            Console.Clear();

                            Console.WriteLine("Sie haben verlieren");
                        }
                    continue;
                       }
                else
                {
                    continue;
                }

                //ends while loop
            }

            // game end loop

        }
    
        public void drawScreen()
        {
            Console.Clear();
            Console.WriteLine("_____________");
            Console.WriteLine("|           |");
            if (chancesLeft == 6)
            {
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
            }
            else if (chancesLeft == 5)
            {

                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");

            }
            else if (chancesLeft == 4)
            {
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           |   ");
            }
            else if (chancesLeft == 3)
            {
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|  ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           |   ");
            }
            else if (chancesLeft == 2)
            {
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|\\  ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           |   ");
            }
            else if (chancesLeft == 1)
            {
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|\\  ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|   ");
            }
            else if (chancesLeft == 0)
            {
                Console.WriteLine("|           |   ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|          o o  ");
                Console.WriteLine("|           o   ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|\\  ");
                Console.WriteLine("|           |   ");
                Console.WriteLine("|          /|\\  ");
            }
            else
                Console.WriteLine("Fehler, zu viele Chancen");
                return;
            /*
            1. Clear Screen
            2. Redraw Screen /w revealedWord (with formatting), prompt, and Hangman
            http://www.berkeleyinternet.com/perl/node30.html
            https://docs.microsoft.com/en-us/dotnet/api/system.console.clear?view=netcore-3.1
            https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.clear?view=dotnet-plat-ext-3.1
         */
            //ends drawScreen function
        }

      
    // end gameState class  
    }    
// end namespace
}
