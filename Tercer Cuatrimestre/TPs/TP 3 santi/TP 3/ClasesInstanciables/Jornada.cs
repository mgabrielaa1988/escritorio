using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public Universidad.EClases Clase { get => clase; set => clase = value; }
        public Profesor Instructor { get => instructor; set => instructor = value; }
        #endregion

        #region Constructores

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("JORNADA:\n");

            stringBuilder.AppendLine(this.Instructor.ToString());
            stringBuilder.AppendLine("ALUMNOS:");
            foreach (Alumno item in this.Alumnos)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            stringBuilder.AppendLine("<----------------------------------------------------------->");

            return stringBuilder.ToString();
        }

        public static bool Guardar(Jornada datos)
        {
            bool retorno = false;
            Texto texto = new Texto();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"ArchivoTexto.txt";

            try
            {
              retorno = texto.Guardar(path, datos.ToString());
            }
            catch(Exception e)
            {
              throw new ArchivosException(e);
            }
            
            return retorno;
        }

        public bool Leer(string archivo, out Jornada datos)
        {
            bool retorno = false;
            Texto texto = new Texto();
            string auxDatosRecibidos="";
            datos = new Jornada();

            if(texto.Leer(archivo,out auxDatosRecibidos))
            {
                
            }

            return retorno;
        }

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool Retorno = false;

                if(a == j.Clase)
                {
                    Retorno = true;
                }

            return Retorno;
        }

        public static bool operator !=(Jornada j, Alumno a) { return !(j == a); }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            bool bandera = false;
            foreach (Alumno item in j.Alumnos)
            {
                if(item == a)
                {
                    bandera = true;
                    break;
                }
            }

            if(!bandera)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        #endregion
    }
}
