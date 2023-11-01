using PetHouse.Classes;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string jsonUrl = "https://raw.githubusercontent.com/arthurhardman/PetHouse/master/reservas.json";
    string githubToken = "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";
    client.DefaultRequestHeaders.Add("Authorization", $"token {githubToken}");
    try
    {
        string resposta = await client.GetStringAsync(jsonUrl);
        var reservas = JsonSerializer.Deserialize<List<Reservas>>(resposta)!;
        reservas[1].ExibirReservas();
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
    }
}
