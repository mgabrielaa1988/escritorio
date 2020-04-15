
///<reference path="./empleado.ts"/>

let empl1=new Empleados.Empleado("Gabriela","Aragon",12345678,"F",1234,25000);
empl1.HablarIdioma("español");
let mostrar= empl1.ToString();
console.log(mostrar);

//let : Array<Empleados.Empleado> = [new Empleados.Empleado("Gabriela","Aragon",12345678,"F",1234,25000),
///                                   new Empleados.Empleado("Luz","Rubini",98765432,"F",2345,25000) ];