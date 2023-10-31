namespace PetHouse.Metodos
{
    public class Reserva
    {
        public Reserva(int numero, string quarto, string data)
        {
            Numero = numero;
            Quarto = quarto;
            Data = data;
        }

        public int Numero { get; set; }
        public string Quarto { get; set; }
        public string Data { get; set; }
        
    }
}
