using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilGarage.Vistas
{

    public class UbicarConcesionarioMenuItem
    {
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