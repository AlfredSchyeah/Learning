int sum = default;

Console.Write("Столица Испании? [Барселона], [Мадрид], [Париж] ");
string Spain = Console.ReadLine();
if (Spain.ToLowerInvariant() == "мадрид")
{
    Console.Write("Правильно!");
    sum += 1;
}
else
{
    Console.WriteLine("😭");
}

Console.Write("Столица Италии? [Рим], [Флоренция], [Милан] ");
string Italy = Console.ReadLine();
if (Italy.ToLowerInvariant() == "рим")
{
    Console.Write("Правильно!");
    sum += 1;
}
else
{
    Console.WriteLine("😭");
}

Console.Write("Столица Китая? [Пекин], [Шанхай], [Гонконг] ");
string China = Console.ReadLine();
if (China.ToLowerInvariant() == "пекин")
{
    Console.Write("Правильно!");
    sum += 1;
}
else
{
    Console.WriteLine("😭");
}

Console.WriteLine($"Ваш результат: {sum}");