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
            concesionarios.Add(new Concesionario("CasaRestrepo", 5.042467, -75.4781977));
            concesionarios.Add(new Concesionario("AudiLosCoches", 5.046661, -75.483607));
            concesionarios.Add(new Concesionario("Rasautos", 5.047100, -75.483495));
            concesionarios.Add(new Concesionario("MercedesBenz", 5.051364, -75.484303));
            concesionarios.Add(new Concesionario("Renault", 5.054323, -75.481586));
            concesionarios.Add(new Concesionario("CaldasMotor", 5.057124, -75.486572));
            concesionarios.Add(new Concesionario("Volkswagen", 5.060861, -75.484653));
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
