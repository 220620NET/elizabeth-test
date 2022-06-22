//3 ---> fizz
//5 ---> buzz
//3 and 5 ---> fizzbuzz

int num = 0;

bool x = true;

while (x)
{
    Console.WriteLine("What is the number you'd like me to iterate to?");
    string userInput = Console.ReadLine();
    Console.WriteLine("");
    try
    {
        num = int.Parse(userInput);
        Console.WriteLine("Here is the iteration:");
        for (int i = 1; i <= num; i++)
        {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
            Console.WriteLine("fizzbuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
        }
        Console.WriteLine("");
        Console.WriteLine("Would you like me to iternate again? (yes/no)");
        string again = Console.ReadLine();
        Console.WriteLine("");
        again = again.ToLower();
        if (!again.Equals("yes")) {
            x = false;
        }
        
    }
    
    catch (FormatException)
    {
        Console.WriteLine("Not a valid input. Please type a positive integer.");
        
    }
}

