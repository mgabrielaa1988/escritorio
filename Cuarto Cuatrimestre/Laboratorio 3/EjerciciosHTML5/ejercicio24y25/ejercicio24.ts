
function AddErrorAll():void
{
    let nombre: string= (<HTMLInputElement> document.getElementById("nombre")).value;
    let apellido: string= (<HTMLInputElement> document.getElementById("apellido")).value;
    let dni: string= (<HTMLInputElement> document.getElementById("dni")).value;
    let sexo: string= (<HTMLInputElement> document.getElementById("sexo")).value;

    CheckError(nombre,"errorNombre","Nombre");
    CheckError(apellido,"errorApellido", "Apellido");
    CheckError(dni,"errorDni", "Dni");
    CheckErrorSexo(sexo,"errorSexo");

    let sexAux="";
    if(sexo=='f'){
        sexAux="femenino";
    }
    else if(sexo="m"){
        sexAux="masculino";
    }

    alert(`Nombre: ${apellido}, ${nombre}\nDNI: ${dni}\nSexo: ${sexAux}`);
}

function CheckError(texto:string,idEnPagina: string,textoEnMensaje: string): void
{
    if(texto === "")
    {(<HTMLElement>document.getElementById(idEnPagina)).innerHTML = `${textoEnMensaje} está vacio.`;}
    else
    {(<HTMLElement>document.getElementById(idEnPagina)).innerHTML = "";}
}

function CheckErrorSexo(texto:string,idEnPagina: string): void
{
    texto = texto.toLowerCase();

    if(texto !== "m" && texto !== "f")
    {(<HTMLElement>document.getElementById(idEnPagina)).innerHTML = `Por favor, ingrese f o m.`;}
    else
    {(<HTMLElement>document.getElementById(idEnPagina)).innerHTML = "";}
}