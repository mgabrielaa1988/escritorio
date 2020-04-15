/**9. Realizar una función que solicite (por medio de un parámetro) un número. 
Si el número es positivo, se mostrará el factorial de ese número, caso contrario se mostrará 
el cubo de dicho número. 
Nota : Reutilizar la función que determina el factorial de un número y la que calcula el cubo de un número. */

function EsPositivo(numero: number): number {
    var retorno: number;
    if (numero >= 0) {
        retorno = factorial(numero);
        console.log("El numero es positivo: " + numero + "!=" + retorno);
    }
    else {
        retorno = cubo(numero);
        console.log("El numero es negativo: " + numero + "^3=" + retorno);
    }
    return retorno;
}

EsPositivo(-5);
EsPositivo(0);
EsPositivo(4);