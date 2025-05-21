using layout.Datos;
using layout.Modelos;

namespace layout
{
    public partial class CrearContacto : ContentPage
    {
        private ContactoDatabase db = new ContactoDatabase();
        private Contacto contacto;
        public CrearContacto()
    	{
    		InitializeComponent();
            contacto = new Contacto();

        }
        public CrearContacto(Contacto c)
        {
            InitializeComponent();
            contacto = c;

            nombreEntry.Text = contacto.Nombre;
            telefonoEntry.Text = contacto.Telefono;
            correoEntry.Text = contacto.Correo;
            direccionEntry.Text = contacto.Direccion;

        }
        private async void OnGuardarClicked(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nombreEntry.Text) ||
                string.IsNullOrWhiteSpace(telefonoEntry.Text) ||
                string.IsNullOrWhiteSpace(correoEntry.Text) ||
                string.IsNullOrWhiteSpace(direccionEntry.Text))
            {
                await DisplayAlert("Campos requeridos", "Todos los campos son obligatorios.", "OK");
                return;
            }

            contacto.Nombre = nombreEntry.Text;
            contacto.Telefono = telefonoEntry.Text;
            contacto.Correo = correoEntry.Text;
            contacto.Direccion = direccionEntry.Text;

            await db.GuardarContactoAsync(contacto);
            await Navigation.PopAsync();
        }
    }
    
}