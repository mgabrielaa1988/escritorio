function MostrarOpcion(): void {
    var radio: any = document.getElementsByName("voto");
    var voto = "";
    for (let index = 0; index < radio.length; index++) {
        if (radio[index].checked == true) {
            voto = radio[index].value;
            break;
        }
    }
    var nombre: string = (<HTMLInputElement>document.getElementById("txtNombre")).value;
    var msj = `Nombre: ${nombre}\nValoración: ${voto}`;
    alert(msj);
}