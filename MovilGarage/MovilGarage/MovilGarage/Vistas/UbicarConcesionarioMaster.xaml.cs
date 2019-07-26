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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicarConcesionarioMaster : ContentPage
    {
        public ListView ListView;

        public UbicarConcesionarioMaster()
        {
            InitializeComponent();
            
            BindingContext = new UbicarConcesionarioMasterViewModel();
            ListView = MenuItemsListView;
        }

        class UbicarConcesionarioMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<UbicarConcesionarioMenuItem> MenuItems { get; set; }
            
            public UbicarConcesionarioMasterViewModel()
            {
                List<Concesionario> listaConcesionarios = new List<Concesionario>();
                UbicarConcesionarios concesionarios = new UbicarConcesionarios();
                listaConcesionarios = concesionarios.GetConcesionarios();
                UbicarConcesionarioMenuItem[] menu = new UbicarConcesionarioMenuItem[listaConcesionarios.Count];
                for (int i = 0; i < listaConcesionarios.Count; i++)
                {
                    menu[i] = new UbicarConcesionarioMenuItem { Id = i + 1, Title = listaConcesionarios[i].nombreConcesionario};
                }
                MenuItems = new ObservableCollection<UbicarConcesionarioMenuItem>(menu);
                /*MenuItems = new ObservableCollection<UbicarConcesionarioMenuItem>(new[]
                {
                    new UbicarConcesionarioMenuItem { Id = 0, Title = "Page 1" },
                    new UbicarConcesionarioMenuItem { Id = 1, Title = "Page 2" },
                    new UbicarConcesionarioMenuItem { Id = 2, Title = "Page 3" },
                    new UbicarConcesionarioMenuItem { Id = 3, Title = "Page 4" },
                    new UbicarConcesionarioMenuItem { Id = 4, Title = "Page 5" },
                });*/
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