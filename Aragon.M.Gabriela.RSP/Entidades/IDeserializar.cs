using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public interface IDeserializar
    {
        //string RutaArchivo { get; set; }

        bool Xml(string texto, out Fruta fruta);
    }
}

