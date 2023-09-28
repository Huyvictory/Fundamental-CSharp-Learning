string[,] corporate =
{
    { "Robert", "Bavin" },
    { "Simon", "Bright" },
    { "Kim", "Sinclair" },
    { "Aashrita", "Kamath" },
    { "Sarah", "Delucchi" },
    { "Sinan", "Ali" }
};

string[,] external =
{
    { "Vinnie", "Ashton" },
    { "Cody", "Dysart" },
    { "Shay", "Lawrence" },
    { "Daren", "Valdes" }
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayInternalExternalEmails(i, corporate);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayInternalExternalEmails(i, external, externalDomain);
}

void DisplayInternalExternalEmails(
    int index,
    string[,] employeeFullName,
    string domain = "contoso.com"
)
{
    Console.WriteLine(
        $"{employeeFullName[index, 0].Substring(0, 2).ToLower()}{employeeFullName[index, 1].ToLower()}@{domain}"
    );
}
