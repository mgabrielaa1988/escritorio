
/*8. Crear una función que realice el cálculo factorial del número que recibe como parámetro. 
Nota : Utilizar console.log() */

function factorial(numero:number):number{
    var total:number;
    if(numero==0){
        return 1;
    }
    total=numero*factorial(numero-1);
    return total;
}

function mostrarFactorial(numero:number):void{
    console.log("El factorial de "+numero+" es: "+factorial(numero));
}

mostrarFactorial(3);
mostrarFactorial(4);
mostrarFactorial(5);