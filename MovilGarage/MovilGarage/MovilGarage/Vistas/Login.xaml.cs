﻿using MovilGarage.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Versión 1.0
    /// ViewModel de la interfaz del login donde se manejara el ingreso en la aplicacion.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private IngresarAlSistema autenticarse;
        private string usuario;
        private string contraseña;

        /// <summary>
        /// Inicialización de los componentes.
        /// </summary>
        public Login()
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
        /// Método que asigna la contraseña un atributo global para ser utilizado en la autenticación.
        /// </summary>
        /// <param name="sender">>Objeto que envia la respuesta del metodo.</param>
        /// <param name="e">Evento que se recibe cuando se cambia el texto en el campo de texto de la vista.</param>
        void IngresoContraseña(object sender, TextChangedEventArgs e)
        {
            contraseña = e.NewTextValue;
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
            this.autenticarse = new IngresarAlSistema();
            if (autenticarse.AuntenticarseSistema(usuario, contraseña))
            {
                await Navigation.PushModalAsync(new Menu());
            }
            else
            {
                await DisplayAlert("Usuario incorrecto", "El usuario o la contraseña es incorrecto", "OK");
            }
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrarUsuario());
        }
    }
}