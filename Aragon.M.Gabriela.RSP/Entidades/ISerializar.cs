using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public interface ISerializar
    {
        //string RutaArchivo { get; set; }

        bool Xml(string texto);

    }
}
