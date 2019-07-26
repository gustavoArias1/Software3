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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private IngresarAlSistema autenticarse;
        private string usuario;
        private string contraseña;

        public Login()
        {
            InitializeComponent();
        }

        void onEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            usuario = e.NewTextValue;
        }

        void ingresoContraseña(object sender, TextChangedEventArgs e)
        {
            contraseña = e.NewTextValue;
        }

        void onEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            this.autenticarse = new IngresarAlSistema();
            if (autenticarse.auntenticarseSistema(usuario, contraseña))
            {
                await Navigation.PushModalAsync(new UbicarConcesionario());
            }
            else
            {
                await DisplayAlert("Usuario incorrecto", "El usuario ingresado es incorrecto", "OK");
            }
        }
    }
}