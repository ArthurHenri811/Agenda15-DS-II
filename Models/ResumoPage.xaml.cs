using CadastroEventos.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventos;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}
