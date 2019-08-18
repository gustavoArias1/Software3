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
    public class UltimosVehiculosAgregadosViewMenuItem
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public UltimosVehiculosAgregadosViewMenuItem()
        {
            TargetType = typeof(UltimosVehiculosAgregadosViewDetail);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string NumeroChasis { get; set; }
        public string Color { get; set; }
        public string Concesionario { get; set; }
        public string Precio { get; set; }
        public string Url { get; set; }

        public Type TargetType { get; set; }
    }
}