using NUnit.Framework;
using MovilGarage.Dominio;
using MovilGarage.Logica;
using MovilGarage.ServiciosDB;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {


        /// <summary>
        /// prueba de ingreso al sistema con correo y contraseņa validos
        /// </summary>
        [TestCase]
        public void IngresoSistemaTest()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseņa));



        }

        /// <summary>
        /// prueba de ingreso al sistema con correo valido pero conntraseņa no valida
        /// </summary>
        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "prueba";
            bool entro = false;
            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseņa));


        }

        /// <summary>
        /// prueba de ingreso al sistema con contraseņa valida pero correo invalido
        /// </summary>
        [TestCase]
        public void NoIngresoSistemaTest2()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.org";
            string Contraseņa = "UZF02FOO5RZ";
            bool entro = false;
            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseņa));


        }


        /// <summary>
        /// prueba de obtencion de concesionarios de la base de  datos para su posterior ubicacion
        /// </summary>
        [TestCase]
        public void UbicarConncesionarioTest()
        {
            UbicarConcesionarios ubicarConcesionario = new UbicarConcesionarios();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            List<Concesionario> listaConcesionarios = conexionBaseDatos.TablaConcesionarios();
            Assert.AreEqual(listaConcesionarios.Count, ubicarConcesionario.GetConcesionarios().Count);

                 
        }
    }
}
