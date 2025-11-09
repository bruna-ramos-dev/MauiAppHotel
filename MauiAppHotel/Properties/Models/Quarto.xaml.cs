namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }

        public override string ToString()
        {
            return $"{Descricao} - Adulto: R$ {ValorDiariaAdulto:F2}, Criança: R$ {ValorDiariaCrianca:F2}";
        }
    }
}
