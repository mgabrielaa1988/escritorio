function AgregarElemento() {
    var elementoNuevo = document.getElementById("cuadroText").value;
    if (elementoNuevo !== "") {
        document.getElementById("lista").innerHTML += "<li>" + elementoNuevo + "</li>";
        document.getElementById("cuadroText").value = "";
    }
}
