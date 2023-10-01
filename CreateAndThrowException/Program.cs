string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3" },
    new string[] { "1", "two", "3" },
    new string[] { "0", "1", "2" }
};

string overallStatusMessage = "";

try
{
    overallStatusMessage = Workflow1(userEnteredValues);

    if (overallStatusMessage == "operating procedure complete")
    {
        Console.WriteLine("'Workflow1' completed successfully.");
    }
}
catch (System.Exception ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static string Workflow1(string[][] userEnteredValues)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            processStatusMessage = Process1(userEntries);

            if (processStatusMessage == "process complete")
            {
                Console.WriteLine("'Process1' completed successfully.");
                Console.WriteLine();
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
        catch (DivideByZeroException ex)
        {
            throw new DivideByZeroException(ex.Message, ex);
        }

        operationStatusMessage = processStatusMessage;
    }

    if (operationStatusMessage == "good")
    {
        operationStatusMessage = "operating procedure complete";
    }

    return operationStatusMessage;
}

static string Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (DivideByZeroException ex)
        {
            processStatus = "error";
            throw new DivideByZeroException(
                "Invalid data. User input values must be non-zero values.",
                ex
            );
        }
        catch (FormatException ex)
        {
            processStatus = "error";
            throw new FormatException(
                "Invalid data. User input values must be valid integers.",
                ex
            );
        }
    }

    if (processStatus == "clean")
    {
        returnMessage = "process complete";
    }

    return returnMessage;
}
