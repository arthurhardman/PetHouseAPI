using PetHouse.Metodos;
using System;

namespace PetHouse.MenuReserva
{
    internal class MenuReserva
    {
        private GestaoReserva gestaoReserva = new GestaoReserva();

        public void AdicionarReserva(int numero, string quarto, string data)
        {
            Reserva reserva = new Reserva(numero, quarto, data);
            gestaoReserva.AdicionarReserva(reserva);
            Console.WriteLine("Reserva adicionada com sucesso!");
        }

        public void ConsultarReserva(string numero)
        {
            Reserva reserva = gestaoReserva.ConsultarReserva(numero)!;
            if (reserva != null)
            {
                Console.WriteLine($"Reserva encontrada: Número {reserva.Numero}, Quarto {reserva.Quarto}, Data {reserva.Data}");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }

    }
}
