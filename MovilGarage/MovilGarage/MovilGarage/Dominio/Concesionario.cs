using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    public class Concesionario
    {
        private string nombreConcesionario { get; set; }
        private double latitud { get; set; }
        private double longitud { get; set; }

        public Concesionario(string nombreConcesionario, double latitud, double longitud)
        {
            this.nombreConcesionario = nombreConcesionario;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        
    }
    
}
