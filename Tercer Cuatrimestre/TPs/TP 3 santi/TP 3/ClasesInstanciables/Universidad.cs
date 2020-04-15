using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    [Serializable]
    public class Universidad
    {
        #region Enumerados
        public enum EClases
        { Programacion,Laboratorio,Legislacion,SPD }
        #endregion

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public List<Jornada> Jornada { get => jornada; set => jornada = value; }
        public List<Profesor> Profesores { get => profesores; set => profesores = value; }
        public Jornada this[int i]
        {
            get { return this.Jornada.ElementAt(i); }
            set { this.Jornada.Insert(i, value); }
        }
        #endregion

        #region Constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Polimorfismo
        public override string ToString()
        {
          StringBuilder stringBuilder = new StringBuilder();

            foreach (Jornada item in this.Jornada)
            {
                 stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }

        
         public static bool Guardar(Universidad uni)
         {
            bool retorno = false;
            Xml<Universidad> xml = new Xml<Universidad>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"ArchivoXml.xml";

            try
            {
              retorno = xml.Guardar(path, uni);
            }
            catch (Exception e)
            {
              throw new ArchivosException(e);
            }
          
            return retorno;
         }


        #endregion

        #region Sobrecarga de Operadores
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada;
            Profesor jornadaProfesor = default(Profesor);
            //Alumno JornadaAlumno = default(Alumno);
            bool Bandera = false;

            foreach (Profesor item in g.Profesores)
            {
                if(item == clase)
                {
                    jornadaProfesor = item;
                    Bandera = true;
                    break;
                }
            }

            if(Bandera)
            {
                nuevaJornada = new Jornada(clase, jornadaProfesor);

                foreach (Alumno item in g.Alumnos)
                {
                    if(item == clase)
                    {
                        nuevaJornada += item;
                    }
                }

                g.Jornada.Add(nuevaJornada);
            }
            else
            {
                throw new SinProfesorException();
            }

            return g;
        }

        // Preguntar al Profe si desde aca tengo que tirar la Excepcion de "AlumnoRepetidoException"
        public static Universidad operator +(Universidad g, Alumno a)
        {
            bool bandera = false;

            if(g == a)
            {
                bandera = true;
            }
            if(bandera)
            {
                g.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            bool bandera = false;

            if(g == i)
            {
                bandera = true;
            }

            if(!bandera)
            {
                g.Profesores.Add(i);
            }

            return g;
        }

        // ↑↑↑↑↑↑↑↑↑↑↑ Operadores de Aritmeticos ↑↑↑↑↑↑↑↑↑↑↑

        /***************************************************/

        // ↓↓↓↓↓↓↓↓↓↓↓   Operadores Comparacion  ↓↓↓↓↓↓↓↓↓↓↓

        // Comparadores Universidad , EClases

        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor retorno = default(Profesor);
            bool bandera = true;

            foreach (Profesor item in g.Profesores)
            {
                if(item == clase)
                {
                    bandera = false;
                    retorno = item;
                    break;
                }
            }

            if(bandera)
            {
                // aca se lanza la excepcion "SinProfesorException"
                throw new SinProfesorException();
            }

            return retorno;
        }

        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor retorno = null;

            foreach (Profesor item in g.Profesores)
            {
                if(item != clase)
                {
                    retorno = item;
                    break;
                }
            }


            return retorno;
        }

        // Comparadores Universidad , Profesor

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            //bool bandera = false;

            foreach (Jornada item in g.Jornada)
            {
                if(i == item.Clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor i)
        { return !(g == i); }

        // Comparadores Universidad , Alumno

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            bool BanNoInscripto = false;
            bool BanAlumRepetido = false;

            if(g.Alumnos.Count > 0 || g.Jornada.Count > 0)
            {
                foreach (Jornada item in g.Jornada)
                {
                    if (item == a)
                    {
                        BanNoInscripto = false;
                        break;
                    }
                }
                foreach (Alumno item in g.Alumnos)
                {
                    if (item.Dni == a.Dni)
                    {
                        BanAlumRepetido = true;
                        break;
                    }
                }
            }
            else
            {
                BanNoInscripto = false;
                BanAlumRepetido = false;
            }


            if(BanNoInscripto != true && BanAlumRepetido == false)
            { retorno = true; }
            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        { return !(g == a); }

        #endregion

        #region Metodos
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Jornada item in uni.Jornada)
            {
                stringBuilder.AppendLine(item.ToString());
                stringBuilder.AppendLine("<-------------------------------------------------------------------->");
            }

            return stringBuilder.ToString();
        }
        #endregion
    }
}
