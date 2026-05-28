var http = new HttpClient();

System.Console.WriteLine("Cliente Joy Iniciada");

while (true)
{
    try
    {
        var response = await http.GetAsync("http://maestro:8000/aula");
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex.Message}");
    }
    Thread.Sleep(1000);
}
