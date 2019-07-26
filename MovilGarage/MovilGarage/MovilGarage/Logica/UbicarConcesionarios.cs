using MovilGarage.Dominio;
using MovilGarage.ServiciosDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Logica
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Version 1.0
    /// Permite la ubicacion de los concesionarios registrados en la plataforma.
    /// </summary>
    public class UbicarConcesionarios
    {
        private ConexionBaseDatos conexion;
        private List<Concesionario> listaConcesionarios;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public UbicarConcesionarios()
        {
            conexion = new ConexionBaseDatos();
            listaConcesionarios = conexion.tablaConcesionarios();
        }

        /// <summary>
        /// Se obtiene los concesionarios registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de concesionarios recuperados</returns>
        public List<Concesionario> GetConcesionarios()
        {
            return listaConcesionarios;
        }
    }
}
