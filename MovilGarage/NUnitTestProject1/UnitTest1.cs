using NUnit.Framework;
using MovilGarage.Dominio;
using MovilGarage.Logica;
namespace Tests
{
    public class Tests
    {
        
        
        [TestCase]
        public void IngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, I.auntenticarseSistema( Usuario,Contraseņa));

            
            
        }

        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseņa = "prueba";
            bool entro = false;

            Assert.AreEqual(entro, I.auntenticarseSistema(Usuario, Contraseņa));


        }
    }
}