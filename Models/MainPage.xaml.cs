using CadastroEventos.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    private Evento evento;

    public MainPage()
    {
        InitializeComponent();
        evento = new Evento
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today
        };
        BindingContext = evento;
    }

    private async void OnFinalizarCadastroClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoPage(evento));
    }
}
