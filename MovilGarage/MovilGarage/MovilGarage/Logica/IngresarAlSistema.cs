using MovilGarage.Dominio;
using MovilGarage.ServiciosDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Logica
{
    public class IngresarAlSistema
    {
        private ConexionBaseDatos conexion = new ConexionBaseDatos();
        private List<Cliente> listaClientes;

        public IngresarAlSistema()
        {
            listaClientes = conexion.tablaClientes();
        }

        public Boolean auntenticarseSistema(string usuario, string contraseña)
        {
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                if(this.listaClientes[i].correo.Equals(usuario))
                {
                    if(this.listaClientes[i].contraseña.Equals(contraseña))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
