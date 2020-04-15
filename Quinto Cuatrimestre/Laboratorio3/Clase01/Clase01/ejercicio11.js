"use strict";
/**11. Definir una función que determine si la cadena de texto que se le pasa como parámetro es un
palíndromo, es decir, si se lee de la misma forma desde la izquierda y desde la derecha.
Ejemplo de palíndromo complejo: "La ruta nos aporto otro paso natural". */
function EsPalindromo(texto) {
    var cadena = texto.toLowerCase();
    cadena = cadena.replace(/ /g, "");
    var mitadUno;
    var mitadDos;
    var mitadDosAlReves = "";
    console.log("El texto: " + texto);
    if (cadena.length % 2 != 0) {
        mitadUno = cadena.substring(0, ((cadena.length / 2) - 0.5));
        mitadDos = cadena.substring(((cadena.length / 2) + 0.5), cadena.length);
    }
    else {
        mitadUno = cadena.substring(0, (cadena.length / 2));
        mitadDos = cadena.substring((cadena.length / 2), cadena.length);
    }
    for (var i = mitadDos.length - 1; i >= 0; i--) {
        mitadDosAlReves += mitadDos[i];
    }
    if (mitadUno.localeCompare(mitadDosAlReves) == 0) {
        console.log("Es palindromo");
    }
    else {
        console.log("No es palindromo");
    }
}
EsPalindromo("La ruta nos aporto otro paso natural");
//# sourceMappingURL=ejercicio11.js.map