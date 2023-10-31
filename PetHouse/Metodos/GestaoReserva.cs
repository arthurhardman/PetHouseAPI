namespace PetHouse.Metodos
{
    public class GestaoReserva
    {
        private Dictionary<string, Reserva> reservasRegistradas = new Dictionary<string, Reserva>();
        public GestaoReserva()
        {
            reservasRegistradas["1"] = new Reserva(1, "405", "20/10");
            reservasRegistradas["2"] = new Reserva(2, "301", "21/10");
            reservasRegistradas["3"] = new Reserva(3, "201", "22/10");
            reservasRegistradas["4"] = new Reserva(4, "102", "23/10");
            reservasRegistradas["5"] = new Reserva(5, "303", "24/10");
        }

        public void AdicionarReserva(Reserva reserva)
        {
            reservasRegistradas[GetChaveUnica(reserva)] = reserva;
        }

        public Reserva ConsultarReserva(string numero)
        {
            string chave = $"{numero}";
            if (reservasRegistradas.ContainsKey(chave))
            {
                return reservasRegistradas[chave];
            }
            else
            {
                return null;
            }
        }

        private string GetChaveUnica(Reserva reserva)
        {
            return $"{reserva.Numero}";
        }
    }
}
