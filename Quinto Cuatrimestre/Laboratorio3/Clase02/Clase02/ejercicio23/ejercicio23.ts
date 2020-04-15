function ObtenerCoeficiente(horas: string): string {
    var retorno;
    var hs = parseInt(horas);
    if (isNaN(hs) || hs < 0) {
        retorno = "Cantidad de hs no valida";
    }
    else {
        retorno = (hs * 6.88).toString();
    }
    return retorno;
}

function btnCalcular(): void {
    var nombre: string = (<HTMLInputElement>document.getElementById("nombre")).value;
    var apellido: string = (<HTMLInputElement>document.getElementById("apellido")).value;
    var mail: string = (<HTMLInputElement>document.getElementById("mail")).value;
    var hsTrabajadas: string = (<HTMLInputElement>document.getElementById("horasT")).value;
    var salario: string = ObtenerCoeficiente(hsTrabajadas);
    (<HTMLInputElement>document.getElementById("cuadro")).placeholder = salario;
}