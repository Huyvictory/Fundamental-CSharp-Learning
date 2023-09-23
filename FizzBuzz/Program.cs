for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
        continue;
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}
