using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase2310
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if ((a._color == b._color) && (a._marca == b._marca))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if ((obj != null) && (Equals(obj.GetType(), this)))
            {
                if ((Auto)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
            /*/       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);  */
        }

        /*/ override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }*/

        public override string ToString()
        {
            string retorno = "Marca: " + this._marca + "   Color: " + this._color + "\n";
            return retorno;
        }
    }

    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        /*bool Agregar(Auto a)
        {

        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            int contador = 0;
            for (int i = 0; i < this._capacidadMaxima; i++)
            {
                (Tempera)this._colores.GetValue(contador) == tempera)
                if ((Auto)this._lista.FindIndex(x=> x.Equals(a))
                {
                    indice = i;
                    break;
                }
                contador++;
            }
            return indice;
        }

        public static bool operator +(DepositoDeAutos d,Auto a)
        {
            bool retorno = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                foreach (Auto item in d._lista)
                {
                    if (item == a)
                    {
                        d._lista.Add(a);
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

        }

        bool Remover(Auto a)
        {

        }

        public override string ToString()
        {

        }*/
    }
}
