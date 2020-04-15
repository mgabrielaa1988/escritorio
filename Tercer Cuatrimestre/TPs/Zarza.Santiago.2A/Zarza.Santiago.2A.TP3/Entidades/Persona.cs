using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Enumerado
        public enum ENacionalidad
        {
            Argentino,Extranjero
        }
        #endregion

        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }

            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public int Dni
        {
            get { return this.dni; }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }
        public string StringToDNI
        {
            set
            {
                this.Dni = ValidarDni(this.Nacionalidad, value);
            }
        }
        #endregion

        #region Constructores

        public Persona():this("","",ENacionalidad.Argentino)
        { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            if(nacionalidad == ENacionalidad.Argentino)
            { this.Dni = 1; }
            else
            { this.Dni = 90000000; }
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        { this.Dni = dni; }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        { this.StringToDNI = dni; }


        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", this.Nombre, this.Apellido);
            stringBuilder.AppendFormat("\nNACIONALIDAD: {0}\n", this.Nacionalidad.ToString());


            return stringBuilder.ToString();
        }

        #endregion

        #region Metodos
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            bool bandera = false;

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato >= 1 && dato <= 89999999)
                    {
                        retorno = dato;
                        bandera = true;
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato >= 90000000 && dato <= 99999999)
                    {
                        retorno = dato;
                        bandera = true;
                    }
                    break;
                default:
                    break;
            }
            if(!bandera)
            {
                throw new NacionalidadInvalidaException();
            }
            return retorno;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;

            if(dato.Length <= 8 && dato.Length >= 1)
            {
                int aux;
                if (int.TryParse(dato,out aux)!= false)
                {
                    retorno = ValidarDni(nacionalidad, aux);
                }
                else
                {
                    // lanzo excepcion "DniInvalidoException"
                    throw new DniInvalidoException();
                }

            }
            else
            {
                // lanzo excepcion "DniInvalidoException"
                throw new DniInvalidoException();
            }

            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            string retorno = default(string);

            Regex val = new Regex(@"^[a-zA-Z]+$");

            if(val.IsMatch(dato))// controlo que el nombre solo sea letras
            {
                retorno = dato;
            }
            
            return retorno;
        }

        #endregion
    }
}
