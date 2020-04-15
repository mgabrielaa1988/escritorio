using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion
        #region Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion
        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion
        #region Metodos
        public static bool Guardar(Jornada jornada)
        {
            Texto archivoTexto = new Texto();

            return archivoTexto.Guardar("Jornada.txt", jornada.ToString());
        }
        public static string Leer()
        {
            string ret = "";
            Texto archivoTexto = new Texto();
            archivoTexto.Leer("Jornada.txt", out ret);

            return ret;
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool ret = false;
            foreach (Alumno i in j.alumnos)
            {
                if (i == a)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            try
            {
                if (j != a)
                {
                    Jornada jornada = new Jornada();
                    jornada.alumnos = j.alumnos;
                    jornada.clase = j.clase;
                    jornada.instructor = j.instructor;

                    jornada.alumnos.Add(a);
                    return jornada;
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            catch (AlumnoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }

            return j;
        }
        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.Append("CLASE DE ");
            ret.AppendLine(this.Clase.ToString());
            ret.Append(this.Instructor.ToString());
            foreach (Alumno a in this.Alumnos)
            {
                ret.AppendLine(a.ToString());
            }
            return ret.ToString();
        }
        #endregion
    }
}
