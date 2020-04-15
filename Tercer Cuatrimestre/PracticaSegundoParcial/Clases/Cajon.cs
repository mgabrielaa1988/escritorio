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
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]
    public class Cajon<T>:ISerializable
    {
        protected List<T> _frutas;
        protected int _capacidad;
        protected float _precioUnitario;

        public List<T> Frutas
        {
            get
            {
                return this._frutas;
            }
        }

        public float PrecioTotal
        {
            get
            {
                float retorno = 0;

                foreach (T frutaA in this._frutas)
                {
                    retorno += this._precioUnitario;
                }
                if (retorno > 25)
                {
                    this.EventoPrecio(this, new EventArgs());
                }
                return retorno;
            }
        }

        public string RutaArchivo
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
            set
            {
                this.RutaArchivo = value;
            }
        }

        public Cajon()
        {
            this._frutas = new List<T>();
            this.EventoPrecio += new CajonDelegado(this.GuardarArchivo);
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public bool DeserializarXML()
        {
            bool retorno = false;
            XmlTextReader reader = new XmlTextReader(this.RutaArchivo);
            XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
            try
            {
                Cajon<T> cajon = new Cajon<T>();
                
                cajon = (Cajon<T>)serializer.Deserialize(reader);
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
            XmlTextWriter writer = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
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

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            Cajon<T> retorno = c;
            if ((f is Fruta) && (retorno._frutas.Count < retorno._capacidad))
            {
                retorno._frutas.Add(f);
            }
            else if (retorno._frutas.Count >= retorno._capacidad)
            {
                throw new CajonLlenoException("El cajon esta lleno");
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CAJON\n");
            sb.AppendFormat("Capacidad Maxima: {0}\nCantidad Total de Frutas: {1}\n", this._capacidad, this._frutas.Count);
            sb.AppendFormat("Precio TOTAL: ${0}-", this.PrecioTotal);
            foreach (T f in this._frutas)
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString();
        }

        public event CajonDelegado EventoPrecio;

        public delegate void CajonDelegado(Cajon<T> elemento, EventArgs e);

        private void GuardarArchivo(Cajon<T> elemento, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(elemento.RutaArchivo + @"\Archivo.txt");
            if (writer != null)
            {
                writer.WriteLine("Precio TOTAL: $" + elemento.PrecioTotal.ToString());
                writer.WriteLine(DateTime.Now.ToString());             
            }
            writer.Close();
        }
    }
}
