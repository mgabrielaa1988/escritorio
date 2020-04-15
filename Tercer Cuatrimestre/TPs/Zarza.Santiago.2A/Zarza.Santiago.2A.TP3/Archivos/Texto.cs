using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<String>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            StreamWriter writer = null;

            try
            {
              writer = new StreamWriter(archivo,true);

              if(writer != null)
              {
                 writer.Write(datos);
                 retorno = true;
              }
            }
            catch(Exception e)
            {
               throw e;
            }
            finally
            {
              writer.Close();
            }

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = default(bool);
            StreamReader reader = new StreamReader(archivo);

            if ( (datos = reader.ReadToEnd() ) != null )
            {
                retorno = true;
            }

            reader.Close();

            return retorno;
        }
    }
}
