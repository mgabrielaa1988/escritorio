function funcion(numero, cadena) {
    if (cadena != null) {
        for (var index = 0; index < numero; index++) {
            console.log(cadena);
        }
    }
    else {
        console.log(numero * -1);
    }
}
var num = 3;
var texto = "cadena de texto";
funcion(num, texto);
funcion(num);
