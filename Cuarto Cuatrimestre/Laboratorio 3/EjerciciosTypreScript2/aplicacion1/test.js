var aplicacion1;
(function (aplicacion1) {
    var Punto = /** @class */ (function () {
        function Punto(x, y) {
            this._x = x;
            this._y = y;
        }
        Punto.prototype.GetX = function () {
            return this._x;
        };
        Punto.prototype.GetY = function () {
            return this._y;
        };
        return Punto;
    }());
    aplicacion1.Punto = Punto;
})(aplicacion1 || (aplicacion1 = {}));
var aplicacion1;
(function (aplicacion1) {
    var Rectangulo = /** @class */ (function () {
        function Rectangulo(v1, v3) {
            this._vertice1 = v1;
            this._vertice3 = v3;
            this._vertice2 = new aplicacion1.Punto(v1.GetX(), v3.GetY());
            this._vertice4 = new aplicacion1.Punto(v3.GetX(), v1.GetY());
            this._ladoUno = (v3.GetX() - v1.GetX());
            this._ladoDos = (v3.GetY() - v1.GetY());
            this._perimetro = this._ladoUno * 2 + this._ladoDos * 2;
            this._area = this._ladoUno * this._ladoDos;
        }
        Rectangulo.prototype.GetArea = function () {
            return this._area;
        };
        Rectangulo.prototype.GetPerimetro = function () {
            return this._perimetro;
        };
        Rectangulo.prototype.ToString = function () {
            return "\nLado 1: " + this._ladoUno + "\nLado 2: " + this._ladoDos + "\nPerimetro: " + this.GetPerimetro() + "\nArea: " + this.GetArea();
        };
        return Rectangulo;
    }());
    aplicacion1.Rectangulo = Rectangulo;
})(aplicacion1 || (aplicacion1 = {}));
var aplicacion1;
(function (aplicacion1) {
    var vert1 = new aplicacion1.Punto(2, 4);
    var vert3 = new aplicacion1.Punto(5, 10);
    var rectangulo = new aplicacion1.Rectangulo(vert1, vert3);
    console.log(rectangulo.ToString());
})(aplicacion1 || (aplicacion1 = {}));
