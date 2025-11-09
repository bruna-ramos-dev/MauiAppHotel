using Microsoft.Maui.Controls;
using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(Hospedagem hospedagem)
        {
            InitializeComponent();

            // Exibe as informações recebidas
            lblQuarto.Text = hospedagem.Quarto?.Descricao ?? "Não informado";
            lblAdultos.Text = hospedagem.Adultos.ToString();
            lblCriancas.Text = hospedagem.Criancas.ToString();
            lblCheckin.Text = hospedagem.Checkin.ToString("dd/MM/yyyy");
            lblCheckout.Text = hospedagem.Checkout.ToString("dd/MM/yyyy");

            // Calcula e mostra o total de dias e o valor total
            var dias = (hospedagem.Checkout - hospedagem.Checkin).Days;
            lblEstadia.Text = dias.ToString();

            // Exemplo de cálculo de valor total (ajuste conforme sua lógica)
            double valorDiaria = hospedagem.Quarto?.ValorDiariaAdulto ?? 250.0;
            double valorDiaria2 = hospedagem.Quarto?.ValorDiariaCrianca ?? 200.0;
            double total = valorDiaria * dias;
            lblValorTotal.Text = $"R$ {total:N2}";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
