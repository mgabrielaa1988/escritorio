using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> :IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            TextWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + archivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(escritor, datos);
            escritor.Close();
            return true;
        }
        public bool Leer(string archivo, out T datos)
        {
            TextReader lectura = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + archivo);
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            datos = (T) deserializer.Deserialize(lectura);
            lectura.Close();
            return true;
        }

    }
}
