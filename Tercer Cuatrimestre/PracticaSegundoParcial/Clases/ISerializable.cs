using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface ISerializable
    {
        string RutaArchivo { get; set; }

        Boolean DeserializarXML();

        Boolean SerializarXML();
    }
}
