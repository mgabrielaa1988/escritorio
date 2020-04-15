/*3. Realizar una función que reciba un parámetro requerido de tipo numérico 
y otro opcional de tipo cadena. Si el segundo parámetro es recibido, se mostrará 
tantas veces por consola, como lo indique el primer parámetro. En caso de no 
recibir el segundo parámetro, se mostrará el valor inverso del primer parámetro.  */

function nuevaFuncion(numero:number,texto?:string):void
{
    if(texto!=null)
    {
        for (let index = 0; index < numero; index++) 
        { 
            console.log(texto);
        }
    }
    else
    {
        console.log(numero*-1);
    }
}

nuevaFuncion(-5);
nuevaFuncion(3);
nuevaFuncion(2,"Gabriela");
nuevaFuncion(3,"Aragon");