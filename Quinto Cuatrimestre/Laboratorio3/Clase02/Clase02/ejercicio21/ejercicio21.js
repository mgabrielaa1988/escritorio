"use strict";
function Calcular() {
    var numero1 = parseInt(document.getElementById("num1").value);
    var numero2 = parseInt(document.getElementById("num2").value);
    var radio = document.getElementsByName("rOperacion");
    var operacion = "";
    var mensaje = "";
    for (var index = 0; index < radio.length; index++) {
        if (radio[index].checked == true) {
            operacion = radio[index].value;
            break;
        }
    }
    switch (operacion) {
        case "+": {
            mensaje = "Suma:  " + numero1 + "+" + numero2 + "=" + (numero1 + numero2);
            break;
        }
        case "-": {
            mensaje = "Resta:  " + numero1 + "-" + numero2 + "=" + (numero1 - numero2);
            break;
        }
        case "*": {
            mensaje = "Multiplicacion:  " + numero1 + "x" + numero2 + "=" + (numero1 * numero2);
            break;
        }
        case "/": {
            if (numero2 == 0) {
                mensaje = "Division:  No es posible dividir entre cero.";
            }
            else {
                mensaje = "Division:  " + numero1 + "/" + numero2 + "=" + (numero1 / numero2);
            }
            break;
        }
    }
    if (isNaN(numero1) || isNaN(numero2)) {
        mensaje = "Los valores ingresados no son validos";
    }
    alert(mensaje);
}
//# sourceMappingURL=ejercicio21.js.map