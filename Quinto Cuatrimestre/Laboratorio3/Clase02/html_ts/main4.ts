function MostrarNombre(): void {
  var nombre: string = (<HTMLInputElement>document.getElementById("nombre")).value;
  var edad: number = parseInt((<HTMLInputElement>document.getElementById("edad")).value);
  alert(nombre + "\n" + edad);
  console.log(nombre + "\n" + edad);
  //poner el nombre en el div tambien
}
