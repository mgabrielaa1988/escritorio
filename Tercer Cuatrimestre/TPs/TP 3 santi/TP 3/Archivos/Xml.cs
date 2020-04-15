using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
              bool retorno = false;
              XmlSerializer serializer = null;
              XmlTextWriter xmlTextWriter = null;

              try
              {
                xmlTextWriter = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(xmlTextWriter, datos);
                retorno = true;
              }
              catch(Exception e)
              {
                throw e;
              }
              finally
              {
                xmlTextWriter.Close();
              }

  
              return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
          bool retorno = false;
          XmlSerializer serializer = null;
          XmlTextReader xmlTextReader = null;
          datos = default(T);

          try
          {
            xmlTextReader = new XmlTextReader(archivo);
            serializer = new XmlSerializer(typeof(T));

            datos = (T)serializer.Deserialize(xmlTextReader);
            retorno = true;
          }
          catch (Exception e)
          {
            throw e;
          }
          finally
          {
             xmlTextReader.Close();
          }


          return retorno;
        }
    }
}
