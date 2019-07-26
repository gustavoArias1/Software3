using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    ///<summary>
    ///@author Gustavo Arias
    ///@version Version 1.0
    /// </summary>
    public class Cliente
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="correo">Correo del cliente registrado hace a su vez el papel de usuario</param>
        /// <param name="contraseña">Contraseña del cliente registrado</param>
        public Cliente(string correo, string contraseña)
        {
            this.Correo = correo;
            this.Contraseña = contraseña;
        }
    }
}
