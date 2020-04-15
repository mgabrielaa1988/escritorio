using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion
        #region Constructores
        public Profesor()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
        }
        static Profesor()
        {
            Profesor.random = new Random();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion
        #region Metodos
        private void _randomClases()
        {
            Profesor.random.Next(0, 3);
            for (int i = 0; i < 2; i++)
            {
                switch (Profesor.random.Next(0, 3))
                {
                    case 0:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 1:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 2:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 3:
                        this.clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;
                }
            }
        }
        #endregion
        #region Sobrecargas
        protected override string MostrarDatos()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(base.MostrarDatos());
            ret.AppendLine(this.ParticiparEnClase());

            return ret.ToString();
        }
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool ret = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        protected override string ParticiparEnClase()
        {
            string clases = "\nCLASES DEL DIA: ";

            foreach (Universidad.EClases i in this.clasesDelDia)
            {
                clases += "\n";
                clases += i.ToString();
            }
            return clases;
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
