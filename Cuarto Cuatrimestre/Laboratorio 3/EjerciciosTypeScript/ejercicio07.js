"use strict";
/*7. Se necesita mostrar por consola los primeros 20 números primos.
Para ello realizar una función . Nota : Utilizar console.log() */
function esPrimo(numero) {
    var primo = true;
    for (var i = 1; i < numero; i++) {
        if (numero / i == Math.round(numero / i) && i != 1 && i != numero) {
            primo = false;
            break;
        }
    }
    return primo;
}
var contador = 0;
for (var i = 2; i < 100; i++) {
    if (esPrimo(i)) {
        console.log((contador + 1) + " -Numero primo:" + i);
        contador++;
    }
    if (contador == 20) {
        break;
    }
}
//# sourceMappingURL=ejercicio07.js.map