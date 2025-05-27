namespace layout;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
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