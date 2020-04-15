using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesInstanciables;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    [ExpectedException(typeof(NacionalidadInvalidaException))]
    public void TestMethod1()
    {
      Universidad gim = new Universidad();

      Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

      gim += a1;

      Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,Alumno.EEstadoCuenta.Deudor);

      try
      {
        gim += a2;
      }
      catch (NacionalidadInvalidaException e)
      {
         Assert.Fail();
      }
    }

    [TestMethod]
    [ExpectedException(typeof(AlumnoRepetidoException))]
    public void TestMethod2()
    {
      Universidad gim = new Universidad();

      Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

      gim += a1;

      try
      {
        Alumno a3 = new Alumno(3, "José", "Gutierrez", "12234456",
        EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
        Alumno.EEstadoCuenta.Becado);

        gim += a3;

      }
      catch (Exception e)
      {
        Assert.Fail();
      }
    }

  }
}
