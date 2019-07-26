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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicarConcesionarioDetail : ContentPage
    {
        public Map map = new Map();
        public UbicarConcesionarioMenuItem aux;
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