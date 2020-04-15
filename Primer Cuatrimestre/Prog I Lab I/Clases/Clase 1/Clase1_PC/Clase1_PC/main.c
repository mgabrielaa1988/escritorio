#include <stdio.h>
#include <stdlib.h>

/*Escribir  un programa que realice las siguientes acciones
1. Limpie la pantalla
2. Asigne a 2 variables numero1 y numero2 valores distintos de cero
3. Efectœe el producto de dichas variables
4. Muestre el resultado pos pantalla
Obtenga el cuadrado de numero1 y lo muestre par pantalla*/


int main(int argc, char *argv[]) {

    int numero1;
    int numero2;
    int producto;
    int cuadrado;

    numero1=2;
    numero2=1;

    producto=numero1*numero2;
    printf(" El producto de los numeros es: %d\n", producto);

    cuadrado=numero1*numero1;
    printf(" El cuadrado del primer numero es: %d", cuadrado);

	return 0;
}
