"use strict";
/**5. Guardar su nombre y apellido en dos variables distintas.
Dichas variables serán pasadas como parámetro de la función MostrarNombreApellido ,
que mostrará el apellido en mayúscula y el nombre solo con la primera letra en mayúsculas
y el resto en minúsculas. El apellido y el nombre se mostrarán separados por una coma (,).
Nota : Utilizar console.log() */
var nombre2 = "gabriela";
var apellido2 = "aragon";
function MostrarNombreApellido(nombre, apellido) {
    console.log(apellido.toLocaleUpperCase() + ", " + nombre[0].toLocaleUpperCase() + nombre.slice(1));
}
MostrarNombreApellido(nombre2, apellido2);
//# sourceMappingURL=ejercicio05.js.map