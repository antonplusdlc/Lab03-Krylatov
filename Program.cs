Console.WriteLine("Банковский счет");

double balance = 1000;
Console.WriteLine($"Starting balance: {balance}");

balance += 500; // ++
Console.WriteLine($"Popolnenie na 500: {balance}");

balance -= 200; // buy
Console.WriteLine($"after buying: {balance}");

balance *= 1.05; // + 5%
Console.WriteLine($"+ 5%: {balance}");

balance /= 2; // партнер украл половину
Console.WriteLine($"после кражи: {balance}");

Console.WriteLine();
Console.WriteLine("постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++: {lessonNumber++}");
Console.WriteLine($"after: {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber: {++weekNumber}");
Console.WriteLine($"after: {weekNumber}");

Console.WriteLine();
Console.WriteLine("lovushka");

int attempts = 0;
Console.WriteLine($"attempt №{++attempts}");
Console.WriteLine($"attempt №{++attempts}");
Console.WriteLine($"Attempts: {attempts}");