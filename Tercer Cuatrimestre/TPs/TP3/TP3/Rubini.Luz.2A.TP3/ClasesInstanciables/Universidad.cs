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
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        #endregion
        #region Constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion
        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }
        public Jornada this[int i]
        {
            get { return this.jornadas[i]; }
            set { this.jornadas[i] = value; }
        }
        #endregion
        #region Métodos
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> archivoXML = new Xml<Universidad>();

            return archivoXML.Guardar("Universidad.xml", uni);
        }
        public static Universidad Leer()
        {
            Universidad univ = new Universidad();
            Xml<Universidad> archivoXML = new Xml<Universidad>();
            archivoXML.Leer("Universidad.xml", out univ);
            return univ;
        }
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine("JORNADA:");
            foreach (Jornada item in uni.Jornadas)
            {
                ret.AppendLine(item.ToString());
                ret.AppendLine("<-------------------------------->");
            }
            return ret.ToString();
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool ret = false;
            foreach (Alumno item in g.Alumnos)
            {
                if (item == a)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item == clase)
                {
                    return item;
                }
            }

            throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor ret = new Profesor();
            foreach (Profesor item in u.Profesores)
            {
                if (item != clase)
                {
                    ret = item;
                }
            }
            return ret;
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool ret = false;
            foreach (Profesor item in g.Profesores)
            {
                if (item == i)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            Universidad univ = new Universidad();
            univ = u;
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            return univ;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Universidad univ = new Universidad();
            Jornada j = new Jornada(clase, g == clase);
            univ = g;
            foreach (Alumno item in univ.Alumnos)
            {
                if (item == clase)
                {
                    j += item;
                }
            }
            univ.Jornadas.Add(j);
            return univ;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            Universidad univ = new Universidad();
            univ = u;
            if (u != i)
            {
                u.Profesores.Add(i);
            }
            return univ;
        }
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion
        #region Enumerado
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
        #endregion
    }
}
