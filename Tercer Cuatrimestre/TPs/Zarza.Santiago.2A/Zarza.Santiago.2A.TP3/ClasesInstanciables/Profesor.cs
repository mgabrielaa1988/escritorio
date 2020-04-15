using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> ClasesDelDia;
        private static Random random;
        #endregion

        #region Constructores

        private Profesor()
        {
          this.ClasesDelDia = new Queue<Universidad.EClases>();
          this._randomClases();
        }

        static Profesor()
        {
            random = new Random();
        }

    public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
    {
      Profesor profesoraux = new Profesor();
      this.ClasesDelDia = profesoraux.ClasesDelDia;
    }

    #endregion

        #region Polimorfismo
    public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder StringBuilder = new StringBuilder("CLASES DEL DÍA\n");

            foreach (Universidad.EClases item in this.ClasesDelDia)
            {
                StringBuilder.AppendLine(item.ToString());
            }

            return StringBuilder.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat("CLASE DE {0} POR {1}",this.ClasesDelDia.Peek().ToString(),base.MostrarDatos());
            stringBuilder.Append(this.ParticiparEnClase());
            return stringBuilder.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach (Universidad.EClases item in i.ClasesDelDia)
            {
                if(item == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase) { return true; }

        #endregion

        #region Metodos

        private void _randomClases()
        {

            while(this.ClasesDelDia.Count < 2)
            {
                int numAux = random.Next(0, 3);// Se asignan los valores que recorrera del Enumerado

                this.ClasesDelDia.Enqueue(((Universidad.EClases)numAux));
            }
               
        }


        #endregion


    }
}
