"use strict";
function MostrarOpcion() {
    var radio = document.getElementsByName("voto");
    var voto = "";
    for (var index = 0; index < radio.length; index++) {
        if (radio[index].checked == true) {
            voto = radio[index].value;
            break;
        }
    }
    var nombre = document.getElementById("txtNombre").value;
    var msj = "Nombre: " + nombre + "\nValoraci\u00F3n: " + voto;
    alert(msj);
}
//# sourceMappingURL=ejercicio18.js.map