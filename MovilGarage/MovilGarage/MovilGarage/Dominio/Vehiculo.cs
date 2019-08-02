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
        public string numeroChasis { get; set; }
        public string Color { get; set; }
        public string Concesionario { get; set; }
        public string Precio { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string año, string numeroChasis, string color, string concesionario, string precio)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.numeroChasis = numeroChasis;
            this.Color = color;
            this.Concesionario = concesionario;
            this.Precio = precio;
        }

    }
}
