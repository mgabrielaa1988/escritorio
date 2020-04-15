using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double _numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// La propiedad SetNumero asignará un valor al atributo numero, previa validación.
        /// </summary>
        private string SetNumero { set { this._numero = ValidarNumero(value); }  }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, inicializa el atributo del objeto en 0
        /// </summary>
        public Numero() : this(0) { }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="numero">double con el valor que inicializa el objeto</param>
        public Numero(double numero) { this._numero = numero; }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="strNumero">string que luego de ser validado y convertido inicializa el objeto</param>
        public Numero(string strNumero) { this.SetNumero = strNumero; }
        #endregion

        #region Metodos
        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico 
        /// </summary>
        /// <param name="strNumero">string a ser comprobado</param>
        /// <returns>retorno: numero en formato double con el valor convertido o 0 en caso de no poder hacerlo</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if (double.TryParse(strNumero, out double numero))
            {
                retorno = numero;
            }
            return retorno;
        }

        /// <summary>
        /// El método BinarioDecimal convertirá un número binario a decimal, en caso de ser posible
        /// </summary>
        /// <param name="binario">string a ser comprobado</param>
        /// <returns>retorno: string del numero binario convertido a double o Valor Invalido en caso de error</returns>
        public static string BinarioDecimal(string binario) {
            string retorno="Valor Invalido";
            byte numero;
            double valor;
            if(double.TryParse(binario,out double ok))
            {
                numero = Convert.ToByte(binario,2);
                valor = Convert.ToDouble(numero);
                retorno = Convert.ToString(valor);
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">double a ser convertido</param>
        /// <returns>retorno: string del valor double en binario o Valor Invalido en caso de no poder convertir</returns>
        public static string DecimalBinario(double numero) {
            string retorno="Valor Invalido";
            while (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" + retorno;
                }
                numero = (int)numero / 2;
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">string a ser convertido</param>
        /// <returns>retorno: string con el equivalente binario del numero convertido a double</returns>
        public static string DecimalBinario(string numero) {
            string retorno="";
            if(double.TryParse(numero,out double auxiliar))
            {
                retorno = DecimalBinario(auxiliar);
            }
            return retorno;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Suma de los atributos de dos objetos Numero
        /// </summary>
        /// <param name="n1">primer operando de la clase Numero</param>
        /// <param name="n2">segundo operando de la clase Numero</param>
        /// <returns>retorno: double con el resultado</returns>
        public static double operator +(Numero n1,Numero n2) {
            double retorno = n1._numero + n2._numero;
            return retorno;
        }

        /// <summary>
        /// Resta de los atributos de dos objetos Numero
        /// </summary>
        /// <param name="n1">primer operando de la clase Numero</param>
        /// <param name="n2">segundo operando de la clase Numero</param>
        /// <returns>retorno: double con el resultado</returns>
        public static double operator -(Numero n1, Numero n2) {
            double retorno = n1._numero - n2._numero;
            return retorno;
        }

        /// <summary>
        /// Multiplicacion de los atributos de dos objetos Numero
        /// </summary>
        /// <param name="n1">multiplicando de la clase Numero</param>
        /// <param name="n2">multiplicador de la clase Numero</param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2) {
            double retorno = n1._numero * n2._numero;
            return retorno;
        }

        /// <summary>
        /// Division de los atributos de dos objetos Numero
        /// </summary>
        /// <param name="n1">divisor de la clase Numero</param>
        /// <param name="n2">dividendo de la clase Numero</param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2) {
            double retorno=0;
            if (n1._numero != 0)
            {
                retorno = n1._numero / n2._numero;
            }
            return retorno;
        }
        #endregion
    }
}
