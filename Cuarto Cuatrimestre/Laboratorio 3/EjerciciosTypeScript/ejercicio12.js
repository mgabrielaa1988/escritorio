"use strict";
/*12. Crear una función que reciba como único parámetro una cadena que contenga
el día, mes y año de nacimiento de una persona (con formato dd - mm - yyyy ).
La función mostrará por consola a que signo corresponde dicha fecha de nacimiento.
Nota : Para descomponer la fecha recibida como parámetro utilice la función split.  */
function mostrarSigno(fecha) {
    var arrayFecha = fecha.split("-");
    var dia = +arrayFecha[0];
    var mes = arrayFecha[1];
    var signo = "";
    switch (mes) {
        case "03": {
            if (dia >= 21) {
                signo = "ARIES";
            }
            else {
                signo = "PISCIS";
            }
            break;
        }
        case "04": {
            if (dia <= 20) {
                signo = "ARIES";
            }
            else {
                signo = "TAURO";
            }
            break;
        }
        case "05": {
            if (dia <= 20) {
                signo = "TAURO";
            }
            else {
                signo = "GEMINIS";
            }
            break;
        }
        case "06": {
            if (dia <= 21) {
                signo = "GEMINIS";
            }
            else {
                signo = "CANCER";
            }
            break;
        }
        case "07": {
            if (dia <= 22) {
                signo = "CANCER";
            }
            else {
                signo = "LEO";
            }
            break;
        }
        case "08": {
            if (dia <= 23) {
                signo = "LEO";
            }
            else {
                signo = "VIRGO";
            }
            break;
        }
        case "09": {
            if (dia <= 23) {
                signo = "VIRGO";
            }
            else {
                signo = "LIBRA";
            }
            break;
        }
        case "10": {
            if (dia <= 22) {
                signo = "LIBRA";
            }
            else {
                signo = "ESCORPIO";
            }
            break;
        }
        case "11": {
            if (dia <= 22) {
                signo = "ESCORPIO";
            }
            else {
                signo = "SAGITARIO";
            }
            break;
        }
        case "12": {
            if (dia <= 21) {
                signo = "SAGITARIO";
            }
            else {
                signo = "CAPRICORNIO";
            }
            break;
        }
        case "01": {
            if (dia <= 19) {
                signo = "CAPRICORNIO";
            }
            else {
                signo = "ACUARIO";
            }
            break;
        }
        case "02": {
            if (dia <= 19) {
                signo = "ACUARIO";
            }
            else {
                signo = "PISCIS";
            }
            break;
        }
    }
    console.log("Segun su fecha de nacimiento: " + fecha);
    console.log("Su signo es: " + signo);
}
mostrarSigno("27-08-1988");
mostrarSigno("01-10-1988");
mostrarSigno("25-01-1988");
//# sourceMappingURL=ejercicio12.js.map