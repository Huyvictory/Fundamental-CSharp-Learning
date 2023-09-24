// the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription =
                "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription =
                "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription =
                "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
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
}

// display the top-level menu options

Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        switch (menuSelection)
        {
            case "1":
                // List all of our current pet information


                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        Console.WriteLine("******************************");
                        for (int j = 0; j < ourAnimals.GetLength(1); j++)
                        {
                            Console.WriteLine($"{ourAnimals[i, j]}");
                        }
                        Console.WriteLine("******************************");
                    }
                }

                break;
            case "2":
                // Add a new animal friend to the ourAnimals array
                string anotherPet = "y";
                int petCount = 0;
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        petCount += 1;
                    }
                }

                while (anotherPet == "y" && petCount < maxPets)
                {
                    bool validEntry = false;

                    do
                    {
                        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalSpecies = readResult.ToLower();

                            if (animalSpecies == "dog" || animalSpecies == "cat")
                            {
                                animalID =
                                    animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    validEntry = false;

                    // get the pet's age. can be ? at initial entry.
                    do
                    {
                        int petAge;
                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalAge = readResult;
                            if (animalAge != "?")
                            {
                                validEntry = int.TryParse(animalAge, out petAge);
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                    do
                    {
                        Console.WriteLine(
                            "Enter a physical description of the pet (size, color, gender, weight, housebroken)"
                        );
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "")
                            {
                                animalPhysicalDescription = "tbd";
                            }
                        }
                    } while (animalPhysicalDescription == "");

                    // get a description of the pet's personality - animalPersonalityDescription can be blank.
                    do
                    {
                        Console.WriteLine(
                            "Enter a description of the pet's personality (likes or dislikes, tricks, energy level)"
                        );
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower();
                            if (animalPersonalityDescription == "")
                            {
                                animalPersonalityDescription = "tbd";
                            }
                        }
                    } while (animalPersonalityDescription == "");

                    // get the pet's nickname. animalNickname can be blank.
                    do
                    {
                        Console.WriteLine("Enter a nickname for the pet");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalNickname = readResult.ToLower();
                            if (animalNickname == "")
                            {
                                animalNickname = "tbd";
                            }
                        }
                    } while (animalNickname == "");

                    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                    petCount = petCount + 1;

                    // store the pet information in the ourAnimals array (zero based)
                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                    // check maxPet limit
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine(
                            $"We currently have {petCount} pets that need homes. We can manage {maxPets - petCount} more."
                        );
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }
                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine(
                        "We have reached our limit on the number of pets that we can manage."
                    );
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                }
                break;
            case "3":
                // Ensure animal ages and physical descriptions are complete
                // Find animal which has age or physical description is incomplete but has already defined data before
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        string dataFieldAgeAnimal = ourAnimals[i, 2].Substring(
                            ourAnimals[i, 2].IndexOf(':') + 1
                        );
                        string dataFieldPhysicalDescriptionAnimal = ourAnimals[i, 4].Substring(
                            ourAnimals[i, 4].IndexOf(':') + 1
                        );
                        if (
                            String.IsNullOrWhiteSpace(dataFieldAgeAnimal)
                            || String.IsNullOrWhiteSpace(dataFieldPhysicalDescriptionAnimal)
                        )
                        {
                            int newAnimalAge;
                            string newPhysicalDescription;

                            Console.WriteLine(
                                $"Animal that neeed to update data age and physical description {ourAnimals[i, 0]}"
                            );

                            do
                            {
                                Console.WriteLine($"Enter new age for {ourAnimals[i, 0]}");

                                string newAge = Console.ReadLine().Trim();
                                if (newAge != null)
                                {
                                    bool isValidAge = int.TryParse(newAge, out newAnimalAge);
                                    if (isValidAge)
                                    {
                                        Console.WriteLine(
                                            $"Your input for pet's new age {newAnimalAge} was accepted"
                                        );
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            "Your age input was invalid please try again"
                                        );
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(
                                        "Your age input was invalid please try again"
                                    );
                                }
                            } while (true);

                            do
                            {
                                Console.WriteLine(
                                    $"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)"
                                );

                                newPhysicalDescription = Console.ReadLine();
                                if (String.IsNullOrWhiteSpace(newPhysicalDescription))
                                {
                                    Console.WriteLine(
                                        "Your physical description input was invalid please try again"
                                    );
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            // Assign data age and physical description to animal
                            ourAnimals[i, 2] = "Age: " + newAnimalAge.ToString();
                            ourAnimals[i, 4] = "Physical description: " + newPhysicalDescription;
                        }
                    }
                }

                Console.WriteLine(
                    "Age and physical description fields are complete for all of our friends."
                );
                break;
            case "4":
                // Ensure animal nicknames and personality descriptions are completea
                // Find animal which has nickname or personality descriptions are incomplete but has already defined data before
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        string dataFieldNickNameAnimal = ourAnimals[i, 3].Substring(
                            ourAnimals[i, 3].IndexOf(':') + 1
                        );
                        string dataFieldPersonalityDescriptionsAnimal = ourAnimals[i, 5].Substring(
                            ourAnimals[i, 5].IndexOf(':') + 1
                        );
                        if (
                            String.IsNullOrWhiteSpace(dataFieldNickNameAnimal)
                            || String.IsNullOrWhiteSpace(dataFieldPersonalityDescriptionsAnimal)
                        )
                        {
                            string newAnimalNickName;
                            string newPersonalityDescriptions;

                            Console.WriteLine(
                                $"Animal that neeed to update data nickname and personality descriptions {ourAnimals[i, 0]}"
                            );

                            do
                            {
                                Console.WriteLine($"Enter new nickname for {ourAnimals[i, 0]}");

                                newAnimalNickName = Console.ReadLine().Trim();
                                if (String.IsNullOrWhiteSpace(newAnimalNickName))
                                {
                                    Console.WriteLine(
                                        "Your nickname input was invalid please try again"
                                    );
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            do
                            {
                                Console.WriteLine(
                                    $"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)"
                                );

                                newPersonalityDescriptions = Console.ReadLine().Trim();
                                if (String.IsNullOrWhiteSpace(newPersonalityDescriptions))
                                {
                                    Console.WriteLine(
                                        "Your personality description input was invalid please try again"
                                    );
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            // Assign data nickname and personality descriptions to animal
                            ourAnimals[i, 3] = "Nickname: " + newAnimalNickName;
                            ourAnimals[i, 5] = "Personality: " + newPersonalityDescriptions;
                        }
                    }
                }

                Console.WriteLine(
                    "Nickname and personality description fields are complete for all of our friends."
                );
                break;
            case "5":
                // Edit an animal’s age
                Console.WriteLine(
                    "UNDER CONSTRUCTION - please check back next month to see progress."
                );
                break;
            case "6":
                // Edit an animal’s personality description
                Console.WriteLine(
                    "UNDER CONSTRUCTION - please check back next month to see progress."
                );
                break;
            case "7":
                // Display all cats with a specified characteristic
                Console.WriteLine(
                    "UNDER CONSTRUCTION - please check back next month to see progress."
                );
                break;
            case "8":
                // Display all dogs with a specified characteristic
                Console.WriteLine(
                    "UNDER CONSTRUCTION - please check back next month to see progress."
                );
                break;
            default:
                // Exit the program
                break;
        }
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
} while (readResult?.ToLower() != "exit");

Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
