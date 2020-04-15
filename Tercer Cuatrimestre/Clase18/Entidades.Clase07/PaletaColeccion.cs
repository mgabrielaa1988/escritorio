using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    public class PaletaColeccion
    {
        private List<Tempera> _colores;
        private int _cantMaximaElementos;

        private PaletaColeccion() : this(5) { }

        private PaletaColeccion(int cantidad)
        {
            this._cantMaximaElementos = cantidad;
            this._colores = new List<Tempera>();
        }

        public int CantidadTemperas { get { return this._colores.Count; } }

        private string Mostrar()
        {
            string retorno="";
            foreach (Tempera unaTempera in this._colores)
            {
                if (!(Object.Equals(unaTempera, null)))
                {
                    retorno = retorno + unaTempera + "\r\n";
                }
            }
            return retorno;
        }

        public static explicit operator string(PaletaColeccion paleta)
        {
            return paleta.Mostrar();
        }

        public static implicit operator PaletaColeccion(int cantidad)
        {
            //Paleta paleta = new Paleta(cantidad);
            //return paleta;
            return new PaletaColeccion(cantidad);
        }

        public static bool operator ==(PaletaColeccion paleta,Tempera tempera)
        {
            bool retorno = false;

            foreach (Tempera item in paleta._colores)
            {
                if (item == tempera)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(PaletaColeccion paleta,Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static PaletaColeccion operator +(PaletaColeccion paleta,Tempera tempera)
        {
            Tempera auxTemp = null;
            int indice = -1;
            bool flag = false;
            foreach (Tempera item in paleta._colores)
            {
                if (item == tempera)
                {
                    auxTemp = item;
                    indice = paleta._colores.IndexOf(auxTemp);
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                auxTemp += tempera;
                paleta._colores.Insert(indice, auxTemp);
            }
            else if (paleta._cantMaximaElementos > paleta._colores.Count)
            {
                paleta._colores.Add(tempera);
            }
            return paleta;
        }

        public static PaletaColeccion operator -(PaletaColeccion paleta, Tempera tempera)
        {
            Tempera auxTemp = null;
            int indice = -1;
            sbyte tamPaleta;
            sbyte tamTempera;

            foreach (Tempera item in paleta._colores)
            {
                if (item == tempera)
                {
                    auxTemp = item;
                    indice = paleta._colores.IndexOf(auxTemp);
                    break;
                }
            }
            tamPaleta = (sbyte)auxTemp;
            tamTempera = (sbyte)tempera;
            if (tamPaleta - tamTempera >= 0)
            {
                paleta._colores.Remove(auxTemp);
                paleta._colores.Insert(indice, auxTemp);
            }
            else
            {
                auxTemp += (sbyte)(tamTempera * -1);
            }
            return paleta;
        }
    }
}
