
/*11. Definir una función que determine si la cadena de texto que se le pasa 
como parámetro es un palíndromo, es decir, si se lee de la misma forma desde 
la izquierda y desde la derecha. Ejemplo de palíndromo complejo: 
"La ruta nos aporto otro paso natural" .  */

function palíndromo(texto:string):void{
    var aux:string=texto.toLowerCase();
    aux=aux.replace(/ /g,"");
    var caracter:number=aux.length/2;
    var comienzo:string;
    var final:string;
    var finalAlReves:string="";

    if(aux.length%2!=0){
        comienzo=aux.slice(0,caracter-0.5);
        final=aux.slice(caracter+0.5,aux.length);
    }
    else{
        comienzo=aux.slice(0,caracter);
        final=aux.slice(caracter,aux.length);
    }

    for(let i=final.length-1;i>=0;i--){
        finalAlReves+=final[i];
    }

    if(comienzo.localeCompare(finalAlReves)==0){
        console.log("El texto: "+texto);
        console.log("Es un palindromo");
    }
    else{
        console.log("El texto: "+texto);
        console.log("No es palindromo");
    }
}

palíndromo("La ruta nos aporto otro paso natural");
palíndromo("Otro texto");