using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.SP
{
    [Serializable]
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

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
                return "Manzana";
            }
        }

        public Manzana() : base(0, "Roja") { }

        public Manzana( string color, double peso,string origen) : base(peso, color)
        {
            this._provinciaOrigen = origen;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\tOrigen: {2}\n", this.Nombre, base.FrutaToString(), this._provinciaOrigen);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        //public string RutaArchivo
        //{
        //    get
        //    {
        //        return AppDomain.CurrentDomain.BaseDirectory;
        //    }
        //    set
        //    {
        //        this.RutaArchivo = value;
        //    }
        //}

        bool IDeserializar.Xml(string nombre, out Fruta fruta)
        {
            //fruta = null;
            //try
            //{
            //    TextWriter escritor = new StreamWriter(this.RutaArchivo + "Archivo.xml");
            //    XmlSerializer serializador = new XmlSerializer(typeof(Manzana));
            //    serializador.Serialize(escritor, this);
            //    escritor.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    return false;
            //}
            //return true;
            bool retorno = false;
            using (TextReader reader = new StreamReader(String.Format(@"{0}\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombre)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                fruta = (Manzana)serializer.Deserialize(reader);
                retorno = true;
            }
            return retorno;
        }

        public bool Xml(string nombre)
        {
            //try
            //{
            //    TextWriter escritor = new StreamWriter(this.RutaArchivo + @"\" + nombre);
            //    XmlSerializer serializador = new XmlSerializer(typeof(Manzana));
            //    serializador.Serialize(escritor, this);
            //    escritor.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    return false;
            //}
            //return true;
            Boolean retorno = false;
            using (TextWriter writer = new StreamWriter(String.Format(@"{0}\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombre)))


                try
                {
                    XmlSerializer serializerXml = new XmlSerializer(typeof(Manzana));
                    serializerXml.Serialize(writer, this);
                    retorno = true;
                }
                catch (Exception e)
                { /*Console.WriteLine(e.Message);*/ }
                finally
                { writer.Close(); }

            return retorno;
        }
    }
}
