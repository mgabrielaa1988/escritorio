using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using Excepciones;
using ClasesInstanciables;

namespace Tests_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TestValidaAlumnoRepetido, valida que el alumno ingresado este previamente cargado 
        /// </summary>
        [TestMethod]
        public void TestValidaAlumnoRepetido()
        {
            Universidad universidad = new Universidad();

            Alumno a1 = new Alumno(0, "", "", "1111111", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(1, "", "", "1111111", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);


            universidad += a1;

            try
            {
                universidad += a2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }

        /// <summary>
        /// TestValidaNacionalidadInvalida, valida que el Dni de Alumno/Profesor cargado coincida con su nacionalidad  
        /// </summary>
        [TestMethod]
        public void TestValidaNacionalidadInvalida()
        {
            try
            {
                Alumno a1 = new Alumno(0, "", "", "1111111", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// TestValidaValorNumerico, valida que el Dni ingresado sea numerico  
        /// </summary>
        [TestMethod]
        public void TestValidaValorNumerico()
        {
            try
            {
                Alumno a1 = new Alumno(0, "", "", "111sa111", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        /// <summary>
        /// TestValidaNulidad, valida que Algun atributo de alguna clase no sea nulo, de serlo provoca una excepcion
        /// </summary>
        [TestMethod]
        public void TestValidaNulidad()
        {
            Profesor profesor = new Profesor(1, "prueba", "prueba", "1111111", Persona.ENacionalidad.Argentino);

            Assert.IsNotNull(profesor);
        }
    }
}
