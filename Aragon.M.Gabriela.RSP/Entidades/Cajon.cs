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
    public class Cajon<T> : ISerializar
    {
        //public delegate void CajonDelegado(Object objecto, EventArgs e);
        public delegate void CajonDelegado(double precio);

        public event CajonDelegado EventoPrecio;

        protected List<T> _elementos;
        protected int _capacidad;
        protected double _precioUnitario;

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        public double PrecioTotal
        {
            //get
            //{
            //    if (this._precioUnitario * this.Elementos.Count > 55)
            //    {
            //        this.EventoPrecio += new CajonDelegado(Manejador);
            //        this.EventoPrecio(this, new EventArgs());
            //    }
            //    return this._precioUnitario * this.Elementos.Count;
            //}
            get
            {
                double precio = this._precioUnitario * this._elementos.Count();
                if (precio > 55)
                {
                    this.EventoPrecio(precio);
                }
                return precio;
            }
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

        public Cajon()
        {
            this._elementos = new List<T>();
            //Console.WriteLine("Cajon lleno");
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precio, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precio;
        }


        public bool Xml(string nombre)
        {
            //try
            //{
            //    TextWriter escritor = new StreamWriter(this.RutaArchivo + @"\" + nombre);
            //    XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));
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
            using (TextWriter writer = new StreamWriter(String.Format(@"{0}\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombre)))
            try
            {
                XmlSerializer serializerXml = new XmlSerializer(typeof(Cajon<T>));
                serializerXml.Serialize(writer, this);
                retorno = true;
            }
            catch (Exception e)
            { /*Console.WriteLine(e.Message);*/ }
            finally
            { writer.Close(); }
            return retorno;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            //Cajon<T> retorno = c;
            //if ((f is Fruta) && (retorno._elementos.Count < retorno._capacidad))
            //{
            //    retorno._elementos.Add(f);
            //}
            //else if (retorno._elementos.Count >= retorno._capacidad)
            //{
            //    throw new CajonLlenoException("El cajon esta lleno");
            //}
            //return retorno;
            if (c!=null && c.Elementos.Count() < c._capacidad)
            {
                c.Elementos.Add(f);
                return c;
            }
            else
            {
                throw new CajonLlenoException("\nEl cajon esta lleno");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CAJON\n");
            sb.AppendFormat("Capacidad: {0}\nCantidad de Elementos: {1}\n", this._capacidad, this._elementos.Count);
            sb.AppendFormat("Precio TOTAL: ${0}\n", this.PrecioTotal);
            foreach (T fruta in this._elementos)
            {
                sb.AppendLine(fruta.ToString());
            }
            return sb.ToString();
        }

        //public static void Manejador(object objeto, EventArgs evento)
        //{
        //    StreamWriter escritor = new StreamWriter(((Cajon<T>)objeto).RutaArchivo + "Archivo.txt");
        //    escritor.WriteLine("Precio total: " + ((Cajon<T>)objeto)._capacidad * ((Cajon<T>)objeto)._precioUnitario);
        //    escritor.WriteLine("Horario" + DateTime.Now);
        //    escritor.Close();
        //}
    }
}
