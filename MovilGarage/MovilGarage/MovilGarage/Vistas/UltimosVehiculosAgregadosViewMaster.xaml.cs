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
    public partial class UltimosVehiculosAgregadosViewMaster : ContentPage
    {
        public ListView ListView;

        public UltimosVehiculosAgregadosViewMaster()
        {
            InitializeComponent();

            BindingContext = new UltimosVehiculosAgregadosViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class UltimosVehiculosAgregadosViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<UltimosVehiculosAgregadosViewMenuItem> MenuItems { get; set; }

            public UltimosVehiculosAgregadosViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<UltimosVehiculosAgregadosViewMenuItem>(new[]
                {
                    new UltimosVehiculosAgregadosViewMenuItem { Id = 0, Title = "Page 1" },
                    new UltimosVehiculosAgregadosViewMenuItem { Id = 1, Title = "Page 2" },
                    new UltimosVehiculosAgregadosViewMenuItem { Id = 2, Title = "Page 3" },
                    new UltimosVehiculosAgregadosViewMenuItem { Id = 3, Title = "Page 4" },
                    new UltimosVehiculosAgregadosViewMenuItem { Id = 4, Title = "Page 5" },
                });
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