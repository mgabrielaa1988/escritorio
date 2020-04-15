function MostrarSeleccion():void{
    var mail1: boolean = (<HTMLInputElement> document.getElementById("1")).checked;
    var mail2: boolean = (<HTMLInputElement> document.getElementById("2")).checked;
    var mail3: boolean = (<HTMLInputElement> document.getElementById("3")).checked;
    var mail4: boolean = (<HTMLInputElement> document.getElementById("4")).checked;
    var mail5: boolean = (<HTMLInputElement> document.getElementById("5")).checked;

    var msj:string="No selecciono ningún mail\n";

    if(mail1==true || mail2==true || mail3==true || mail4==true ||mail5==true){
        msj=`Mails seleccionados:\n`;
    }
    if(mail1){
        msj+=`gabrielaaragon@hotmail.com\n`;
    }
    if(mail2){
        msj+=`gabrielaaragon@yahoo.com\n`;
    }
    if(mail3){
        msj+=`gabrielaaragon@gmail.com\n`;
    }
    if(mail4){
        msj+=`gabrielaaragon@live.com\n`;
    }
    if(mail5){
        msj+=`gabriela@aragon.com\n`;
    }

    alert (msj);
}