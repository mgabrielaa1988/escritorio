using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase2310b
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;
            if (a._codigo == b._codigo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if((obj!=null)&& Equals(obj.GetType(), this))
            {
                if ((Cocina)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            string retorno = "";
            string esInd = "";
            if (this.EsIndustrial)
            {
                esInd = "-Si-";
            }
            else
            {
                esInd = "-No-";
            }
            retorno = "\nCodigo: " + this._codigo.ToString() + "Precio: $" + this._precio.ToString() + "Industrial: " + esInd;
            return retorno;
        }
    }
}
