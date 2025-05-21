using layout.Datos;
using layout.Modelos;

namespace layout
{
    public partial class Contactos : ContentPage
    {
        private ContactoDatabase db = new ContactoDatabase();

        public Contactos()
        {
            InitializeComponent();
            //this.db = db;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            contactosView.ItemsSource = await db.ObtenerContactosAsync();
        }

        private async void OnAgregarContactoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearContacto());
        }

        private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contacto seleccionado)
            {
                await Navigation.PushAsync(new CrearContacto(seleccionado));
            }
        }

        private async void OnEliminarContacto(object sender, EventArgs e)
        {
            if (((SwipeItem)sender).BindingContext is Contacto contacto)
            {
                bool confirm = await DisplayAlert("Confirmar", $"¿Eliminar a {contacto.Nombre}?", "Sí", "No");
                if (confirm)
                {

                    await db.EliminarContactoAsync(contacto);
                    contactosView.ItemsSource = await db.ObtenerContactosAsync();
                }
            }
        }

        private async void OnConfiguracionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Configuracion());
        }




    }






}