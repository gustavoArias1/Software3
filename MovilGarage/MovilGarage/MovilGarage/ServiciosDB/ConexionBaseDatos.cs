using System;
using System.Collections.Generic;
using System.Text;
using MovilGarage.Dominio;


namespace MovilGarage.ServiciosDB
{
    class ConexionBaseDatos
    {
        List<Concesionario> Concesionarios = new List<Concesionario>();
        List<Cliente> Clientes = new List<Cliente>();


        public List<Concesionario> tablaConcesionarios()
        {
            Concesionarios.Add(new Concesionario("CasaRestrepo", 5.042467, -75.4781977));
            Concesionarios.Add(new Concesionario("AudiLosCoches", 5.046661, -75.483607));
            Concesionarios.Add(new Concesionario("Rasautos", 5.047100, -75.483495));
            Concesionarios.Add(new Concesionario("MercedesBenz", 5.051364, -75.484303));
            Concesionarios.Add(new Concesionario("Renault", 5.054323, -75.481586));
            Concesionarios.Add(new Concesionario("CaldasMotor", 5.057124, -75.486572));
            Concesionarios.Add(new Concesionario("Volkswagen", 5.060861, -75.484653));

            return this.Concesionarios;
        }

        public List<Cliente> tablaClientes()
        {
            Clientes.Add(new Cliente("123@gmail.com", "UZF02FOO5RZ"));
            Clientes.Add(new Cliente("456@gmail.com", "FNN99WLK5RL"));
            Clientes.Add(new Cliente("789@gmail.com", "GQH19DHD1NK"));
            return this.Clientes;
        }

    }
}
