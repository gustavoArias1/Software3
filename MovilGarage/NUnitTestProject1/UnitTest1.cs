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
            string Contrase�a = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, I.auntenticarseSistema( Usuario,Contrase�a));

            
            
        }

        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema I = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contrase�a = "prueba";
            bool entro = false;

            Assert.AreEqual(entro, I.auntenticarseSistema(Usuario, Contrase�a));


        }
    }
}