
function AgregarElemento() :void
{
    let elementoNuevo: string = (<HTMLInputElement> document.getElementById("cuadroText")).value;
    
    if(elementoNuevo !== "")
    {
        (<HTMLElement>document.getElementById("lista")).innerHTML+= `<li>${elementoNuevo}</li>`;
        (<HTMLInputElement>document.getElementById("cuadroText")).value="";
    }
}