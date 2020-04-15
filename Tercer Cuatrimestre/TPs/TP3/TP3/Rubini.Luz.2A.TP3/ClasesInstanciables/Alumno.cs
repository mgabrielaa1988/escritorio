using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion
        #region Constructores
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalildad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalildad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalildad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalildad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion
        #region Sobrecargas
        protected override string MostrarDatos()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(base.MostrarDatos());
            ret.Append("ESTADO DE CUENTA: ");
            ret.AppendLine(this.estadoCuenta.ToString());
            ret.AppendLine(this.ParticiparEnClase());
            return ret.ToString();
        }
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase;
        }
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder ret = new StringBuilder();
            ret.Append("TOMA CLASES DE " + this.claseQueToma.ToString());
            return ret.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
        #region Enumerado
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }
        #endregion

    }
}
