﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilGarage.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicarConcesionario : MasterDetailPage
    {
        public UbicarConcesionarioDetail detalle;
        public UbicarConcesionario()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as UbicarConcesionarioMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(new UbicarConcesionarioDetail(item.Latitud, item.Longitud));
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}