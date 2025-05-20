namespace layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void IrListaContactos(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("contactos");
        }

        private async void IrCrearContacto(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("crearcontacto");
        }

        private async void IrConfiguracion(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("configuracion");
        }
    }
}