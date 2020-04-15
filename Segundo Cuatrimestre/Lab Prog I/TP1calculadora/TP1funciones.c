#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include "TP1funciones.h"


float pedirNumero()
{
    float numero;
    printf("\n  Ingrese un numero: ");
    scanf("  %f", &numero);

    return numero;
}

float sumar (float numeroA, float numeroB)
{
    float total;
    total = numeroA + numeroB;

    return total;
}

float restar (float numeroA, float numeroB)
{
    float total;
    total = numeroA - numeroB;

    return total;
}

float dividir (float numeroA, float numeroB)
{
    float total;
    total = numeroA / numeroB;

    return total;
}

float multiplicar (float numeroA, float numeroB)
{
    float total;
    total = numeroA * numeroB;

    return total;
}

long long int factorial (int numeroA)
{
    long long int total;
    if (numeroA==0)
    {
        return 1;
    }
    total = numeroA * factorial(numeroA - 1);
    return total;
}


