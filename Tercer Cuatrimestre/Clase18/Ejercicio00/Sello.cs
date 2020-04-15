using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static string Imprimir() { return Sello.ArmarFormatoMensaje(); }
        public static void Borrar() { Sello.mensaje = ""; }
        public static ConsoleColor color;
        public static void ImprimirEnColor()
        {   Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray; }
        private static string ArmarFormatoMensaje()
        {
            //recuadra el texto del mensaje con asteriscos (*)
            string a = "";
            string texto = "";
            string retorno = "";
            if (Sello.TryParse(Sello.mensaje,out texto))//si el texto contiene caracteres
            {
                for(int i = 0; i < mensaje.Length + 2; i++)//cuenta la cantidad de letras del mensaje + 2
                {
                    a += "*";//las guarda en la variable (a)
                }
                retorno = a + "\n*" + texto + "*\n" + a;//guarda en retorno la concatenacion de asteriscos
                //salto de linea mensaje salto de linea y asteriscos
            }
            return retorno;
        }
        private static bool TryParse(string msj, out string cadena)
        {
            bool retorno = false;
            cadena = "";
            if (msj.Length > 0)
            {
                retorno = true;
                cadena = msj;
            }
            return retorno;
        }
    }
}
