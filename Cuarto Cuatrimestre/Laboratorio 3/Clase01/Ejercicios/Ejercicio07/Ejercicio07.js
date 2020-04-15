function Cubo(params) {
    return Math.pow(params, 3);
}
var resultado = Cubo(2);
var funcion = Cubo;
console.log(resultado);
console.log(funcion(3));
