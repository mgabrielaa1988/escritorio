using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesClase2310b
{
    class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito()
        {
            this._lista = new List<T>();
        }
        public Deposito(int capacidad) : this()
        {
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(T a)
        {
            int indice = -1;
            foreach (T item in this._lista)
            {
                if (a.Equals(item))
                {
                    indice = this._lista.IndexOf(item);
                    break;
                }
            }
            return indice;
        }

        public bool Agregar(T a)
        {
            return (this + a);
        }

        public bool Remover(T a)
        {
            return (this - a);
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Deposito<T> d, T a)
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
            string retorno = "---Stock del Deposito---\r\nCapacidad maxima: " + this._capacidadMaxima;
            foreach (T item in this._lista)
            {
                if (!(Object.Equals(item, null)))
                {
                    retorno = retorno + item;
                }
            }
            return retorno;
        }

        public bool Guardar(string cadena)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(cadena))
                {
                    sw.Write(this.ToString());
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return retorno;
        }

        public bool Recuperar(string cadena)
        {
            bool retorno = false;
            try
            {
                StreamReader sr = new StreamReader(cadena);
                Console.Write(sr.ReadToEnd());
                retorno = true;
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return retorno;
        }
    }
}
