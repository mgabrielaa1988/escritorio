function Cubo(params:number):number{
    return Math.pow(params,3);
}
var resultado:number=Cubo(2);
var funcion:Function=Cubo;
console.log(resultado);
console.log(funcion(3));
