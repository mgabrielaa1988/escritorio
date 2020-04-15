using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClasesPrincipales
{
    public static class GuardaString
    {
        /// <summary>
        /// Guardar: Metodo estatico que se encarga de escribir un string dentro de un archivo que se guardará en el escritorio de la maquina
        /// </summary>
        /// <param name="texto">String del texto que se escribirá en el archivo</param>
        /// <param name="archivo">String con el nomber del archivo, no requiere tipo de archivo</param>
        /// <returns>Boolean que indica si se logró la escribir el texto deseado en el archivo correspondiente</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            Boolean retorno = false;
            StreamWriter auxGuardado;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo + ".txt";

            if ((auxGuardado = new StreamWriter(path, true)) != null)
            {
                auxGuardado.WriteLine(texto);
                retorno = true;
            }

            auxGuardado.Close();
            return retorno;
        }
    }

}
