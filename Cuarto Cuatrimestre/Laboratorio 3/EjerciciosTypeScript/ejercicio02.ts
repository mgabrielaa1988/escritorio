/*2. Cree una aplicación que muestre, a través de un Array , los nombres de 
los meses de un año y el número al que ese mes corresponde. 
Utilizar una estructura repetitiva para escribir en la consola ( console . log () ).  */

var meses:Array<string>=["Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"];
for (let index = 0; index < meses.length; index++) 
{
    console.log("Mes: "+meses[index]+"\tNumero: "+(index+1));   
}