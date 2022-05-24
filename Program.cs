// See https://aka.ms/new-console-template for more information

//establishes variables
int userNumber = -2;
int userGuess = -1;

//validates the User 1 input to confirm it is in the correct range. Clears screen when input has been verified allowable.
while ((userNumber > 100 || userNumber < 0))
{
    Console.WriteLine("User 1, enter a number between 0 and 100. ");
    userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber > 100 || userNumber < 0)
    {
        Console.WriteLine("You have entered an invalid number");
    }
    Console.Clear();
}

//Tests User 2's input against the User 1 input. Loops while they are not the same. 
while (userGuess != userNumber)
{
    Console.WriteLine("User 2, what is your guess? ");
    userGuess = Convert.ToInt16(Console.ReadLine());
    if (userGuess >= 0 && userGuess <= 100)
    {


        if (userGuess == userNumber)
        {
            Console.WriteLine("You have guessed the number!");
            break;
        }
        else if (userGuess > userNumber)
        {
            Console.WriteLine("You have guessed too high.");
        }
        else
        {
            Console.WriteLine("You have guessed too low");
        }
        continue;
    }
    Console.WriteLine("You have guessed out of the range.");
}

Console.ReadKey();
