# AB_Hangman


# Aufgabe:
Mach einfach Hangman als Kommandozeilspiele

## Benutzer-Flow
1. Gruße drucken
2. Schliefe:
  A. show obscured word
  B. take input
  C. check input against word (hidden)
  D. update game state
  E. Loop
3. win/lose -> display appropriate message

## New Program Flow
1. print greeting/etc. 
2. Call gameState.gameStart()
(game runs)
    a. gets input for hidden thing
    b. runs game properly
    c. exits naturally as part of loop



## OLD Program-Flow
1. Instantiate variables (string hiddenWord, list revealedWord, list Guesses)
2. Print Greeting
3. Loopy time
  3a. Print revealedWord to screen (will be all asterixs the first time.
  3b. Take user input, check against guesses & hidden word
  3c. Guesses can be:
    1. a new guess (letter not yet tried) -> add to guesses, check against hiddenWord, update revealedWord, check against    gameEnd function (win/lose condition)
    2. an old guess (letter already tried) -> check against guesses, print error "already tried", restart loop
    3. an invalid input -> print error "invalid input" and restart loop

