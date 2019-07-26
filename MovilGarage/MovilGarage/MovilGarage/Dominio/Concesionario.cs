using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    /// <summary>
    /// @author Gustavo Arias, Cristian Diaz
    /// @version Version 3.0
    /// </summary>
    public class Concesionario
    {
        public string nombreConcesionario { get; set; }
        public string direccion { get; set; }
        public string telefono  { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        /// <summary>
        /// Contructor de la clase Concesionario
        /// </summary>
        /// <param name="nombreConcesionario">Nombre del concesionario registrado</param>
        /// <param name="direccion">Direccion del concesionario registrado</param>
        /// <param name="telefono">Telefono del concesionario registrado</param>
        /// <param name="latitud">La latitud cartografíca del concesinario para su ubicación en la API de google</param>
        /// <param name="longitud">La longitud cartografíca del concesionario para su ubicación en la API de google</param>
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
