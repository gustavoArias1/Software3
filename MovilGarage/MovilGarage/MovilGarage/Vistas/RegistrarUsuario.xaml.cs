using MovilGarage.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Versión 1.0
    /// ViewModel de la interfaz del login donde se manejara el registro de un nuevo usuario en la aplicación en la aplicacion.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarUsuario : ContentPage
    {
        private string usuario;
        private string contraseña;
        private string segundaContraseña;
        private RegistrarNuevoUsuario registrarUsuario;

        /// <summary>
        /// Inicialización de los componentes.
        /// </summary>
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que cambia el texto a medida que es ingresado en el campo de texto y asigna el usuario a un atributo global.
        /// </summary>
        /// <param name="sender">Objeto que envia la respuesta del metodo.</param>
        /// <param name="e">Evento que se recibe cuando se cambia el texto en el campo de texto de la vista.</param>
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            usuario = e.NewTextValue;
        }

        /// <summary>
        /// Metodo que una vez completado el texto envia el texto a la vista
        /// </summary>
        /// <param name="sender">Objeto que envia la respuesta del metodo.</param>
        /// <param name="e">Evento del metodo</param>
        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        /// <summary>
        /// Evento del boton ingresar una vez que es clickeado para validar si el usuario se encuentra registrado o ingreso mal sus credenciales.
        /// </summary>
        /// <param name="sender">Objeto que envia la respuesta del metodo.</param>
        /// <param name="e">Evento que se recibe cuando se cambia el texto en el campo de texto de la vista.</param>
        async void Button_Clicked(object sender, EventArgs e)
        {
            if (usuario == null || contraseña == null || segundaContraseña == null)
            {
                await DisplayAlert("Campos vacíos", "Todos los campos deben estar llenos", "OK");
            }
            else
            {
                this.registrarUsuario = new RegistrarNuevoUsuario();
                if (!registrarUsuario.ValidaciónDeUsuario(usuario))
                {
                    await DisplayAlert("Formato invalido", "El formato del correo es invalido", "OK");
                }
                else
                {
                    if (registrarUsuario.RegistraUsuario(usuario, contraseña, segundaContraseña))
                    {
                        await DisplayAlert("Usuario registrado", "El usuario ha sido registrado en la plataforma", "OK");
                        await Navigation.PushModalAsync(new Login());
                    }
                    else
                    {
                        await DisplayAlert("Usuario no registrado", "El usuario no ha podido ser registrado en la plataforma", "OK");
                    }
                }
            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            contraseña = e.NewTextValue;
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            segundaContraseña = e.NewTextValue;
        }
    }
}