#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define PI 3.141592
#include "Clase 3.h"

/*1) Crear una funci�n que permita ingresar un numero al usuario y lo retorne.
Crear una funci�n que reciba el radio de un c�rculo y retorne su �rea.
Utilizar las funciones de los puntos 1 y 2 para hacer un programa que calcule
el �rea de un c�rculo cuyo radio es ingresado por el usuario.
Documentar las funciones al estilo Doxygen.*/

int main()
{
    int numero;
    float area;

    numero = pedirNumero();
    area = areaCirculo (numero);

    printf("El area del circulo es: %.2f\n",area);

    return 0;
}

