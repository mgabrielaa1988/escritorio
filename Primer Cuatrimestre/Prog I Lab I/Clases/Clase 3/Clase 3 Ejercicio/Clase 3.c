#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define PI 3.141592
#include "Clase 3.h"

float pedirNumero()
{
    float numero;
    printf("Ingrese un numero: ");
    scanf ("%f", &numero);

    return numero;
}

float areaCirculo(float radio)
{
    float resultado;
    resultado =  PI * radio * radio;

    return resultado;
}


