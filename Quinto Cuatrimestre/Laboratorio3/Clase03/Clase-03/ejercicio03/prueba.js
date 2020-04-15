var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Test;
(function (Test) {
    var Persona = /** @class */ (function () {
        function Persona(nombre, apellido, dni, sexo) {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._sexo = sexo;
        }
        Object.defineProperty(Persona.prototype, "GetApellido", {
            get: function () {
                return this._apellido;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Persona.prototype, "GetDNI", {
            get: function () {
                return this._dni;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Persona.prototype, "GetNombre", {
            get: function () {
                return this._nombre;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Persona.prototype, "GetSexo", {
            get: function () {
                return this._sexo;
            },
            enumerable: true,
            configurable: true
        });
        Persona.prototype.ToString = function () {
            return (this._apellido + " - " + this._nombre + " - " + this._dni + " - " + this._sexo);
        };
        return Persona;
    }());
    Test.Persona = Persona;
})(Test || (Test = {}));
/// <reference path="persona.ts"/>
var Test;
(function (Test) {
    var Empleado = /** @class */ (function (_super) {
        __extends(Empleado, _super);
        function Empleado(nombre, apellido, dni, sexo, legajo, sueldo) {
            var _this = _super.call(this, nombre, apellido, dni, sexo) || this;
            _this._legajo = legajo;
            _this._sueldo = sueldo;
            return _this;
        }
        Object.defineProperty(Empleado.prototype, "GetLegajo", {
            get: function () {
                return this._legajo;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Empleado.prototype, "GetSueldo", {
            get: function () {
                return this._sueldo;
            },
            enumerable: true,
            configurable: true
        });
        Empleado.prototype.Hablar = function (idioma) {
            return ("El empleado habla " + idioma);
        };
        Empleado.prototype.ToString = function () {
            return (_super.prototype.ToString.call(this) + " - " + this._legajo + " - " + this._sueldo);
        };
        return Empleado;
    }(Test.Persona));
    Test.Empleado = Empleado;
})(Test || (Test = {}));
/// <reference path="empleado.ts"/>
var emp1 = new Test.Empleado("Juan", "Topo", 1111, "m", 111, 1000);
console.log(emp1.GetApellido);
console.log(emp1.GetNombre);
console.log(emp1.GetDNI);
console.log(emp1.GetSexo);
console.log(emp1.GetLegajo);
console.log(emp1.GetSueldo);
console.log(emp1.Hablar("Español"));
console.log(emp1.ToString());
