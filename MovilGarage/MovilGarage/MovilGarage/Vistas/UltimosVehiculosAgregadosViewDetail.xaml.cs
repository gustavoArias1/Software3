using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UltimosVehiculosAgregadosViewDetail : ContentPage
    {
        public UltimosVehiculosAgregadosViewDetail()
        {
            InitializeComponent();
        }

        public UltimosVehiculosAgregadosViewDetail(string Marca, string Modelo, string Año, string NumeroChasis, string Color, string Concesionario, string Precio, string Url)
        {
            InitializeComponent();
            BindingContext = this;
            Imagen = new Image{ Source = ImageSource.FromResource(Url)};
            MarcaLogic.Text = Marca;
            ModeloLogic.Text = Modelo;
            AñoLogic.Text = Año;
            ChasisLogic.Text = NumeroChasis;
            ColorLogic.Text = Color;
            ConcesionarioLogic.Text = Concesionario;
            PrecioLogic.Text = Precio;
        }
    }
}