// See https://aka.ms/new-console-template for more information
/*Console.Write("Введите сумму чека ");
string sum = Console.ReadLine();
Console.Write("Введите процент чаевых ");
string tips = Console.ReadLine();
Console.Write("Введите кол-во человек ");
string persons = Console.ReadLine();

double fullSum;
double fullTips;
double perPerson;

fullTips = double.Parse(sum) * double.Parse(tips) / 100;
fullSum = double.Parse(sum) + fullTips;
perPerson = fullSum / double.Parse(persons);

Console.WriteLine($"Сумма чека с чаевыми {Math.Round(fullSum, 2)}");
Console.WriteLine($"Чаевые {Math.Round(fullTips, 2)}");
Console.WriteLine($"Сумма на человека {Math.Round(perPerson, 2)}");
*/
Console.Write("Введите сумму счёта: ");
double billAmount = double.Parse(Console.ReadLine());

Console.Write("Введите процент чаевых: ");
double tipPercentage = double.Parse(Console.ReadLine());

Console.Write("Введите количество человек: ");
int numberOfPeople = int.Parse(Console.ReadLine());

double tipAmount = billAmount * tipPercentage / 100;
double totalAmount = billAmount + tipAmount;
double perPersonAmount = totalAmount / numberOfPeople;

Console.WriteLine($"Общий счёт: {totalAmount}");
Console.WriteLine($"Процент чаевых: {tipPercentage}%");
Console.WriteLine($"С каждого: {perPersonAmount}");