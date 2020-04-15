using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// (Extension) Permite guardar texto a un archivo que se genera en el Escritorio.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;
            StreamWriter writer = new StreamWriter(path, true);
            if (writer != null)
            {
                writer.WriteLine(texto);
                retorno = true;
            }
            writer.Close();
            return retorno;
        }
    }
}
