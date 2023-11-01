using System.Net.Http.Headers;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PetHouse.Classes;

internal class Reservas
{
    [JsonPropertyName("Numero")]
    public int? numero { get; set; }

    [JsonPropertyName("Quarto")]
    public string? quarto { get; set; }

    [JsonPropertyName("Data")]
    public string? data { get; set; }

    [JsonPropertyName("Valor")]
    public int? valor { get; set; }

    public void ExibirReservas()
    {
        Console.WriteLine($"Numero da Reserva: {numero}");
        Console.WriteLine($"Numero do Quarto: {quarto}");
        Console.WriteLine($"Data da Reserva: {data}");
        Console.WriteLine($"Valor da Reserva: {valor}");
    }

    public async Task AdicionarReserva()
    {
            // Coletar informações do usuário para a nova reserva
            Console.WriteLine("Informe o número da reserva: ");
            int numeroReserva = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o número do quarto: ");
            string numeroQuarto = Console.ReadLine()!;

            Console.WriteLine("Informe a data da reserva: ");
            string dataReserva = Console.ReadLine()!;

            Console.WriteLine("Informe o valor da reserva: ");
            int valorReserva = int.Parse(Console.ReadLine()!);

        var novaReserva = new Reservas
        {
            numero = numeroReserva,
            quarto = numeroQuarto,
            data = dataReserva,
            valor = valorReserva
        };
    }
}

