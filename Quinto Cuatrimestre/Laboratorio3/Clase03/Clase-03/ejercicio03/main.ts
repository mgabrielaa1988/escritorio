/// <reference path="empleado.ts"/>

let emp1 = new Test.Empleado("Juan", "Topo", 1111, "m", 111, 1000);

console.log(emp1.GetApellido);
console.log(emp1.GetNombre);
console.log(emp1.GetDNI);
console.log(emp1.GetSexo);
console.log(emp1.GetLegajo);
console.log(emp1.GetSueldo);
console.log(emp1.Hablar("Español"));
console.log(emp1.ToString());