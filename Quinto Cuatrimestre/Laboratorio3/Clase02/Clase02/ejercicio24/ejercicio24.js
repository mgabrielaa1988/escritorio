"use strict";
function btnValidar() {
    var nombre = document.getElementById("nombre").value;
    CheckError(nombre, "nombre", "Nombre");
    var apellido = document.getElementById("apellido").value;
    CheckError(apellido, "apellido", "Apellido");
    var strDni = document.getElementById("dni").value;
    CheckError(strDni, "dni", "DNI");
    var dni = parseInt(strDni);
    if (isNaN(dni) || dni < 1) {
        alert("DNI: Solo puede ingresar numeros positivos");
        document.getElementById("dni").placeholder = "";
    }
    var sexo = document.getElementById("sexo").value;
    CheckError(sexo, "sexo", "Sexo");
    var sex = sexo.toLowerCase();
    if (sex != "f" && sex != "i" && sex != "m") {
        alert("Sexo: Solo puede ser, f para femenino, m para masculino, o i para indefinido");
        document.getElementById("sexo").placeholder = "";
    }
}
function CheckError(contenido, id, texto) {
    if (contenido == "") {
        document.getElementById(id).placeholder = texto + " est\u00E1 vacio.";
    }
    else {
        document.getElementById(id).placeholder = "";
    }
}
//# sourceMappingURL=ejercicio24.js.map