function funcion(numero: number, cadena?: string) {
  if (cadena != null) {
    for (let index = 0; index < numero; index++) {
      console.log(cadena);
    }
  }
  else {
    console.log(numero * -1);
  }
}
