using MauiAppHotel.Models;
using Microsoft.Maui.Controls;
using System;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        // ✅ AJUSTE 4:
        // Torna o campo somente leitura e usa convenção de nomenclatura em C#
        private readonly App _propriedadesApp;
        

        public ContratacaoHospedagem()
        {
            InitializeComponent();

            // Inicializa a referência ao App principal
            _propriedadesApp = (App)Application.Current;

            // Preenche o Picker com a lista de quartos cadastrados no App
            pck_quarto.ItemsSource = _propriedadesApp.lista_quartos;

            // Define as restrições de data corretamente
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

            // Define o intervalo de checkout inicial
            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Captura os valores dos controles
                int adultos = (int)stp_adultos.Value;
                int criancas = (int)stp_criancas.Value;
                var quartoSelecionado = (Quarto)pck_quarto.SelectedItem;
                DateTime checkin = dtpck_checkin.Date;
                DateTime checkout = dtpck_checkout.Date;

                // Cria o objeto com os dados da hospedagem
                var hospedagem = new Hospedagem
                {
                    Adultos = adultos,
                    Criancas = criancas,
                    Quarto = quartoSelecionado,
                    Checkin = checkin,
                    Checkout = checkout
                };

                // Envia o objeto para a próxima página
                await Navigation.PushAsync(new HospedagemContratada(hospedagem));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


        // ✅ AJUSTE 4:
        // Corrige nomenclatura e aviso de referência nula potencial
        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (sender is DatePicker elemento)
            {
                var dataSelecionada = elemento.Date;

                // Atualiza as restrições do checkout de acordo com o check-in
                dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
                dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);
            }
        }
    }
}
