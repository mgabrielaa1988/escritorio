"use strict";
/**10. Definir una función que muestre información sobre una cadena de texto que se le pasa como argumento.
A partir de la cadena que se le pasa, la función determina si esa cadena está formada sólo por mayúsculas,
sólo por minúsculas o por una mezcla de ambas. */
function MayusculasOMinusculas(texto) {
    console.log("Texto: " + texto);
    var mayusculas = 0;
    for (var index = 0; index < texto.length; index++) {
        if (texto[index] == texto[index].toUpperCase()) {
            mayusculas++;
        }
    }
    switch (mayusculas) {
        case texto.length:
            {
                console.log("Todas las letras son mayusculas.");
                break;
            }
        case 0:
            {
                console.log("Todas las letras son minusculas.");
                break;
            }
        default:
            {
                console.log("Hay letras mayusculas y minusculas.");
                break;
            }
    }
}
MayusculasOMinusculas("MAYUSCULAS");
MayusculasOMinusculas("minusculas");
MayusculasOMinusculas("MeZCLaDaS");
//# sourceMappingURL=ejercicio10.js.map