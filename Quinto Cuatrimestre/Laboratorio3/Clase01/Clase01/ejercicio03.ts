/**3. Realizar una función que reciba un parámetro requerido de tipo numérico y otro opcional
de tipo cadena. Si el segundo parámetro es recibido, se mostrará tantas veces por
consola, como lo indique el primer parámetro. En caso de no recibir el segundo
parámetro, se mostrará el valor inverso del primer parámetro. */

function prueba(numero: number, cadena?: string) {
  if (cadena != null) {
    for (let index = 0; index < numero; index++) {
      console.log(cadena);
    }
  }
  else {
    console.log(numero * -1);
  }
}

let num: number = 3;
let texto: string = "cadena de texto";

prueba(num, texto);
prueba(num);
