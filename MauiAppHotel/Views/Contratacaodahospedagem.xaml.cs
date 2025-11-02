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
}