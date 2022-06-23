string[] wordBank = {"FOREST", "TREE", "FLOWER",
                     "SKY", "GRASS", "MOUNTAIN",
                     "HAPPY", "ROTATING", "RED",
                     "FAST", "ELASTIC", "SMILY",
                     "UNBELIEVABLE", "INFINITE"};

//generates an wordGuess from the wordBank array
Random rnd = new Random();
string wordGuess = wordBank[rnd.Next(wordBank.Count())];

Console.WriteLine(wordGuess);

//checks to see if a string is numeric
bool IsNumeric(String str)
{
    if (str == "") {
        return false;
    }
    try {
        Double.Parse(str);
        return true;
    } catch (FormatException) {
        return false;
    }
}

//an array that stores all incorrect words used during the game
List<string> incorrectWords = new List<string>();

//an array that stores of the incorrect letters used during the game
List<string> incorrectLetters = new List<string>();

//an array that stores of the correct letters used during the game
List<string> correctLetters = new List<string>();

//the number of tries before you lose the round
int tries = 6;

//the number of correct attempts at the word
int correct = 0;

//flag for the while loop responible for game
bool gameCompleted = false;

Console.WriteLine("Welcome to Hangman!");
Console.WriteLine("The secret word has been selected and is " + wordGuess.Length + " letters.");
Console.WriteLine("Press 'Enter' to begin!");
Console.ReadLine();
Console.Clear();

while(!gameCompleted){
    
    //Need a method to create the hangman
    
    Console.WriteLine("Guess a word or letter!");
    string userInput = Console.ReadLine();
    Console.WriteLine();
    
    //The Start of Hangman

    
    //the user can type anything into the string
    //first checks whether the userInput is numeric or null
    if (!IsNumeric(userInput)) 
    {
        //makes the userinput all uppercase
        userInput = userInput.ToUpper();

        //also want to add functionality where the game keeps track of the letters used and words used
        if (!incorrectLetters.Contains(userInput) && !incorrectWords.Contains(userInput))
        {
            //check is userInput is only a single letter
            if (userInput.Length == 1)
            {
                //checks if UserInput is in wordGuess
                if (wordGuess.Contains(userInput))
                {
                    Console.WriteLine("The letter '" + userInput + "' is correct!");
                    correctLetters.Add(userInput);
                    correct++;
                }
                else
                {
                    Console.WriteLine("The letter '" + userInput + "' isn't correct!");
                    
                    incorrectLetters.Add(userInput);
                    tries--;
                }
            }
            //the userInput is a word
            else
            {
                //checks if userInput is the wordGuess
                if (wordGuess.Equals(userInput) && tries == 6)
                {
                    Console.WriteLine("Congrats you won and guessed it on your first try!");
                    break;
                }
                else if (wordGuess.Equals(userInput))
                {
                    Console.WriteLine("Congrats you guessed the correct word!");
                    break;
                }
                else
                {
                    Console.WriteLine("The word '" + userInput + "' isn't correct!");
                    incorrectWords.Add(userInput);
                    tries--;
                }
            }
        }        
        else
        {
            Console.WriteLine("You already used that word or letter!");
        }
    }
    //the userInput was either numeric or null.
    else
    {
        Console.WriteLine("Please enter a valid input.");
        Console.WriteLine();
    }

        //breaks the while loop if the number of tries is exhausted
    if (tries == 0) {    
        Console.WriteLine("You ran out of attemps!");
        break;
    } else if (correct == wordGuess.Length) {
        Console.WriteLine();
        Console.WriteLine("You guessed all the letters correctly!");
        Console.WriteLine("The secret word was " + wordGuess + ".");
        break;
    }
    else
    {
        Console.WriteLine("You have " + tries + " attempt(s) left.");
        Console.WriteLine();
    }
}

