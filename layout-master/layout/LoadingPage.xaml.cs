namespace layout;

public partial class LoadingPage : ContentPage
{
    public LoadingPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        try
        {
            await Task.Delay(2000); 
            var hasAuth = await SecureStorage.GetAsync("hasAuth");

            if (hasAuth == "true")
                await Shell.Current.GoToAsync("//home");
            else
                await Shell.Current.GoToAsync("//login");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error crítico: {ex}");
            Application.Current.MainPage = new LoginPage();
        }
    }
}