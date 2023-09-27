// #1 the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation;

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription =
                "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription =
                "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription =
                "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription =
                "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }

    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// #5 display the top-level menu options

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Display all dogs with a specified characteristic");
Console.WriteLine();

do
{
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }

            break;

        case "2":
            // Display all dogs with a specified characteristic
            string dogCharacteristic = "";

            while (
                String.IsNullOrWhiteSpace(dogCharacteristic)
                || String.IsNullOrEmpty(dogCharacteristic)
            )
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
                readResult = Console.ReadLine();
                dogCharacteristic = readResult.ToLower().Trim();
            }

            string[] searchTerms = dogCharacteristic.Split(',');

            Array.Sort(searchTerms);

            // #6 loop through the ourAnimals array to search for matching animals

            string[] searchingIcons = { "2  ", "1 ", "0" };
            bool anyMatchedDog = false;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // #7 Search combined descriptions and report results
                    string dogDescription;
                    bool dogMatchedSearchterm = false;
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];

                    foreach (string searchTerm in searchTerms)
                    {
                        // Add spinner before searching
                        for (int j = 5; j > -1; j--)
                        {
                            // #5 update "searching" message to show countdown
                            foreach (string icon in searchingIcons)
                            {
                                Console.Write($"\rSearching...{ourAnimals[i, 3].Substring(ourAnimals[i, 3].IndexOf(':') + 1)} for {searchTerm}  \\ {icon}");
                                Thread.Sleep(250);
                            }

                            Console.Write($"\r{new string(' ', Console.BufferWidth)}");
                        }
                        if (dogDescription.Contains(searchTerm.Trim()))
                        {
                            Console.WriteLine(
                                $"\nOur dog {ourAnimals[i, 3].Substring(ourAnimals[i, 3].IndexOf(':') + 1)} is a {searchTerm} match"
                            );
                            dogMatchedSearchterm = true;
                            anyMatchedDog = true;
                        }
                    }
                    if (dogMatchedSearchterm)
                    {
                        Console.WriteLine($"{ourAnimals[i, 3]} ({ourAnimals[i, 0]})");
                        Console.WriteLine(dogDescription);
                    }
                }
            }

            if (!anyMatchedDog)
            {
                Console.WriteLine($"None of our dogs are a match for: {dogCharacteristic}");
            }
            break;

        default:
            break;
    }
} while (menuSelection != "exit");
