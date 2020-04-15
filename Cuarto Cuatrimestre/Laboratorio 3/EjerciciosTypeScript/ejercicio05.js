"use strict";
/*5. Guardar su nombre y apellido en dos variables distintas.
Dichas variables serán pasadas como parámetro de la función MostrarNombreApellido ,
que mostrará el apellido en mayúscula y el nombre solo con la primera letra en mayúsculas
y el resto en minúsculas. El apellido y el nombre se mostrarán separados por una coma (,).
Nota : Utilizar console.log() */
var nombre = "gabriela";
var apellido = "aragon";
function MostrarNombreApellido(name, surname) {
    console.log(surname.toLocaleUpperCase() + ", " + name[0].toLocaleUpperCase() + name.slice(1));
}
MostrarNombreApellido(nombre, apellido);
//# sourceMappingURL=ejercicio05.js.map