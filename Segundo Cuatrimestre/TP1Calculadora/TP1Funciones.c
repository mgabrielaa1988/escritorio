#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include "TP1Funciones.h"


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



char validarMenu (char opcionMenu)
{
   while ((int)opcionMenu<48 || (int)opcionMenu>57)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu: ");
        opcionMenu = getche();
    }

    return opcionMenu;
}


float validarCero (float numeroB)
{
    while (numeroB == 0)
         {
             printf("\n  No se puede dividir entre 0.");
             numeroB = pedirNumero();
         }
    return numeroB;
}


float validarEntPos (float numeroA)
{
    while (numeroA - (int)numeroA !=0 || numeroA <0)
        {
            printf("\n  Reingrese solo enteros positivos");
            numeroA = pedirNumero();
        }
        return numeroA;
}



