

namespace MauiAppHotel.Views;

public partial class Contratacaodahospedagem : ContentPage
{
    public Contratacaodahospedagem()
    {
        InitializeComponent();
    }
    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }catch(Exception ex)

        { DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}