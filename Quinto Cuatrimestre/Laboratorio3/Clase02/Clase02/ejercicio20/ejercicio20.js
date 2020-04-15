"use strict";
function HabilitarControles() {
    var contrasenia = document.getElementById("passw").value;
    var texto = document.getElementById("txtNombre").disabled;
    //let boton :Boolean =(<HTMLInputElement>document.getElementById("botton")).disabled;
    //contraseña que definimos nostros
    if (contrasenia == "holamundo") {
        texto = false;
        //boton=false;
    }
    else {
        texto = true;
        //boton=true;
    }
}
//# sourceMappingURL=ejercicio20.js.map