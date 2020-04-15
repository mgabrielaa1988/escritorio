function HabilitarControles(): void {
    let contrasenia: string = (<HTMLInputElement>document.getElementById("passw")).value;
    let texto: boolean = (<HTMLInputElement>document.getElementById("txtNombre")).disabled;
    //let boton :Boolean =(<HTMLInputElement>document.getElementById("botton")).disabled;
    //contraseña que definimos nostros
    if (contrasenia == "holamundo") {
        texto = false;
        //boton=false;
    }
    else {
        texto = true;
        //boton=true;
    }
}