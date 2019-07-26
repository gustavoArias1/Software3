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
    public partial class UbicarConcesionarioMaster : ContentPage
    {
        public ListView ListView;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public UbicarConcesionarioMaster()
        {
            InitializeComponent();
            
            BindingContext = new UbicarConcesionarioMasterViewModel();
            ListView = MenuItemsListView;
        }

        /// <summary>
        /// Clase ViewModel implementada en el modelo MasterDetail para la creación del menu de concesionarios registrados en la plataforma.
        /// </summary>
        class UbicarConcesionarioMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<UbicarConcesionarioMenuItem> MenuItems { get; set; }
            
            /// <summary>
            /// Constructor de la clase que crea en un ciclo el menú de los concesionarios asignandole unos parametros de otra clase 
            /// que serán utlizados como soporte de otros metodos de la aplicación.
            /// </summary>
            public UbicarConcesionarioMasterViewModel()
            {
                List<Concesionario> listaConcesionarios = new List<Concesionario>();
                UbicarConcesionarios concesionarios = new UbicarConcesionarios();
                listaConcesionarios = concesionarios.GetConcesionarios();
                UbicarConcesionarioMenuItem[] menu = new UbicarConcesionarioMenuItem[listaConcesionarios.Count];
                for (int i = 0; i < listaConcesionarios.Count; i++)
                {
                    menu[i] = new UbicarConcesionarioMenuItem { Id = i + 1, Title = listaConcesionarios[i].NombreConcesionario,
                        Latitud = listaConcesionarios[i].Latitud, Longitud = listaConcesionarios[i].Longitud,
                        Direccion = listaConcesionarios[i].Direccion, Telefono = listaConcesionarios[i].Telefono};
                }
                MenuItems = new ObservableCollection<UbicarConcesionarioMenuItem>(menu);
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