using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilGarage.Vistas
{
    /// <summary>
    /// @author Manuel Galvis
    /// @version Version 3.0
    /// Clase que almacena atributos tomados de la interfaz para ser enviados al modelo lógico y ser utilizados para sus métodos.
    /// </summary>
    public class UbicarConcesionarioMenuItem
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public UbicarConcesionarioMenuItem()
        {
            TargetType = typeof(UbicarConcesionarioDetail);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Type TargetType { get; set; }
    }
}