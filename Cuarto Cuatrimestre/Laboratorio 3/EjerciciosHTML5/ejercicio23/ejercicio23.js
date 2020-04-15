"use strict";
function Calcular() {
    var nombre = document.getElementById("nombre").value;
    var apellido = document.getElementById("apellido").value;
    var email = document.getElementById("email").value;
    var auxHoras = document.getElementById("horas").value;
    var horas = parseInt(auxHoras, 10);
    var salario = 0;
    if (isNaN(horas)) {
        horas = 0;
    }
    salario = horas * ObtenerCoeficiente();
    var txt = "Empleado: " + apellido + "," + nombre + "<br>Email: " + email + "<br>Salario por " + auxHoras + " horas trabajadas: " + salario + ".";
    document.getElementById("auxCalculo").innerHTML = txt;
}
function ObtenerCoeficiente() {
    return 6.88;
}
//# sourceMappingURL=ejercicio23.js.map