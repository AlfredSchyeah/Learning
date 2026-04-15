Console.WriteLine("Запрашиваем данные...");
string result = await GetDataAsync();
Console.WriteLine(result);

static async Task<string> GetDataAsync()
{
    await Task.Delay(20000);
    return "Данные получены!";
}