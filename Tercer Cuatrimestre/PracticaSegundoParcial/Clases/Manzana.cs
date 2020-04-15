using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Clases
{
    [Serializable]
    public class Manzana:Fruta,ISerializable
    {
        public string distribuidora;

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public string Tipo
        {
            get
            {
                return "Manzana";
            }
        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\tDistribuidora: {2}\n", this.Tipo, base.FrutaToString(), this.distribuidora);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool DeserializarXML()
        {
            bool retorno = false;
            XmlTextReader reader = new XmlTextReader(this.RutaArchivo);
            XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
            try
            {
               
                Manzana auxiliar = (Manzana)serializer.Deserialize(reader);
                this._color = auxiliar._color;
                this.distribuidora = auxiliar.distribuidora;
                this._peso = auxiliar._peso;
                this.RutaArchivo = auxiliar.RutaArchivo;
                reader.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public bool SerializarXML()
        {
            bool retorno = false;
            XmlTextWriter writer = new XmlTextWriter(((ISerializable)this).RutaArchivo, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
            try
            {
                
                serializer.Serialize(writer, this);
                writer.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public string RutaArchivo{ get; set; }
    }
}
