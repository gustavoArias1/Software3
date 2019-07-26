using NUnit.Framework;
using MovilGarage.Dominio;
using MovilGarage.Logica;
using MovilGarage.ServiciosDB;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// clase de pruebas unitarias para los metodos mas importantes de toda la logica del negocio
    /// @ author Gustavo Andres Arias Loaiza
    /// @ version 1.0
    /// </summary>
    [TestFixture]
    public class Tests
    {



        /// <summary>
        ///  prueba de ingreso al sistema con datos correctos
        /// </summary>
        [TestCase]
        public void IngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contrase�a = "UZF02FOO5RZ";
            bool entro = true;
            Assert.AreEqual(entro, I.auntenticarseSistema(Usuario, Contrase�a));
        }

        /// <summary>
        ///  prueba de ingreso al sistema con contrase�a incorrecta
        /// </summary>

        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contrase�a = "prueba";
            bool entro = false;
            Assert.AreEqual(entro, I.auntenticarseSistema(Usuario, Contrase�a));


        }


        /// <summary>
        /// prueba de  ingreso al sistema con corre incorecto 
        /// </summary>
        [TestCase]
        public void NoIngresoSistemaTest2()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.org";
            string Contrase�a = "UZF02FOO5RZ";
            bool entro = false;
            Assert.AreEqual(entro, I.auntenticarseSistema(Usuario, Contrase�a));


        }

        /// <summary>
        /// prueba de obtencion de concesionarios por medio de la base datos 
        /// </summary>
        [TestCase]
        public void UbicarConncesionarioTest()
        {
            UbicarConcesionarios U = new UbicarConcesionarios();
            ConexionBaseDatos CB = new ConexionBaseDatos();
            List<Concesionario> listaConcesionarios = CB.tablaConcesionarios();
            Assert.AreEqual(listaConcesionarios.Count, U.GetConcesionarios().Count);

                 
        }
    }
}
