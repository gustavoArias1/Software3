using System;
using System.Collections.Generic;
using System.Text;

namespace MovilGarage.Dominio
{
    class Cliente
    {
        private  string Correo { get; set; }
        private string Contraseña { get; set; }

        public Cliente(string correo, string contraseña)
        {
            this.Correo = correo;
            this.Contraseña = contraseña;
        }
    }
}
