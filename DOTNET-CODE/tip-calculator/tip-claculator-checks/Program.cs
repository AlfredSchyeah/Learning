// See https://aka.ms/new-console-template for more information
Console.Write("Введите сумму счёта: ");
double billAmount;
if (!double.TryParse(Console.ReadLine(), out billAmount) || billAmount <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    Console.Write("Введите процент чаевых: ");
    double tipPercentage;
    if (!double.TryParse(Console.ReadLine(), out tipPercentage) || tipPercentage <= 0)
    {
        Console.WriteLine("Ошибка ввода");
    }
    else
    {
        Console.Write("Введите количество людей: ");
        int numberOfPeople;
        if (!int.TryParse(Console.ReadLine(), out numberOfPeople) || numberOfPeople < 1)
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            double tipAmount = billAmount * tipPercentage / 100;
            double totalAmount = billAmount + tipAmount;
            double perPersonAmount = totalAmount / numberOfPeople;

            Console.WriteLine($"Общий счёт: {totalAmount}");
            Console.WriteLine($"Чаевые: {tipAmount}");
            Console.WriteLine($"Счет на человека: {Math.Round(perPersonAmount, 2)}");
        }
    }
}




// Console.Write("Введите сумму счёта: ");
// double billAmount = double.Parse(Console.ReadLine());
// Console.Write("Введите процент чаевых: ");
// double tipPercentage = double.Parse(Console.ReadLine());
// Console.Write("Введите количество человек: ");
// int numberOfPeople = int.Parse(Console.ReadLine());


// if (billAmount <= 0 || tipPercentage <= 0 || numberOfPeople < 1)
// {
//     Console.WriteLine("Введите корректные данные");
// }
// else
// {
//     double tipAmount = billAmount * tipPercentage / 100;
//     double totalAmount = billAmount + tipAmount;
//     double perPersonAmount = totalAmount / numberOfPeople;

//     Console.WriteLine($"Общий счёт: {totalAmount}");
//     Console.WriteLine($"Процент чаевых: {tipPercentage}%");
//     Console.WriteLine($"С каждого: {perPersonAmount}");
// }