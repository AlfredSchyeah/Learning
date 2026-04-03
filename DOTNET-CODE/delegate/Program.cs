// bool IsEven(int x)
// {
//     return x % 2 == 0;
// }

int[] CheckArray(int[] numbers, Func<int, bool> logic)
{
    int count = numbers.Length;
    int countEven = 0;

    for (int i = 0; i < count; i++)
    {
        if (logic(numbers[i]))
        {
            countEven++;
        }
    }

    int[] evenNumbers = new int[countEven];
    int pos = 0;
    for (int i = 0; i < count; i++)
    {
        if (logic(numbers[i]))
        {
            evenNumbers[pos] = numbers[i];
            pos++;
        }
    }
    return evenNumbers;
}

int[] ints = CheckArray(new int[] { 1, 2, 3, 4, 5 }, x => x % 2 == 0);



Console.WriteLine(String.Join(", ", ints));

// delegate bool MyMethodDelegate(int value);
