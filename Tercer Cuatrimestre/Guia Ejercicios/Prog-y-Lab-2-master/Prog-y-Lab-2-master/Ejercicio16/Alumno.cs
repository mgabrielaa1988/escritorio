using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno (string apell, int leg,string nom)
        {
            this.apellido = apell;
            this.legajo = leg;
            this.nombre = nom;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random randomN = new Random();
                this._notaFinal = randomN.Next(4, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}   Apellido: {1}   Legajo: {2}   Nota 1: {3}   Nota 2: {4} ", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2);
            if (this._notaFinal == -1)
            {
                Console.WriteLine("   Alumno desaprobado");
            }
            else
            {
                Console.WriteLine("    Nota Final: {0}", this._notaFinal);
            }
            Console.ReadLine();
        }
    }
}
