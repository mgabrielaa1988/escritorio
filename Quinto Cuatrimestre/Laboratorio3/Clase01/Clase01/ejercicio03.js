"use strict";
/**3. Realizar una función que reciba un parámetro requerido de tipo numérico y otro opcional
de tipo cadena. Si el segundo parámetro es recibido, se mostrará tantas veces por
consola, como lo indique el primer parámetro. En caso de no recibir el segundo
parámetro, se mostrará el valor inverso del primer parámetro. */
function prueba(numero, cadena) {
    if (cadena != null) {
        for (var index = 0; index < numero; index++) {
            console.log(cadena);
        }
    }
    else {
        console.log(numero * -1);
    }
}
var num = 3;
var texto = "cadena de texto";
prueba(num, texto);
prueba(num);
//# sourceMappingURL=ejercicio03.js.map