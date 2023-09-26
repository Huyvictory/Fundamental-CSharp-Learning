const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

string[] divElements = { "<div>", "</div>" };
string[] spanElements = { "<span>", "</span>" };

int openingDivPosition = input.IndexOf(divElements[0]);
int closingDivPosition = input.IndexOf(divElements[1]);

int openingSpanPosition = input.IndexOf(spanElements[0]);
int closingSpanPosition = input.IndexOf(spanElements[1]);

output = input.Substring(
    openingDivPosition + divElements[0].Length,
    closingDivPosition - (openingDivPosition + divElements[0].Length)
);
output = output.Replace("&trade;", "&reg");

quantity = input.Substring(
    openingSpanPosition + spanElements[0].Length,
    closingSpanPosition - (openingSpanPosition + spanElements[0].Length)
);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
