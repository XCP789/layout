namespace layout
{
    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            var contactos = new List<Contacto>
            {
                new Contacto { Nombre = "admin", Telefono = "12345678", Correo = "iomm@gmail.com" },
                new Contacto { Nombre = "ospo", Telefono = "12345678", Correo = "pmef@gmail.com" }
            };

            ContactosCollectionView.ItemsSource = contactos;
        }
    }

    public class Contacto
    {
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
    }
}