﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    /*
     * Manuel David Galvis Cardenas
     * Versión 1.0v
     * La clase es la encargada de realizar la vista del pagina donde se mostrara el mapa de google
     * y proximamente se mostrara la ubicación de los diferentes concesionarios recuperados de la
     * página web. 
     */
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class APIGoogleMapsxaml : ContentPage
	{
		public APIGoogleMapsxaml ()
		{
            var map = new Map(
                MapSpan.FromCenterAndRadius(
                    new Position(5.0550064, -75.50647), Distance.FromKilometers(13)))
            {
                IsShowingUser = true,
                HeightRequest = 320,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //var slider = new Slider(1, 18, 1);
            //slider.ValueChanged += (sender, e) =>
            //{
            //    var zoomLevel = e.NewValue;
            //    var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
            //    map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            //};
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
		}
	}
}