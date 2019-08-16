using MovilGarage.Dominio;
using MovilGarage.Logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    /// <summary>
    /// @author Manuel Galvis.
    /// @version Version 2.0
    /// Clase master del modelo MasterDetail que tendra la funcion de menu donde se seleccionara un concesionario registrado en la aplicacion.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UltimosVehiculosAgregadosViewMaster : ContentPage
    {
        public ListView ListView;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public UltimosVehiculosAgregadosViewMaster()
        {
            InitializeComponent();

            BindingContext = new UltimosVehiculosAgregadosViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        /// <summary>
        /// Clase ViewModel implementada en el modelo MasterDetail para la creación del menu de concesionarios registrados en la plataforma.
        /// </summary>
        class UltimosVehiculosAgregadosViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<UltimosVehiculosAgregadosViewMenuItem> MenuItems { get; set; }

            public UltimosVehiculosAgregadosViewMasterViewModel()
            {
                List<Vehiculo> listaVehiculos = new List<Vehiculo>();
                UltimosVehículos vehiculos = new UltimosVehículos();
                listaVehiculos = vehiculos.ConsultarUltimosVehiculos();
                UltimosVehiculosAgregadosViewMenuItem[] menu = new UltimosVehiculosAgregadosViewMenuItem[listaVehiculos.Count];
                for (int i = 0; i < listaVehiculos.Count; i++)
                {
                    menu[i] = new UltimosVehiculosAgregadosViewMenuItem
                    {
                        Id = i + 1,
                        Title = listaVehiculos[i].Placa,
                        Marca = listaVehiculos[i].Marca,
                        Modelo = listaVehiculos[i].Modelo,
                        Año = listaVehiculos[i].Año,
                        Color = listaVehiculos[i].Color,
                        NumeroChasis = listaVehiculos[i].NumeroChasis,
                        Concesionario = listaVehiculos[i].Concesionario,
                        Precio = listaVehiculos[i].Precio
                    };
                }
                MenuItems = new ObservableCollection<UltimosVehiculosAgregadosViewMenuItem>(menu);
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}