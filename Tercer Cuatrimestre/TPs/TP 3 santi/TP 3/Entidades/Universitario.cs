using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributo
        private int legajo;
        #endregion

        #region Constructores
        public Universitario():this(1,"","","1",ENacionalidad.Argentino)
        {
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Polimorfismo

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Universitario)
            { retorno = true; }

            return retorno;
        }

        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;

            if(((object)pg1) != null && ((object)pg2) != null)
            {
                if(pg1.Equals((object)pg1) && pg2.Equals((object)pg2))
                {
                    if(pg1.legajo == pg2.legajo)
                    {
                        retorno = true;
                    }
                }
            }
                
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2) { return !(pg1 == pg2); }

        #endregion

        #region Metodos

        protected virtual string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendFormat("\nLEGAJO NÚMERO: {0}\n", this.legajo);

            return stringBuilder.ToString();
        }

        protected abstract string ParticiparEnClase();  
        #endregion

    }
}
