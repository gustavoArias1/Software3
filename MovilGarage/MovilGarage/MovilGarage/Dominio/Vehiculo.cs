using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string NumeroChasis { get; set; }
        public string Color { get; set; }
        public string Concesionario { get; set; }
        public string Precio { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public string Url { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string año, string numeroChasis, string color, string concesionario, string precio,DateTime fechaAdquisicion, string url)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.NumeroChasis = numeroChasis;
            this.Color = color;
            this.Concesionario = concesionario;
            this.Precio = precio;
            this.FechaAdquisicion = fechaAdquisicion;
            this.Url = url;
        }

    }
}
