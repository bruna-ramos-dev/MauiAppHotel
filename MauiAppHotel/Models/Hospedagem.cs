namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
    }
}
