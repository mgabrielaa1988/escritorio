using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaElementos;

        private Paleta() : this(5)
        {
            
        }

        private Paleta(int cantidad)
        {
            this._cantMaximaElementos = cantidad;
            this._colores = new Tempera[_cantMaximaElementos];
        }

        //public int CantidadTemperas { set { return this._colores.Count; } }

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

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static implicit operator Paleta(int cantidad)
        {
            //Paleta paleta = new Paleta(cantidad);
            //return paleta;
            return new Paleta(cantidad);
        }

        public static bool operator ==(Paleta paleta,Tempera tempera)
        {
            bool retorno = false;
            
            for(int i = 0; i < paleta._cantMaximaElementos; i++)
            {
                if (paleta._colores.GetValue(i) != null)
                {
                    if (paleta._colores[i] == tempera)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta paleta,Tempera tempera)
        {
            return !(paleta == tempera);
        }

        private int ObtenerIndice()
        {
            int indice=-1;
            int contador = 0;
            for(int i = 0; i < this._cantMaximaElementos; i++)
            {
                if (this._colores.GetValue(contador) == null)
                {
                    indice = i;
                    break;
                }
                contador++;
            }
            return indice;
        }

        private int ObtenerIndice(Tempera tempera)
        {
            int indice = -1;
            int contador = 0;
            for (int i = 0; i < this._cantMaximaElementos; i++)
            {
                if ((Tempera)this._colores.GetValue(contador) == tempera)
                {
                    indice = i;
                    break;
                }
                contador++;
            }
            return indice;
        }

        public static Paleta operator +(Paleta paleta,Tempera tempera)
        {
            int indice=-1;
            if (paleta == tempera)
            {
                indice=paleta.ObtenerIndice(tempera);
                paleta._colores[indice] += tempera;
            }
            else
            {
                indice = paleta.ObtenerIndice();
                if (indice > -1)
                {
                    paleta._colores[indice] = tempera;
                }
            }
            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = -1;
            sbyte tamPaleta;
            sbyte tamTempera;
            if (paleta == tempera)
            {
                indice = paleta.ObtenerIndice(tempera);
                tamPaleta = (sbyte)paleta._colores[indice];
                tamTempera = (sbyte)tempera;
                if (tamPaleta - tamTempera <= 0)
                {
                    paleta._colores[indice] = null;
                }
                else
                {
                    paleta._colores[indice] += (sbyte)(tamTempera * (-1));
                }
            }
            return paleta;
        }

        /*public Indexador this[int indice]
        {
            get
            {
                if (indice >= this._colores.Count || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._colores.Count)
                    this._colores[indice] = value;
                else if (indice == this._colores.Count)
                    this._colores.Add(value);
                else
            }
        }*/
    }
}
