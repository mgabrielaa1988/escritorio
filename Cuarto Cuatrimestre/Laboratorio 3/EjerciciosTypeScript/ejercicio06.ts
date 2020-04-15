/*6. Realizar una función que reciba como parámetro un número y que retorne el cubo del mismo. 
Nota : La función retornará el cubo del parámetro ingresado. Realizar una función que invoque 
a esta última y permita mostrar por consola el resultado. */

var numero:number=5;

function cubo(valor:number):void{
    console.log("El cubo de "+valor+" es: "+(valor*valor*valor));
}

cubo(numero);