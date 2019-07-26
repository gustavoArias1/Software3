using System;
using System.Collections.Generic;
using System.Text;
using MovilGarage.Dominio;


namespace MovilGarage.ServiciosDB
{
    /// <summary>
    /// @Gustavo Arias, Manuel Galvis, Cristian Diaz
    /// @version 3.0
    /// DBFake utilizada por el momento en la aplicacion para la obtencion de datos y ser probados.
    /// </summary>
    class ConexionBaseDatos
    {
        private List<Concesionario> concesionarios { set; get; }
        private List<Cliente> Clientes { set; get; }

        /// <summary>
        /// Concesionarios sacados de la base de datos para pruebas de la aplicacion.
        /// </summary>
        /// <returns>Lista de concesionarios</returns>
        public List<Concesionario> tablaConcesionarios()
        {
            concesionarios = new List<Concesionario>();
            concesionarios.Add(new Concesionario("CasaRestrepo", "calle 84 # 26 71","8 84 30 80", 5.042467, -75.4781977));
            concesionarios.Add(new Concesionario("AudiLosCoches", "carrera 23a # 74 128","8 87 01 11", 5.046661, -75.483607));
            concesionarios.Add(new Concesionario("Rasautos", "carrera 23a # 74 01","8 87 24 11", 5.047100, -75.483495));
            concesionarios.Add(new Concesionario("MercedesBenz", "carrera 23a # 23 02","8 75 20 43", 5.051364, -75.484303));
            concesionarios.Add(new Concesionario("Renault", "calle 67a # 18 03","8 82 11 10", 5.054323, -75.481586));
            concesionarios.Add(new Concesionario("CaldasMotor", "carrera 23 # 34 07","8 82 19 86", 5.057124, -75.486572));
            concesionarios.Add(new Concesionario("Volkswagen", "carrera 14 # 55 14","8 82 00 16", 5.060861, -75.484653));
            return this.concesionarios;
        }

        /// <summary>
        /// Clinetes sacados de la base de datos para pruebas de la aplicacion.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public List<Cliente> tablaClientes()
        {
            Clientes = new List<Cliente>();
            Clientes.Add(new Cliente("123@gmail.com", "UZF02FOO5RZ"));
            Clientes.Add(new Cliente("456@gmail.com", "FNN99WLK5RL"));
            Clientes.Add(new Cliente("789@gmail.com", "GQH19DHD1NK"));
            return this.Clientes;
        }
    }
}
