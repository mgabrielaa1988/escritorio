function btnValidar(): void {
    var nombre = (<HTMLInputElement>document.getElementById("nombre")).value;
    CheckError(nombre, "nombre", "Nombre");

    var apellido = (<HTMLInputElement>document.getElementById("apellido")).value;
    CheckError(apellido, "apellido", "Apellido");

    var strDni = (<HTMLInputElement>document.getElementById("dni")).value;
    CheckError(strDni, "dni", "DNI");
    var dni = parseInt(strDni);
    if (isNaN(dni) || dni < 1) {
        alert("DNI: Solo puede ingresar numeros positivos");
        (<HTMLInputElement>document.getElementById("dni")).placeholder = "";
    }

    var sexo = (<HTMLInputElement>document.getElementById("sexo")).value;
    CheckError(sexo, "sexo", "Sexo");
    var sex = sexo.toLowerCase();
    if (sex != "f" && sex != "i" && sex != "m") {
        alert("Sexo: Solo puede ser, f para femenino, m para masculino, o i para indefinido");
        (<HTMLInputElement>document.getElementById("sexo")).placeholder = "";
    }
}

function CheckError(contenido: string, id: string, texto: string): void {
    if (contenido == "") { (<HTMLInputElement>document.getElementById(id)).placeholder = `${texto} está vacio.`; }
    else { (<HTMLInputElement>document.getElementById(id)).placeholder = ""; }
}