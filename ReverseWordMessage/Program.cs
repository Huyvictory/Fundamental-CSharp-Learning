// Ex 1:
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] splittedPangrams = pangram.Split(" ");

// for (int i = 0; i < splittedPangrams.Length; i++)
// {
//     char[] splittedPangram = splittedPangrams[i].ToCharArray();

//     Array.Reverse(splittedPangram);

//     splittedPangrams[i] = new string(splittedPangram);
// }

// pangram = string.Join(" ", splittedPangrams);

// Console.WriteLine(pangram);

// Ex 2:
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(',');

Array.Sort(orderIds);

foreach (string orderId in orderIds)
{
    if (orderId.Length != 4)
    {
        Console.WriteLine($"{orderId} - Error");
    }
    else
    {
        Console.WriteLine(orderId);
    }
}
