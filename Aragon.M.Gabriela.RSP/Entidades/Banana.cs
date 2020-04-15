using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }

        public Banana(string color, double peso, string pais) : base(peso, color)
        {
            this._paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\tOrigen: {2}\n", this.Nombre, base.FrutaToString(), this._paisOrigen);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
