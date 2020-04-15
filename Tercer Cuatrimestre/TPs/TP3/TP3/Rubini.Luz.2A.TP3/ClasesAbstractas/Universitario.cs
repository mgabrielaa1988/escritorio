using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;
        #region Constructores
        public Universitario()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion
        #region Metodos
        protected virtual string MostrarDatos()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(base.ToString());
            ret.AppendLine("LEGAJO NUMERO: " + this.legajo);
            return ret.ToString();
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        public override bool Equals(object obj)
        {
            return obj is Universitario && this == (Universitario)obj;
        }
        #endregion
        protected abstract string ParticiparEnClase();
    }
}
