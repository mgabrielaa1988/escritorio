using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestCorreo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarListaInstanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void VerificaTrackingIdRepetidoException()
        {
            Correo correo = new Correo();
            Paquete paquete1 = new Paquete("Paquete1", "123456789");
            Paquete paquete2 = new Paquete("Paquete2", "123456789");
            correo += paquete1;
            Assert.IsTrue(correo.Paquetes.Contains(paquete1));
            correo += paquete2;
        }
    }
}
