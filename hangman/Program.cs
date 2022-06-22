/*
Hangman is a game wheere a user must guess randomly picked word in 6 tries.
The user guesses a letter, then we can tell if it exists in the word or not.
If the letter exists in the word, then we fill in the letter.
User can also guess the word
*/

string[] wordBank = {"apple", "banana", "pineapple",
                     "pear", "avocado", "peanut",
                     "giraffe", "tomato", "platypus",
                     "sugar", "lion", "bear",
                     "mango", "phone", "orange", "tiger"};

Random rand = new Random();

int wordBankNum = wordBank.Count();
int randomNumber = rand.Next(wordBankNum);

string answer = wordBank[randomNumber];

Console.WriteLine(answer);

Console.WriteLine("Welcome to Hangman");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[1] Guess a letter");
Console.WriteLine("[2] Guess the word");
string input = Console.ReadLine();
if(input == "1")
{
    // then I'll have them guess letter
    Console.WriteLine("Take a guess");
    int charInput = Console.Read();
    char userGuess = Convert.ToChar(charInput);

    // string strInput = Console.ReadLine();
    // char guess = strInput[0];

    bool isCorrect = GuessLetter(userGuess);
}
else if(input == "2")
{
    //then i'll have them guess the word
}

//This is a method. This encapsulates a behavior that we want to reuse
//This is the method signature, and it has 3 things; return type, method name, method parameters 
bool GuessLetter(char userGuess)
{
    Console.WriteLine(userGuess);
    Console.WriteLine(answer.Contains(userGuess));
    return answer.Contains(userGuess);
}