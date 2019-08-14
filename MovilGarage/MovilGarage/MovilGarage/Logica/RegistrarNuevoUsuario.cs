using MovilGarage.Dominio;
using MovilGarage.ServiciosDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MovilGarage.Logica
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Version 1.0
    /// Permite la creación de un nuevo usuario en la plataforma.
    /// </summary>
    public class RegistrarNuevoUsuario
    {
        private ConexionBaseDatos conexion;
        private List<Cliente> listaClientes;
        private IngresarAlSistema login;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public RegistrarNuevoUsuario()
        {
            conexion = new ConexionBaseDatos();
            listaClientes = conexion.TablaClientes();
        }

        /// <summary>
        /// Valida que el usuario ingresado corresponda a los estandares solicitados
        /// </summary>
        /// <param name="usuario">Correo electronico del usuario</param>
        /// <returns>Verdadero en caso de cumplir con los estandares de un correo, falso en caso contrario</returns>
        public Boolean ValidaciónDeUsuario(string usuario)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(usuario, expresion))
            {
                if (Regex.Replace(usuario, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public Boolean RegistraUsuario(string usuario, string contraseña, string segundaContraseña)
        {
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                if (this.listaClientes[i].Correo.Equals(usuario))
                {
                    return false;
                }
            }
            if (contraseña.Equals(segundaContraseña))
            {
                conexion.Clientes.Add(new Cliente(usuario, contraseña));
                return true;
            }
            return false;
        }
    }
}