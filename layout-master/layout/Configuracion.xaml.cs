using layout.Utils;
using System.Globalization;

namespace layout;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
        // Configurar el evento de cambio de tema
        temaSwitch.IsToggled = ConfiguracionApp.ObtenerTema();
    }
    private void OnTemaToggled(object sender, ToggledEventArgs e)
    {
        ConfiguracionApp.GuardarTema(e.Value);

        Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;

        lblEstado.IsVisible = true;
    }
    private async void OnLogoutTapped(object sender, EventArgs e)
    {
        
        if (await DisplayAlert("Cerrar sesión", "¿Estás seguro?", "Sí", "No"))
		{
            Preferences.Remove("UsuarioActual");
            SecureStorage.RemoveAll();
			await Shell.Current.GoToAsync("///login");
		}
        
    }
}