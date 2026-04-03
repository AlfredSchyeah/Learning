List<int> ints = Enumerable.Range(0, 10)
    .Select(item => Random.Shared.Next(10))
    .Select(item => item * 7)
    .Where(item => item % 2 == 0)
    .OrderBy(item => item)
    .ToList();

Console.WriteLine(ints.Count);
Console.WriteLine(String.Join(", ", ints));