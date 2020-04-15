using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public Durazno(string color, double peso, int pelusa) : base(peso, color)
        {
            this._cantPelusa = pelusa;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\tCantidad de Pelusa: {2}\n", this.Nombre, base.FrutaToString(), this._cantPelusa);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}