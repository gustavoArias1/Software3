using System;
using System.Collections.Generic;
using System.Text;
using MovilGarage.Dominio;


namespace MovilGarage.ServiciosDB
{
    class ConexionBaseDatos
    {
        private List<Concesionario> concesionarios { set; get; }
        private List<Cliente> Clientes { set; get; }

        public List<Concesionario> tablaConcesionarios()
        {
            concesionarios = new List<Concesionario>();
            concesionarios.Add(new Concesionario("CasaRestrepo", "calle 84 # 26 71","8843080", 5.042467, -75.4781977));
            concesionarios.Add(new Concesionario("AudiLosCoches", "carrera 23a # 74 128","8870111", 5.046661, -75.483607));
            concesionarios.Add(new Concesionario("Rasautos", "carrera 23a # 74 01","8872411", 5.047100, -75.483495));
            concesionarios.Add(new Concesionario("MercedesBenz", "carrera 23a # 23 02","8752043", 5.051364, -75.484303));
            concesionarios.Add(new Concesionario("Renault", "calle 67a # 18 03","8821110", 5.054323, -75.481586));
            concesionarios.Add(new Concesionario("CaldasMotor", "carrera 23 # 34 07","8821986", 5.057124, -75.486572));
            concesionarios.Add(new Concesionario("Volkswagen", "carrera 14 # 55 14","8820016", 5.060861, -75.484653));
            return this.concesionarios;
        }

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
