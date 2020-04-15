#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include "funciones.h"


int main()
{
    int opcionMenu;
    double primerOperando;
    double segundoOperando;
    double resultado;

    /*while(seguir=='s')*/
    {
    printf("\n  BIENVENIDO/A A LA CALCULADORA\n");
    printf("\n  Menu de opciones\n");
    printf("  1. para SUMAR \n");
    printf("  2. para RESTAR \n");
    printf("  3. para DIVIDIR \n");
    printf("  4. para MULTIPLICAR \n");
    printf("  5. calcular el FACTORIAL \n");
    printf("  6. para realizar TODAS las operaciones \n");
    printf("  7. para SALIR \n  ");
    printf("  Ingrese la opcion que desea realizar: ");
    scanf("%d", &opcionMenu);

    while (opcionMenu<1 || opcionMenu>7)
    {
        printf("  Error... Reingrese opcion... ");
        scanf("%d", &opcionMenu);
    }

    primerOperando = double pedirNumero();
    segundoOperando = double pedirNumero();


        switch(opcionMenu)
        {
            case 1:
                resultado = primerOperando + segundoOperando;
                printf("El resultado de la suma es:  %lf", resultado);
                break;
            case 2:
                resultado = primerOperando - segundoOperando;
                printf("El resultado de la resta es:  %lf", resultado);
                break;
            case 3:
                resultado = primerOperando / segundoOperando;
                printf("El resultado de la division es:  %lf", resultado);
                break;
            case 4:
                resultado = primerOperando * segundoOperando;
                printf("El resultado de la multiplicacion es:  %lf", resultado);
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                /*seguir = 'n';*/
                break;
        }
    }



    return 0;

}
/*{


        printf("1- Ingresar 1er operando (A=x)\n");
        printf("2- Ingresar 2do operando (B=y)\n");
        printf("3- Calcular la suma (A+B)\n");
        printf("4- Calcular la resta (A-B)\n");
        printf("5- Calcular la division (A/B)\n");
        printf("6- Calcular la multiplicacion (A*B)\n");
        printf("7- Calcular el factorial (A!)\n");
        printf("8- Calcular todas las operacione\n");
        printf("9- Salir\n");



    return 0;
}*/
