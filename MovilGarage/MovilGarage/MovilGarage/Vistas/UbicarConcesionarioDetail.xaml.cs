using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Version 3.0
    /// Esta clase crea un mapa consumiendo la API de google, creando así un mapa solo con la ubicación del usuario o un Pin con la ubicación de un concesionario seleccionado.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicarConcesionarioDetail : ContentPage
    {
        public Map map = new Map();
        
        /// <summary>
        /// Contrucotor que crea un mapa con la ubicación del usuario.
        /// </summary>
        public UbicarConcesionarioDetail()
        {
            map = new Map(
                MapSpan.FromCenterAndRadius(
                    new Position(5.0550064, -75.50647), Distance.FromKilometers(13)))
            {
                IsShowingUser = true,
                HeightRequest = 320,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }

        /// <summary>
        /// Constructor que crea un mapa con la ubicación del usuario y la ubicación de un concesionario seleccionado en el menu.
        /// </summary>
        /// <param name="latitud">Latitud cartografica para la ubicacion del pin</param>
        /// <param name="longitud">Longitud cartografica para la ubicacion del pin</param>
        /// <param name="direccion">Dirección del concesionario donde fue ubicado el pin</param>
        /// <param name="telefono">Telefono del concesionario donde fue ubicado el pin</param>
        public UbicarConcesionarioDetail(double latitud, double longitud, string direccion, string telefono)
        {
            map = new Map(
                MapSpan.FromCenterAndRadius(
                    new Position(5.0550064, -75.50647), Distance.FromKilometers(3)))
            {
                IsShowingUser = true,
                HeightRequest = 320,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var position = new Position(latitud, longitud);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = telefono,
                Address = direccion
            };
            map.Pins.Add(pin);
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }
    }
}