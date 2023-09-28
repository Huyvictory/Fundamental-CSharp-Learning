Random random = new Random();

string? input;

do
{
    Console.WriteLine("Would you like to play? (Y/N)");

    input = Console.ReadLine();
} while (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input));

if (ShouldPlay(input))
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));

        input = "";
        do
        {
            Console.WriteLine("\nPlay again? (Y/N)");
            input = Console.ReadLine();
        } while (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input));

        play = ShouldPlay(input);
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int GetRoll()
{
    return random.Next(1, 7);
}

bool ShouldPlay(string userInput)
{
    if (userInput.Trim().ToLower() == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string WinOrLose(int target, int roll)
{
    if (roll > target)
    {
        return "You won";
    }
    else
    {
        return "You lose";
    }
}
