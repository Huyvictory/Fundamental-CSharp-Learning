Random random = new Random();
int luck = random.Next(100);

string[] text =
{
    "You have much to",
    "Today is a day to",
    "Whatever work you do",
    "This is an ideal time to"
};
string[] good =
{
    "look forward to.",
    "try new things!",
    "is likely to succeed.",
    "accomplish your dreams!"
};
string[] bad =
{
    "fear.",
    "avoid major decisions.",
    "may have unexpected outcomes.",
    "re-evaluate your life."
};
string[] neutral =
{
    "appreciate.",
    "enjoy time with friends.",
    "should align with your values.",
    "get in tune with nature."
};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = TellFortune(luck);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{text[i]} {fortune[i]} ");
}

string[] TellFortune(int luckNumber)
{
    if (luckNumber > 75)
    {
        return good;
    }
    else if (luckNumber < 25)
    {
        return bad;
    }
    else
    {
        return neutral;
    }
}
