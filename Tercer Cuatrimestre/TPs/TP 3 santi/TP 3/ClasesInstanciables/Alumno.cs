using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Enumerado
        public enum EEstadoCuenta
        { AlDia,Deudor,Becado }
        #endregion

        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores

        public Alumno():this(1,"","","1",ENacionalidad.Argentino,default(Universidad.EClases),default(EEstadoCuenta))
        {
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            return ("TOMA CLASES DE " + this.claseQueToma.ToString());
        }

        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(base.MostrarDatos());

            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    stringBuilder.Append("ESTADO DE CUENTA: Cuota al díá\n");
                    break;
                case EEstadoCuenta.Deudor:
                    stringBuilder.Append("ESTADO DE CUENTA: Adeuda al díá\n");
                    break;
                case EEstadoCuenta.Becado:
                    stringBuilder.Append("ESTADO DE CUENTA: Tiene Beca\n");
                    break;
                default:
                    break;
            }

            stringBuilder.Append(this.ParticiparEnClase());

            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }

        #endregion

    }
}
