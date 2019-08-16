using MovilGarage.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MovilGarage
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Version 1.0
    /// Clase principal de la aplicación donde se inicializa la vista principal.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public App()
        {
            InitializeComponent();
            MainPage = new Login();
        }
    }
}
