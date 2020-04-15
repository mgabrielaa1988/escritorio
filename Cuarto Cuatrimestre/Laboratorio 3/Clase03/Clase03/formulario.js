///<reference path="./empleado.ts"/>
function CrearNuevoEmpleado() {
    /*let nombre:string=(<HTMLInputElement> document.getElementById("nombre")).value;
    let apellido:string=(<HTMLInputElement> document.getElementById("apellido")).value;
    let dni:string=(<HTMLInputElement> document.getElementById("dni")).value;
    let sexo:string=(<HTMLInputElement> document.getElementById("cboSexo")).value;
    let legajo:string=(<HTMLInputElement> document.getElementById("legajo")).value;
    let sueldo:string=(<HTMLInputElement> document.getElementById("sueldo")).value;

alert(apellido+", "+nombre+" DNI: "+dni+" Sexo: "+sexo+" Legajo: "+legajo+" Sueldo: $"+sueldo);

let newEmpl=new Empleados.Empleado(nombre,apellido,parseInt(dni,10),sexo,parseInt(legajo,10),parseInt(sueldo,10));
newEmpl.HablarIdioma("español");
let mostrar= newEmpl.ToString();
console.log(mostrar);*/
    var recup = document.getElementById("empleado");
    recup.submit();
}
