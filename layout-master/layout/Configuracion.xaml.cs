namespace layout;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private async void OnLogoutTapped(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Cerrar sesi�n", "�Est�s seguro?", "S�", "No");
        if (confirm)
        {
            SecureStorage.Remove("hasAuth");

            await Shell.Current.GoToAsync("//login");

        }
    }
}