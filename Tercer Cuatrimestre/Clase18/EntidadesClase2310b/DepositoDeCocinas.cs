using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesClase2310b
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        private int GetIndice(Cocina c)
        {
            int indice = -1;
            foreach (Cocina item in this._lista)
            {
                if (c == item)
                {
                    indice = this._lista.IndexOf(item);
                    break;
                }
            }
            return indice;
        }

        public bool Agregar(Cocina c)
        {
            return (this + c);
        }

        public bool Remover(Cocina c)
        {
            return (this - c);
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            int indice = d.GetIndice(c);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            string retorno = "---Stock del Deposito de Cocinas---\r\nCapacidad maxima: " + this._capacidadMaxima;
            foreach (Cocina item in this._lista)
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
            catch(Exception e)
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
