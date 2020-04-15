"use strict";
function EnviarInfo() {
    var nombre = document.getElementById("txtNombre").value;
    var mail = document.getElementById("txtMail").value;
    var dni = document.getElementById("txtDNI").value;
    var cv = document.getElementById("txtCV").value;
    var msj = "Nombre:" + nombre + "\nMail:" + mail + "\nDNI:" + dni + "\nCV:\n" + cv;
    alert(msj);
}
//# sourceMappingURL=ejercicio16.js.map