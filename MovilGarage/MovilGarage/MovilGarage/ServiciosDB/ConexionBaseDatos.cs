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
            Vehiculos.Add(new Vehiculo("abc123", "Audi", "cx5", "2018", "12500", "Blanco", "CasaRestrepo", "20000000", DateTime.Today, "https://www.diariomotor.com/imagenes/2018/11/audi-r8-2019-ficha-1118-005.jpg"));
            Vehiculos.Add(new Vehiculo("BEG 287", "Audi", "cx9", "2019", "40376", "green", "LosRosales", "40367285",new DateTime(2019,2,24), "https://www.audi.com.co/media/ThreeColTeaser_TextImage_Image_Component/5716-paragraphs-23515-281562-image/dh-900-bc764f/f5690918/1555402192/audi-q3-s-line-black-home.jpg"));
            Vehiculos.Add(new Vehiculo("BIL 434", "Ford", "48xgu", "2017", "07600", "violet", "LosRosales", "166952141", DateTime.Today, "https://www.diariomotor.com/imagenes/2019/04/ford-explorer-2019-0319-010.jpg"));
            Vehiculos.Add(new Vehiculo("BSV 173", "Nissan", "fest4", "2018", "99213", "orange", "CasaRestrepo", "32623205", DateTime.Today, "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/l/RT_V_933bacfa64664b75b60089841a11a2e4.jpg"));
            Vehiculos.Add(new Vehiculo("CMJ 848", "Nissan", "Extpro", "2018", "36198", "yellow", "CasaRestrepo", "93500821",new DateTime(2019,3,15), "https://acs2.blob.core.windows.net/imgcatalogo/l/VA_a2aa7fafebc2485bb20237f6bf90bad4.jpg"));
            return Vehiculos;
        }

    }
}
