Console.WriteLine("Please specify your IPv4 Address");

string Ipv4 = Console.ReadLine();

// Example Ipv4 address 1.1.1.1 - 255.255.255.255
if (!String.IsNullOrEmpty(Ipv4) && !String.IsNullOrWhiteSpace(Ipv4))
{
    string[] ElementsIpv4Address = Ipv4.Split('.');

    if (
        isValidIpv4LengthAddress(ElementsIpv4Address)
        && isValidZeroesIPv4(ElementsIpv4Address)
        && IsValidRangeIPv4(ElementsIpv4Address)
    )
    {
        Console.WriteLine($"{Ipv4} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{Ipv4} is an invalid IPv4 address");
    }
}
else
{
    Console.WriteLine("Invalid input, please try again");
}

bool isValidIpv4LengthAddress(string[] Ipv4Array)
{
    return Ipv4Array.Length == 4;
}

bool isValidZeroesIPv4(string[] Ipv4Array)
{
    foreach (string ipv4Element in Ipv4Array)
    {
        if (ipv4Element.StartsWith('0'))
        {
            return false;
        }
    }

    return true;
}

bool IsValidRangeIPv4(string[] Ipv4Array)
{
    foreach (string ipv4Element in Ipv4Array)
    {
        int parsedIpv4Element;
        if (int.TryParse(ipv4Element, out parsedIpv4Element))
        {
            if (parsedIpv4Element < 0 || parsedIpv4Element > 255)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    return true;
}
