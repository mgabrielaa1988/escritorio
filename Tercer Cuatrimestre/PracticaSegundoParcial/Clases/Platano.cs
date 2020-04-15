using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class Platano:Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public string Tipo
        {
            get
            {
                return "Platano";
            }
        }

        public Platano(float peso, ConsoleColor color, string pais) : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\tOrigen: {2}\n", this.Tipo, base.FrutaToString(), this.paisOrigen);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
