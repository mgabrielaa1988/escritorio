using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase14
{
    public static class AdministradorDeArchivos
    {
        public static bool Escribir(string path, string texto)
        {
            bool retorno = false;
            try
            {
                using(StreamWriter sw=new StreamWriter(path))
                {
                    sw.Write(texto.ToString());
                    retorno = true;
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return retorno;
        }

        public static bool Leer(string path, out string mostrar)
        {
            bool retorno = false;
            mostrar = "";
            try
            {
                StreamReader sr = new StreamReader(path);
                mostrar = sr.ReadToEnd();
                retorno = true;
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return retorno;
        }
    }
}
