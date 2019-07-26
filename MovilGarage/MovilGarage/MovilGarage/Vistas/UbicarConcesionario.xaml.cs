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
    /// @author Manuel Galvis.
    /// @version Version 3.0
    /// Clase que maneja los eventos en el modelo MasterDetail propia de xamarin.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicarConcesionario : MasterDetailPage
    {
        public UbicarConcesionarioDetail detalle;

        /// <summary>
        /// Constructor de la clase que unicializa los componentes y evalua los items seleccionados en el menu.
        /// </summary>
        public UbicarConcesionario()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        /// <summary>
        /// Método que toma la accion de crear una nueva pagina de contenido una vez es seleccionado algún item del menú.
        /// </summary>
        /// <param name="sender">Objeto que interactua con la lista para el envio de informacion.</param>
        /// <param name="e">Variable que toma los atributos de un item seleccionado del menu.</param>
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as UbicarConcesionarioMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(new UbicarConcesionarioDetail(item.Latitud, item.Longitud, item.Direccion, item.Telefono));
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}