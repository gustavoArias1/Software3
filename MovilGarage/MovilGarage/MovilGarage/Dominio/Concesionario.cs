using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    public class Concesionario
    {
        public string nombreConcesionario { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        public Concesionario(string nombreConcesionario, double latitud, double longitud)
        {
            this.nombreConcesionario = nombreConcesionario;
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
    
}
