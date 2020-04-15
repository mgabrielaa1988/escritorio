
function MostrarOpcion():void{
    var voto:HTMLFormElement = (<HTMLFormElement>document.forms[0]);
    var nombre:string = (<HTMLInputElement> document.getElementById("txtNombre")).value;
    var msj = `Nombre: ${nombre}\nValoración: ${voto}`;
    alert(msj);
}