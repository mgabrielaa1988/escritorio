using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using ClasesAbstractas;
using Excepciones;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAlumnoRepetidoException()
        {
            Universidad univ = new Universidad();
            Alumno al = new Alumno(10, "Lucas", "Contreras", "35687334", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Alumno al2 = new Alumno(10, "Lucas", "Contreras", "35687334", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            try
            {
                univ.Alumnos.Add(al);
                univ.Alumnos.Add(al2);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }

        [TestMethod]
        public void TestMethodDniInvalidoException()
        {
            try
            {
                Alumno al = new Alumno(10, "Lucas", "Contreras", "90000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
                Assert.Fail("DNI no valido para la nacionalidad ingresada.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void TestMethodNacionalidadInvalidaException()
        {
            try
            {
                Alumno al = new Alumno(10, "Lucas", "Contreras", "900000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
                Assert.Fail("DNI no valido para la nacionalidad ingresada.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        [TestMethod]
        public void TestMethodUniversidadNula()
        {
            Universidad univ = new Universidad();
            Assert.IsNotNull(univ, "Universidad nula");
        }


    }
}
