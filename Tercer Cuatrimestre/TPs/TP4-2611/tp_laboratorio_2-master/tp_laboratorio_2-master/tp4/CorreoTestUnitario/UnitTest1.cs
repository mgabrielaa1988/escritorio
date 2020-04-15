using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using ClasesPrincipales;

namespace CorreoTestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        //Metodo que verifica que la lista de elementos de tipo Paquete esté inicializada al instanciar el elemento de tipo Correo
        [TestMethod]
        public void CorreoListaInstanciada()
        {
            Correo correoAux = new Correo();

            if (correoAux.Paquetes == null)
            { Assert.Fail(); }
        }

        /// <summary>
        /// Metodo que comprueba que no se puedan cargar dos elementos de tipo Paquete con el mismo TrackingID
        /// </summary>
        [TestMethod]
        public void PaqueteIDRepetido()
        {
            Correo correoAux = new Correo();
            Paquete paqueteAuxA = new Paquete("TestA", "TrackingA");
            Paquete paqueteAuxB = new Paquete("TestB", "TrackingA");

            correoAux += paqueteAuxA;

            try
            {
                correoAux += paqueteAuxB;
                Assert.Fail();
            }
            catch (TrackingIDRepetidoException trackingException) { }
        }
    }
}
