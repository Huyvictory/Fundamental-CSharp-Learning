string[] sidesCoin = new string[] { "Head", "Tails" };

Console.WriteLine($"{sidesCoin[new Random().Next(0, 2)]}");
