"use strict";
function MostrarSeleccion() {
    var peli1 = document.getElementById("1").checked;
    var peli2 = document.getElementById("2").checked;
    var peli3 = document.getElementById("3").checked;
    var peli4 = document.getElementById("4").checked;
    var peli5 = document.getElementById("5").checked;
    var msj = "No selecciono ninguna pelicula!!!\n";
    if (peli1 == true || peli2 == true || peli3 == true || peli4 == true || peli5 == true) {
        msj = "Peliculas elegidas:\n";
    }
    if (peli1) {
        msj += "Avatar\n";
    }
    if (peli2) {
        msj += "Titanic\n";
    }
    if (peli3) {
        msj += "Star Wars\n";
    }
    if (peli4) {
        msj += "Avengers\n";
    }
    if (peli5) {
        msj += "Jurassic World\n";
    }
    alert(msj);
}
//# sourceMappingURL=ejercicio17.js.map