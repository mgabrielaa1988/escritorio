
function Calcular():void{
    let op1: string = (<HTMLInputElement> document.getElementById("number1")).value;
    let op2: string = (<HTMLInputElement> document.getElementById("number2")).value;
    let numero1: number = parseInt(op1, 10);
    let numero2: number = parseInt(op2, 10);
    let resultado:number=0;

    var validación:HTMLFormElement = (<HTMLFormElement> document.getElementsByName("operaciones")[0]);
    var operacion = "";
    var i;
    for (i = 0; i < validación.length; i++) {
        if (validación[i].checked == true) {
            operacion = validación[i].value;
            break;
        }
    }
    
    switch(operacion){
        case "+":{
            resultado=numero1+numero2;
            break;
        }
        case "-":{
            resultado=numero1-numero2;
            break;
        }
        case "*":{
            resultado=numero1*numero2;
            break;
        }
        case "/":{
            if(numero2!=0){
                resultado=numero1/numero2;
            }
            else{
                resultado=0;
            }
            break;
        }
    }
    console.log ("El resultado es: "+resultado);
    alert ("RESULTADO: "+resultado);
}