Console.WriteLine("Hi this is hangman!");

string[] wordBank = {"forest", "tree", "flower",
                     "sky", "grass", "mountain",
                     "happy", "rotating", "red",
                     "fast", "elastic", "smily",
                     "unbelievable", "infinite"};

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

//flag for the while loop responible for game
bool gameCompleted = false;
while (!gameCompleted)
{
    //the tries run out 
    if (tries == 0) {
        Console.WriteLine("You ran out of attemps!");
        break;
    }
    else
    {
        Console.WriteLine("You have " + tries + " attempt(s) left.");
    }
    //the user can type anything into the string
    Console.WriteLine("Guess the word or letter!");
    string userInput = Console.ReadLine();

    //first checks whether the userInput is numeric or null
    if (!IsNumeric(userInput)) 
    {
        //check is userInput is only a single letter
        if (userInput.Length == 1)
        {
            //checks if UserInput is in wordGuess
            if (wordGuess.Contains(userInput))
            {
                Console.WriteLine("The letter " + userInput + " is correct!");
                correctLetters.Add(userInput);


            }
            else
            {
                Console.WriteLine("The letter " + userInput + " isn't correct!");
                incorrectLetters.Add(userInput);
                tries--;
            }
        }
        //the userInput is a word
        else
        {
            //checks if userInput is the wordGuess
            if (wordGuess.Equals(userInput))
            {
                Console.WriteLine("You won!");
                break;
            }
            else
            {
                Console.WriteLine("The word " + userInput + " isn't correct!");
                incorrectWords.Add(userInput);
                tries--;
            }
        }
    }
    //the userInput was either numeric or null.
    else
    {
        Console.WriteLine("Please enter a valid input.");
    }
}

