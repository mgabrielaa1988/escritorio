
/*9. Realizar una función que solicite (por medio de un parámetro) un número. 
Si el número es positivo, se mostrará el factorial de ese número, caso contrario 
se mostrará el cubo de dicho número. 
Nota : Reutilizar la función que determina el factorial de un número y la que calcula 
el cubo de un número. */

function factorialO(numero:number):number{
    var total:number;
    if(numero==0){
        return 1;
    }
    total=numero*factorialO(numero-1);
    return total;
}

function cuboO(valor:number):number{
    return (valor*valor*valor);
}

function solicite(parametro:number):void{
    if (parametro>0){
        console.log("Numero positivo: !"+parametro+"="+factorialO(parametro));
    }
    else{
        console.log("Numero negativo: "+parametro+"³="+cuboO(parametro));
    }
}

solicite(3);
solicite(5);
solicite(-3);
solicite(-5);