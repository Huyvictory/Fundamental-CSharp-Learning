//***********************************************

// Ex 1: Write code that validates integer input

// Console.WriteLine("Please type number from 5 to 10");

// int userInput = 0;
// while (userInput < 5 || userInput > 10)
// {
//     bool isValidUserInput = int.TryParse(Console.ReadLine()?.Trim(), out userInput);

//     if (!isValidUserInput)
//     {
//         Console.WriteLine("Your input was invalid please try again!");
//     }
//     else
//     {
//         if (userInput < 5 || userInput > 10)
//         {
//             Console.WriteLine("Your input was out of range. Try again!");
//         }
//     }
// }

// Console.WriteLine($"Your input was {userInput}");

//***********************************************

//***********************************************

// Ex 2: Validate string input

// Console.WriteLine("Please specify your role : (Administrator | Manager | User)");

// string userInputRole = "";

// do
// {
//     userInputRole = Console.ReadLine();

//     if (String.IsNullOrWhiteSpace(userInputRole))
//     {
//         Console.WriteLine("Your input was invalid, please try again");
//     }
//     else
//     {
//         string processedUserInputRole = userInputRole.Trim().ToLower();
//         if (
//             processedUserInputRole == "Administrator".ToLower()
//             || processedUserInputRole == "Manager".ToLower()
//             || processedUserInputRole == "User".ToLower()
//         )
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine(
//                 $"The role name that you entered, \"{userInputRole}\" is not valid. Try again!"
//             );
//         }
//     }
// } while (true);

// Console.WriteLine($"Your input {userInputRole} was accepted");

//***********************************************

//***********************************************

// Ex 3:
string[] myStrings = new string[2]
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};

foreach (string myString in myStrings)
{
    if (myString.IndexOf('.') != -1)
    {
        string[] contentsToDisplay = myString.Split('.');
        int contentNumberToDisplay = 0;

        while (contentNumberToDisplay < contentsToDisplay.Length)
        {
            Console.WriteLine($"{contentsToDisplay[contentNumberToDisplay].Trim()}");
            contentNumberToDisplay++;
        }
    }
    else
    {
        Console.WriteLine(myString);
    }
}

//***********************************************
