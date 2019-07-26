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
    /// Clase que nos permite la validacion de los usuarios para el ingreso de la aplicación.
    /// </summary>
    public class IngresarAlSistema
    {
        private ConexionBaseDatos conexion;
        private List<Cliente> listaClientes;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public IngresarAlSistema()
        {
            conexion = new ConexionBaseDatos();
            listaClientes = conexion.TablaClientes();
        }

        /// <summary>
        /// Valida que un usario se encuentre registrado en la plataforma y pueda ingresar.
        /// </summary>
        /// <param name="usuario">Usuario ingresado con el correo del cliente</param>
        /// <param name="contraseña">Contraseña digitada por el cliente</param>
        /// <returns>Verdadero en caso de que el usuario y la contraseña sean validas, falso si no se encuentra registrado en la plataforma o ingreso mal alguno de sus campos</returns>
        public Boolean AuntenticarseSistema(string usuario, string contraseña)
        {
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                if(this.listaClientes[i].Correo.Equals(usuario))
                {
                    if(this.listaClientes[i].Contraseña.Equals(contraseña))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
