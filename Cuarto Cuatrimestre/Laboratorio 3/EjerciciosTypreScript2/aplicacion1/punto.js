"use strict";
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
//# sourceMappingURL=punto.js.map