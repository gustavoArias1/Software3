using MovilGarage.Dominio;
using MovilGarage.ServiciosDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Logica
{
    public class UbicarConcesionarios
    {
        private ConexionBaseDatos conexion;
        private List<Concesionario> listaConcesionarios;

        public UbicarConcesionarios()
        {
            conexion = new ConexionBaseDatos();
            listaConcesionarios = conexion.tablaConcesionarios();
        }

        public List<Concesionario> GetConcesionarios()
        {
            return listaConcesionarios;
        }
    }
}
