using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceBoligrafo
{
    class Boligrafo
    {
        private const short _cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.SetTinta(tinta);
            this._color = color;
        }

        private void SetTinta(short tinta)
        {
            this._tinta += tinta;
            if (this._tinta > 100)
            {
                this._tinta = _cantidadTintaMaxima;
            }
            else if (this._tinta < 0)
            {
                this._tinta = 0;
            }
        }

        public void Recargar()
        {
            this.SetTinta(_cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";

            if (this._tinta > 0 && gasto < 0) 
            {
                if (this._tinta > gasto * -1)
                {
                    for (int i = gasto; i < 0; i++)
                        dibujo = dibujo + "*";
                }
                else
                {
                    for (int i = 0; i < this._tinta; i++)
                        dibujo = dibujo + "*";
                }

                this.SetTinta((short)gasto);
                Console.Write("Se pudo emplear esta cantidad de tinta: " + dibujo + "("+dibujo.Length+")");
                retorno = true;
            }
            else
            {
                Console.WriteLine("No se pudo pintar");
            }
            return retorno;
        }
    }
}
