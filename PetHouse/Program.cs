using System;
using PetHouse.Metodos;
using PetHouse.MenuReserva;

void ExibirLogo()
{
    Console.WriteLine(@"
█▀█ █▀▀ ▀█▀ █░█ █▀█ █░█ █▀ █▀▀
█▀▀ ██▄ ░█░ █▀█ █▄█ █▄█ ▄█ ██▄");
    Console.WriteLine("\nBoas vindas ao PetHouse!");
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para Adicionar Reserva");
    Console.WriteLine("Digite 2 para Consultar Reserva");
    Console.WriteLine("Digite 3 para Sair");

    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    MenuReserva menuReserva = new MenuReserva();

    switch (opcaoEscolhida)
    {
        case "1":
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Quarto: ");
            string quarto = Console.ReadLine()!;
            Console.Write("Data: ");
            string data = Console.ReadLine()!;
            menuReserva.AdicionarReserva(numero, quarto, data);
            break;
        case "2":
            Console.Write("Número da reserva: ");
            string numeroReserva = Console.ReadLine()!;
            menuReserva.ConsultarReserva(numeroReserva);
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

ExibirMenu();
