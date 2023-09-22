// This code is to reverse a message string and count number of 'o' characters on it and show the results

string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();

Array.Reverse(charMessage);
int countCharacter = 0;

foreach (char character in charMessage)
{
    if (character == 'o')
    {
        countCharacter++;
    }
}

Console.WriteLine(new string(charMessage));
Console.WriteLine($"'o' appears {countCharacter} times.");
