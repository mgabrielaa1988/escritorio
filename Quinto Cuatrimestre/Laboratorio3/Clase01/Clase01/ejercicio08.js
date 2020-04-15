"use strict";
/**8. Crear una función que realice el cálculo factorial del número que recibe como parámetro.
Nota : Utilizar console.log() */
function factorial(numero) {
    var total;
    if (numero == 0) {
        return 1;
    }
    total = numero * factorial(numero - 1);
    return total;
}
function mostrarFactorial(numero) {
    console.log("El factorial de " + numero + " es: " + factorial(numero));
}
mostrarFactorial(3);
mostrarFactorial(4);
mostrarFactorial(5);
//# sourceMappingURL=ejercicio08.js.map