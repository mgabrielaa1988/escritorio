
namespace aplicacion1
{
    export class Rectangulo 
    {
        private _ladoUno:number;
        private _ladoDos:number;
        private _area:number;
        private _perimetro:number;
        private _vertice1:Punto;
        private _vertice2:Punto;
        private _vertice3:Punto;
        private _vertice4:Punto;

        public constructor(v1:Punto,v3:Punto){
            this._vertice1=v1;
            this._vertice3=v3;
            this._vertice2=new Punto(v1.GetX(),v3.GetY());
            this._vertice4=new Punto(v3.GetX(),v1.GetY());
            this._ladoUno =(v3.GetX()-v1.GetX());
            this._ladoDos =(v3.GetY() - v1.GetY());
            this._perimetro = this._ladoUno * 2 + this._ladoDos * 2;
            this._area = this._ladoUno * this._ladoDos;
        }

        public GetArea(): number {
            return this._area;
        }

        public GetPerimetro(): number {
            return this._perimetro;
        }

        public ToString(): string {
            return `\nLado 1: ${this._ladoUno}\nLado 2: ${this._ladoDos}\nPerimetro: ${this.GetPerimetro()}\nArea: ${this.GetArea()}`;
        }
    }
}
