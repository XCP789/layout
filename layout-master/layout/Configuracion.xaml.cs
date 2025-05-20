namespace layout;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private async void OnLogoutTapped(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Cerrar sesión", "¿Estás seguro?", "Sí", "No");
        if (confirm)
        {
            SecureStorage.Remove("hasAuth");

            await Shell.Current.GoToAsync("//login");

        }
    }
}