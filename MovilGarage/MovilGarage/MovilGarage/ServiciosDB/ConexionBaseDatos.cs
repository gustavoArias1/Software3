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
    public class ConexionBaseDatos
    {
        public List<Concesionario> Concesionarios = new List<Concesionario>();
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Vehiculo> Vehiculos = new List<Vehiculo>();

        /// <summary>
        /// Concesionarios sacados de la base de datos para pruebas de la aplicacion.
        /// </summary>
        /// <returns>Lista de concesionarios</returns>
        public List<Concesionario> TablaConcesionarios()
        {
            Concesionarios.Add(new Concesionario("CasaRestrepo", "calle 84 # 26 71","8 84 30 80", 5.042467, -75.4781977));
            Concesionarios.Add(new Concesionario("AudiLosCoches", "carrera 23a # 74 128","8 87 01 11", 5.046661, -75.483607));
            Concesionarios.Add(new Concesionario("Rasautos", "carrera 23a # 74 01","8 87 24 11", 5.047100, -75.483495));
            Concesionarios.Add(new Concesionario("MercedesBenz", "carrera 23a # 23 02","8 75 20 43", 5.051364, -75.484303));
            Concesionarios.Add(new Concesionario("Renault", "calle 67a # 18 03","8 82 11 10", 5.054323, -75.481586));
            Concesionarios.Add(new Concesionario("CaldasMotor", "carrera 23 # 34 07","8 82 19 86", 5.057124, -75.486572));
            Concesionarios.Add(new Concesionario("Volkswagen", "carrera 14 # 55 14","8 82 00 16", 5.060861, -75.484653));
            return Concesionarios;
        }

        /// <summary>
        /// Clinetes sacados de la base de datos para pruebas de la aplicacion.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public List<Cliente> TablaClientes()
        {
            Clientes.Add(new Cliente("123@gmail.com", "UZF02FOO5RZ"));
            Clientes.Add(new Cliente("456@gmail.com", "FNN99WLK5RL"));
            Clientes.Add(new Cliente("789@gmail.com", "GQH19DHD1NK"));
            return Clientes;
        }
        /// <summary>
        /// Vehiculos sacados de la base de datos
        /// </summary>
        /// <returns>Lista de vehiculos.</returns>
        public List<Vehiculo> TablaVehiculos()
        {
            Vehiculos.Add(new Vehiculo("abc123", "Commodo LLC", "cx5", "2018", "12500", "Blanco", "Audi", "200000", DateTime.Today,"../Resources/Audi.jpg"));
            Vehiculos.Add(new Vehiculo("BEG 287", "Commodo LLC", "cx5", "2019", "40376", "green", "Nissan", "4367285",new DateTime(2019,2,24), "../Resources/Audi2.jpg"));
            Vehiculos.Add(new Vehiculo("BIL 434", "Commodo LLC", "cx5", "2017", "07600", "violet", "Nissan", "166952141", DateTime.Today, "../Resources/Ford.jpg"));
            Vehiculos.Add(new Vehiculo("BSV 173", "Commodo LLC", "cx5", "2018", "99213", "orange", "ford", "32623205", DateTime.Today, "../Resources/Nissan.jpg"));
            Vehiculos.Add(new Vehiculo("CMJ 848", "a2", "cx5", "2018", "36198", "yellow", "Audi", "93500821",new DateTime(2019,3,15), "../Resources/Audi.jpg"));
            return Vehiculos;
        }

    }
}
