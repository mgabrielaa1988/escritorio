using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion
        #region Constructores
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion
        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido(value); }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.nacionalidad, value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidarNombreApellido(value); }
        }
        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }
        #endregion
        #region Metodos
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato < 1 || dato > 89999999)
                {
                    throw new DniInvalidoException();
                }
            }
            else if (nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato < 90000000)
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI");
                }
            }

            return dato;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            foreach (char item in dato)
            {
                if (!(char.IsDigit(item)))
                {
                    throw new DniInvalidoException("Dni invalido");
                }
            }

            return this.ValidarDni(nacionalidad, int.Parse(dato));
        }
        private string ValidarNombreApellido(string dato)
        {
            int i = 0;
            bool nombreCorrecto = true;
            while (dato[i] != '\0')
            {
                if (!((dato[i] > 'a' && dato[i] < 'z') || (dato[i] > 'A' && dato[i] < 'Z')))
                {
                    nombreCorrecto = false;
                }
                i++;
            }
            if (nombreCorrecto == true)
            {
                this.nombre = dato;
            }

            return dato;
        }
        #endregion
        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine("NOMBRE COMPLETO: " + this.Apellido + " " + this.Nombre);
            ret.Append("NACIONALIDAD: " + this.Nacionalidad);
            return ret.ToString();
        }
        #endregion
        #region Enumerado
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #endregion
    }
}
