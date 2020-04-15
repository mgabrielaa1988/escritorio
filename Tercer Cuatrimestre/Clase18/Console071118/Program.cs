using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase071118;

namespace Console071118
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor tele = new Televisor(1900,"Sony",10000,32,"China");
            tele.MiEvento += new MiDelegado(PruebaEvento);
            tele.MiEvento += new MiDelegado(new Program().PruebaEvento2);           
            tele.EventoTV += new DelegadoTV(new Program().Mostrar);
            tele.Insertar();
        }

        public static void PruebaEvento()
        {
            Console.WriteLine("Se inserto un registro en la base de datos\n");
            Console.ReadLine();
        }

        public void PruebaEvento2()
        {
            Console.WriteLine("Estoy en el segundo metodo\n");
            Console.ReadLine();
        }

        public void Mostrar(Televisor televisor,TVeventsArgs args)
        {
            Console.WriteLine("codigo:{0}\tmarca:{1}\tprecio:{2}\tpulgadas:{3}\tpais:{4}\n",televisor.codigo,televisor.marca,televisor.precio,televisor.pulgadas,televisor.pais);
            Console.WriteLine("fecha: " + args.MiFecha);
            Console.ReadLine();
        }
    }
}
