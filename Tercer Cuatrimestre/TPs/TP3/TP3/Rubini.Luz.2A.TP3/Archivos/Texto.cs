using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + archivo, true))
                {
                    escritor.WriteLine(datos + "\n<----------------------------->");
                }
                
            }
            catch (Exception e)
            {
                throw new ArchivosException(e.InnerException);
            }
            
            
            return true;
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader lector = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + archivo))
                {
                    datos = lector.ReadToEnd();
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e.InnerException);
            }
            
            return true;
        }

    }
}
