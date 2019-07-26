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
        public string NombreConcesionario { get; set; }
        public string Direccion { get; set; }
        public string Telefono  { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }

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
            this.NombreConcesionario = nombreConcesionario;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }
    }
    
}
