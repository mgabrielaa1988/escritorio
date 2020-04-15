using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    public interface IMostrar<T>
    {
        /// <summary>
        /// MostrarDatos: Metodo que se utilizará como base para mostrar datos de los distintos elementos
        /// </summary>
        /// <param name="elemento">Elemento de cualquier tipo que se le asigne a la interface en el momento de su implementación</param>
        /// <returns>String con los datos del elemento enviado por parametro</returns>
        string MostrarDatos(IMostrar<T> elemento);
    }
}
