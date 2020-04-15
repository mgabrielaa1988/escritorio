using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase2310b
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            return (this + a);
        }

        public bool Remover(Auto a)
        {
            return (this - a);
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            foreach (Auto item in this._lista)
            {
                if (a == item)
                {
                    indice = this._lista.IndexOf(item);
                    break;
                }
            }
            return indice;
        }

        public static bool operator +(DepositoDeAutos d,Auto a)
        {
            bool retorno = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            string retorno = "---Stock del Deposito de Autos---\r\nCapacidad maxima: " + this._capacidadMaxima;
            foreach (Auto item in this._lista)
            {
                if (!(Object.Equals(item, null)))
                {
                    retorno = retorno + item;
                }
            }
            return retorno;
        }
    }
}
