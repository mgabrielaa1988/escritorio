function Calcular() {
    var op1 = document.getElementById("number1").value;
    var op2 = document.getElementById("number2").value;
    var numero1 = parseInt(op1, 10);
    var numero2 = parseInt(op2, 10);
    var resultado = 0;
    var validación = document.getElementsByName("operaciones");
    var operacion = "";
    var i;
    for (i = 0; i < validación.length; i++) {
        if (validación[i].checked == true) {
            operacion = validación[i].value;
            break;
        }
    }
    switch (operacion) {
        case "+": {
            resultado = numero1 + numero2;
            break;
        }
        case "-": {
            resultado = numero1 - numero2;
            break;
        }
        case "*": {
            resultado = numero1 * numero2;
            break;
        }
        case "/": {
            if (numero2 != 0) {
                resultado = numero1 / numero2;
            }
            else {
                resultado = 0;
            }
            break;
        }
    }
    console.log("El resultado es: " + resultado);
    alert("RESULTADO: " + resultado);
}
