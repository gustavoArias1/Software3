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
        /// prueba de ingreso al sistema con correo y contraseña validos
        /// </summary>
        [TestCase]
        public void IngresoSistemaTest()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseña = "UZF02FOO5RZ";
            bool entro = true;

            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseña));



        }

        /// <summary>
        /// prueba de ingreso al sistema con correo valido pero conntraseña no valida
        /// </summary>
        [TestCase]
        public void NoIngresoSistemaTest()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.com";
            string Contraseña = "prueba";
            bool entro = false;
            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseña));


        }

        /// <summary>
        /// prueba de ingreso al sistema con contraseña valida pero correo invalido
        /// </summary>
        [TestCase]
        public void NoIngresoSistemaTest2()
        {
            IngresarAlSistema ingresarSistema = new IngresarAlSistema();
            string Usuario = "123@gmail.org";
            string Contraseña = "UZF02FOO5RZ";
            bool entro = false;
            Assert.AreEqual(entro, ingresarSistema.AuntenticarseSistema(Usuario, Contraseña));


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

        /// <summary>
        /// prueba de registro de un usuario con todos sus datos validos y que no se encuentra 
        /// registrado en la base de datos
        /// </summary>

        [TestCase]

        public void registrarUsuarioValido()
        {
            RegistrarNuevoUsuario registrarNuevoUsuario = new RegistrarNuevoUsuario();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            bool Registro = true;
            Assert.AreEqual(Registro, registrarNuevoUsuario.RegistraUsuario("josemiguel@gmail.com", "12345678", "12345678"));
        }

        /// <summary>
        /// prueba de registro de un usuario que ya sae encuentra en la base  de datos
        /// </summary>

        [TestCase]

        public void registrarUsuarioRegistrado()
        {
            RegistrarNuevoUsuario registrarNuevoUsuario = new RegistrarNuevoUsuario();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            bool Registro = false;
            Assert.AreEqual(Registro, registrarNuevoUsuario.RegistraUsuario("123@gmail.com", "12345678", "12345678"));
        }

        /// <summary>
        /// prueba de registro con usuario nuevo pero segunda contraseña invalida
        /// </summary>
        [TestCase]

        public void registrarUsuarioSegundaInvalida()
        {
            RegistrarNuevoUsuario registrarNuevoUsuario = new RegistrarNuevoUsuario();
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            bool Registro = false;
            Assert.AreEqual(Registro, registrarNuevoUsuario.RegistraUsuario("juan.12@gmail.com", "12345678", "prueba"));
        }
    }
}
