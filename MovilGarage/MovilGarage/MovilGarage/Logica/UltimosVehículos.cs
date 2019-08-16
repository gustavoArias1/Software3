using System;
using System.Collections.Generic;
using System.Text;
using MovilGarage.Dominio;
using MovilGarage.ServiciosDB;

namespace MovilGarage.Logica
{
    /// <summary>
    /// @author William Vásquez
    /// @version Version 1.0
    /// Permite obtener los vehículos agregados en el último mes, mes actual
    /// </summary>
    public class UltimosVehículos
    {
        private ConexionBaseDatos conexion;
        private List<Vehiculo> listaVehículos;

        /// <summary>
        /// Contructor de la clase
        /// </summary>
        public UltimosVehículos()
        {
            this.conexion = new ConexionBaseDatos();
            this.listaVehículos = conexion.TablaVehiculos();
        }

        /// <summary>
        /// Permite obtener los vehículos agregados en el último mes, mes actual
        /// </summary>
        public List<Vehiculo> ConsultarUltimosVehiculos() {
            List<Vehiculo> auxListaVehiculos = new List<Vehiculo>();
            foreach (Vehiculo v in listaVehículos) {
                if (v.FechaAdquisicion.Month == DateTime.Today.Month && v.FechaAdquisicion.Year == DateTime.Today.Year) {
                    auxListaVehiculos.Add(v);
                }
            }
            return auxListaVehiculos;
        }
    }
}
