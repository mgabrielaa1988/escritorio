#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include "funciones.h"

double pedirNumero()
{
    double numero;
    printf("Ingrese el numero: ");
    scanf("%f", &numero);
    return numero;
}

double suma(int a, int b)
{ int total; total=a+b; return total; }

/*int validarEntero (int opcionMenu)
{
    while (opcionMenu<1 || opcionMenu>7)
    {
        int auxNumero;
        opcionMenu = auxNumero("Error!!! Reingrese...");
        return auxNumero;
    }
}*/



