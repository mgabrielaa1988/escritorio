"use strict";
/**6. Realizar una función que reciba como parámetro un número y que retorne el cubo del mismo.
Nota : La función retornará el cubo del parámetro ingresado. Realizar una función que invoque a
esta última y permita mostrar por consola el resultado.  */
function cubo(numero) {
    return (numero * numero * numero);
}
function MostrarCubo(numero) {
    console.log("El cubo de " + numero + " es: " + cubo(numero));
}
MostrarCubo(2);
MostrarCubo(4);
MostrarCubo(5);
//# sourceMappingURL=ejercicio06.js.map