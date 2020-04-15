"use strict";
function ObtenerCoeficiente(horas) {
    var retorno;
    var hs = parseInt(horas);
    if (isNaN(hs) || hs < 0) {
        retorno = "Cantidad de hs no valida";
    }
    else {
        retorno = (hs * 6.88).toString();
    }
    return retorno;
}
function btnCalcular() {
    var nombre = document.getElementById("nombre").value;
    var apellido = document.getElementById("apellido").value;
    var mail = document.getElementById("mail").value;
    var hsTrabajadas = document.getElementById("horasT").value;
    var salario = ObtenerCoeficiente(hsTrabajadas);
    document.getElementById("cuadro").placeholder = salario;
}
//# sourceMappingURL=ejercicio23.js.map