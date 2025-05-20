using System.Diagnostics; 
using Microsoft.Maui.Controls;
namespace layout
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute("crearcontacto", typeof(CrearContacto));
            Routing.RegisterRoute("contactos", typeof(Contactos));
            Routing.RegisterRoute("home", typeof(MainPage));
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("configuracion", typeof(Configuracion));
            

        }
    }
}