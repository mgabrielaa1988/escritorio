function EnviarInfo(): void {
    var nombre: string = (<HTMLInputElement>document.getElementById("txtNombre")).value;
    var mail: string = (<HTMLInputElement>document.getElementById("txtMail")).value;
    var dni: string = (<HTMLInputElement>document.getElementById("txtDNI")).value;
    var cv: string = (<HTMLTextAreaElement>document.getElementById("txtCV")).value;

    var msj: string = `Nombre:${nombre}\nMail:${mail}\nDNI:${dni}\nCV:\n${cv}`;
    alert(msj);
}