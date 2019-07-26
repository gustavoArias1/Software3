using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    public class Cliente
    {
        public string correo { get; set; }
        public string contraseña { get; set; }

        public Cliente(string correo, string contraseña)
        {
            this.correo = correo;
            this.contraseña = contraseña;
        }
    }
}
