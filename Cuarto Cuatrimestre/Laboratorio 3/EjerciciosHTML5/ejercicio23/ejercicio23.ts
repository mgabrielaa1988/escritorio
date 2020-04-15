
function Calcular():void{
    let nombre: string = (<HTMLInputElement>document.getElementById("nombre")).value;
    let apellido: string = (<HTMLInputElement>document.getElementById("apellido")).value;
    let email: string = (<HTMLInputElement>document.getElementById("email")).value;
    let auxHoras: string = (<HTMLInputElement>document.getElementById("horas")).value;
    let horas: number = parseInt(auxHoras, 10);
    let salario: number=0;

    if(isNaN(horas))
    {horas=0;}

    salario = horas * ObtenerCoeficiente();

    let txt=`Empleado: ${apellido},${nombre}<br>Email: ${email}<br>Salario por ${auxHoras} horas trabajadas: ${salario}.`;
    (<HTMLElement>document.getElementById("auxCalculo")).innerHTML = txt;
}

function ObtenerCoeficiente():number{
    return 6.88;
}