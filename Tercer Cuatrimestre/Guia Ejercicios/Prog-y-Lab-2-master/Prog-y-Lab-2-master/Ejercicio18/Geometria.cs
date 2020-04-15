using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            float retorno;
            int ladoA = this.vertice1.GetY() - this.vertice3.GetY();
            int ladoB = this.vertice3.GetX() - this.vertice1.GetX();
            retorno = (float)(ladoA * ladoB);
            this.area = retorno;
            return retorno;
        }

        public float Perimetro()
        {
            float retorno;
            int ladoA = this.vertice1.GetY() - this.vertice3.GetY();
            int ladoB = this.vertice3.GetX() - this.vertice1.GetX();
            retorno = (float)(ladoA + ladoB) * 2;
            this.perimetro = retorno;
            return retorno;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

        public float GetArea()
        {
            return this.Area();
        }

        public float GetPerimetro()
        {
            return this.Perimetro();
        }

        public string Mostrar()
        {
            string retorno = "Vertice 1\t\tVertice 3\n X:" + this.vertice1.GetX() + "\tY:" + this.vertice1.GetY() + "\t\t X:" + this.vertice3.GetX() + "\tY:" + this.vertice3.GetY();
            return retorno;
        }
    }
}
