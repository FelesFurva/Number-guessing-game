int?[] winingNumbers = { 2, 7, 9 };
int guessedRight = 0;
Console.WriteLine("Guess three numbers and you win!");
Console.WriteLine("Please write the number!");


while (guessedRight != 3)
{
    int.TryParse(Console.ReadLine(), out int userNumber);

    if (!winingNumbers.Contains(userNumber))
    {
        Console.WriteLine("Nope! You guessed wrong!");
        Console.WriteLine("One more time!");
    }
    else
    {
        Console.WriteLine("You guessed right!");
        int guessedNum = Array.IndexOf(winingNumbers, userNumber);
        winingNumbers[guessedNum] = null;      
        guessedRight++;
    }
} 
Console.WriteLine("Congratulation! You won!");
