using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    class Concesionario
    {
        private string nombreConcesionario { get; set; }
        private double Latitud { get; set; }
        private double Longitud { get; set; }

        public Concesionario(string nombreConcesionario, double latitud, double longitud)
        {
            this.nombreConcesionario = nombreConcesionario;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }

        
    }
    
}
