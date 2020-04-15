using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCalculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza una de las cuatro operaciones basicas segun el operador ingresado
        /// </summary>
        /// <param name="numero1"> primer operando clase Numero </param>
        /// <param name="numero2"> segundo operando clase Numero </param>
        /// <param name="operador"> string que determina el operador de la operacion </param>
        /// <returns> double resultado de la operacion entre ambos operandos clase Numero </returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;
            operador = ValidarOperador(operador);

            if (operador == "+")
            {
                retorno = numero1 + numero2;
            }
            else if (operador == "-")
            {
                retorno = numero1 - numero2;
            }
            else if (operador == "*")
            {
                retorno = numero1 * numero2;
            }
            else if (operador == "/")
            {
                retorno = numero1 / numero2;
            }

            return retorno;
        }

        /// <summary>
        /// Valida un operador ingresado, en caso de cualquier otro operador fuera de los basicos, retorna +
        /// </summary>
        /// <param name="operador"> string que determina el operador de la operacion </param>
        /// <returns> string de retorno que devuelve el mismo operador en caso de ser valido </returns>
        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }
            return operador;
        }
    }

    public class Numero
    {
        private double _numeroAtributo;

        /// <summary>
        /// Propiedad para asignar valor a _numeroAtributo previa validación
        /// </summary>
        public string NumeroAtributo
        {
            set
            {
                this._numeroAtributo = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor parametrizado que iniciar el objeto con el valor especificado
        /// </summary>
        /// <param name="numero1"> double que sera utilizado como atributo </param>
        public Numero(double numero1)
        {
            this._numeroAtributo = numero1;
        }

        /// <summary>
        /// Constructor por defecto, inicia el objeto con el atributo _numeroAtributo en 0
        /// </summary>
        public Numero() : this(0)
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicia el objeto con un numero especificado ingresado como string, el cual será validado
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.NumeroAtributo = strNumero;
        }

        /// <summary>
        /// Metodo de validacion de cadenas para el objeto Numero
        /// </summary>
        /// <param name="strNumero"> string que se intentará convertir a double antes de asignarlo al atributo </param>
        /// <returns> retorna el double basado en el string ingresado por parametro, en caso de no ser valido, regresa 0 </returns>
        private static double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        /// <summary>
        /// Conversor de un numero binario (ingresado como string) a decimal (retornado como string)
        /// </summary>
        /// <param name="binario"> string de numero binario que se intentará convertir </param>
        /// <returns> retorna un string con el numero decimal convertido, en caso de ser invalido, retorna una cadena especifica </returns>
        public static string BinarioDecimal(string binario)
        {
            double auxDouble = 0;
            string retorno = "Valor invalido";

            for (int i = binario.Length; i > 0; i--)
            {
                if (binario[i - 1] == 49)
                {
                    auxDouble += Math.Pow(2, binario.Length - i);
                }
            }

            if (auxDouble >= 0)
            {
                retorno = "" + auxDouble;
            }

            return retorno;
        }

        /// <summary>
        /// Conversor de un numero decimal (ingresado como string) a binario (retornado como string)
        /// </summary>
        /// <param name="aConvertir"> string con el numero decimal que se intentará convertir </param>
        /// <returns> retorna un string con el numero binario convertido, en caso de ser invalido, retorna una cadena especifica </returns>
        public static string DecimalBinario(string aConvertir)
        {
            double auxReturn = Numero.ValidarNumero(aConvertir);

            return Numero.DecimalBinario(auxReturn);
        }

        /// <summary>
        /// Conversor de un numero decimal (ingresado como double) a binario (retornado como string)
        /// </summary>
        /// <param name="aConvertir"> double con el numero decimal que se intentará convertir </param>
        /// <returns> retorna un string con el numero binario convertido, en caso de ser invalido, retorna una cadena especifica </returns>
        public static string DecimalBinario(double aConvertir)
        {
            string auxString = "Valor invalido";

            if (aConvertir > 0 && (aConvertir - (int)aConvertir) == 0)
            {
                auxString = "";

                while (aConvertir >= 1)
                {
                    if (aConvertir % 2 == 0)
                    {
                        auxString = "0" + auxString;
                    }
                    else
                    {
                        auxString = "1" + auxString;
                    }

                    aConvertir = (int)aConvertir / 2;
                }
            }
            else if (aConvertir == 0)
            {
                auxString = "0";
            }
            return auxString;
        }

        /// <summary>
        /// Suma los atributos de dos objetos Numero
        /// </summary>
        /// <param name="numero1"> primer operando de clase Numero </param>
        /// <param name="numero2"> segundo operando de clase Numero </param>
        /// <returns> double resultado de la operacion </returns>
        public static double operator +(Numero numero1, Numero numero2)
        {
            double retorno = numero1._numeroAtributo + numero2._numeroAtributo;

            return retorno;
        }

        /// <summary>
        /// Resta los atributos de dos objetos Numero
        /// </summary>
        /// <param name="numero1"> primer operando de clase Numero </param>
        /// <param name="numero2"> segundo operando de clase Numero </param>
        /// <returns> double resultado de la operacion </returns>
        public static double operator -(Numero numero1, Numero numero2)
        {
            double retorno = numero1._numeroAtributo - numero2._numeroAtributo;

            return retorno;
        }

        /// <summary>
        /// Multiplica los atributos de dos objetos Numero
        /// </summary>
        /// <param name="numero1"> primer operando de clase Numero </param>
        /// <param name="numero2"> segundo operando de clase Numero </param>
        /// <returns> double resultado de la operacion </returns>
        public static double operator *(Numero numero1, Numero numero2)
        {
            double retorno = numero1._numeroAtributo * numero2._numeroAtributo;

            return retorno;
        }

        /// <summary>
        /// Divide los atributos de dos objetos Numero
        /// </summary>
        /// <param name="numero1"> primer operando de clase Numero </param>
        /// <param name="numero2"> segundo operando de clase Numero </param>
        /// <returns> double resultado de la operacion </returns>
        public static double operator /(Numero numero1, Numero numero2)
        {
            double retorno = 0;
            
            if (numero1._numeroAtributo != 0)
            {
                retorno = numero1._numeroAtributo / numero2._numeroAtributo;
            }
            return retorno;
        }
    }
}
