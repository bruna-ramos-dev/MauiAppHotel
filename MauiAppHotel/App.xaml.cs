using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // ✅ Ajuste 3: transformar a lista em uma propriedade pública com inicialização simplificada
        public List<Quarto> lista_quartos { get; private set; }

        public App()
        {
            InitializeComponent();

            // ✅ Inicializa a lista de quartos de forma clara e segura
            lista_quartos = new List<Quarto>
            {
                new Quarto
                {
                    Descricao = "Suíte Super Luxo",
                    ValorDiariaAdulto = 110.0,
                    ValorDiariaCrianca = 55.0
                },
                new Quarto
                {
                    Descricao = "Suíte Luxo",
                    ValorDiariaAdulto = 80.0,
                    ValorDiariaCrianca = 40.0
                },
                new Quarto
                {
                    Descricao = "Suíte Single",
                    ValorDiariaAdulto = 50.0,
                    ValorDiariaCrianca = 25.0
                },
                new Quarto
                {
                    Descricao = "Suíte Crise",
                    ValorDiariaAdulto = 25.0,
                    ValorDiariaCrianca = 12.5
                }
            };

            // ✅ Define a tela inicial do aplicativo com suporte a navegação
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            // ✅ Define o tamanho padrão da janela
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
