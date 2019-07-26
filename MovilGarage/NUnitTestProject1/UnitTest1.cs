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



        [TestCase]
        public void IngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, I.AuntenticarseSistema(Usuario, Contraseņa));



        }

        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "prueba";
            bool entro = false;
            Assert.AreEqual(entro, I.AuntenticarseSistema(Usuario, Contraseņa));


        }

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
