function AddErrorAll() {
    var nombre = document.getElementById("nombre").value;
    var apellido = document.getElementById("apellido").value;
    var dni = document.getElementById("dni").value;
    var sexo = document.getElementById("sexo").value;
    CheckError(nombre, "errorNombre", "Nombre");
    CheckError(apellido, "errorApellido", "Apellido");
    CheckError(dni, "errorDni", "Dni");
    CheckErrorSexo(sexo, "errorSexo");
    var sexAux = "";
    if (sexo == 'f') {
        sexAux = "femenino";
    }
    else if (sexo = "m") {
        sexAux = "masculino";
    }
    alert("Nombre: " + apellido + ", " + nombre + "\nDNI: " + dni + "\nSexo: " + sexAux);
}
function CheckError(texto, idEnPagina, textoEnMensaje) {
    if (texto === "") {
        document.getElementById(idEnPagina).innerHTML = textoEnMensaje + " est\u00E1 vacio.";
    }
    else {
        document.getElementById(idEnPagina).innerHTML = "";
    }
}
function CheckErrorSexo(texto, idEnPagina) {
    texto = texto.toLowerCase();
    if (texto !== "m" && texto !== "f") {
        document.getElementById(idEnPagina).innerHTML = "Por favor, ingrese f o m.";
    }
    else {
        document.getElementById(idEnPagina).innerHTML = "";
    }
}
