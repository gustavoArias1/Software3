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
            string Contrase�a = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, I.AuntenticarseSistema(Usuario, Contrase�a));



        }

        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contrase�a = "prueba";
            bool entro = false;
            Assert.AreEqual(entro, I.AuntenticarseSistema(Usuario, Contrase�a));


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
