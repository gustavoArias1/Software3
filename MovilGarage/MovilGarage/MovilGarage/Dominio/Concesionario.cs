using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    public class Concesionario
    {
        public string nombreConcesionario { get; set; }
     
        public string direccion { get; set; }
        public string telefono  { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        public Concesionario(string nombreConcesionario, string direccion,string telefono, double latitud, double longitud)
        {
            this.nombreConcesionario = nombreConcesionario;
            this.direccion = direccion;
            this.telefono = telefono;
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
    
}
