#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include "TP1Funciones.h"


int main()
{
    char opcionMenu;
    float numero1 = 0;
    float numero2 = 0;
    float resultado;
    long long int elFactorial;


    printf("\n--------------------------------------");
    printf("\n-----BIENVENIDO/A A LA CALCULADORA----");
    printf("\n--------------------------------------\n");

    do
    {

        printf("\n     Menu de opciones\n");
        printf("  1. Ingresar el 1er. numero (A=%.4f)\n", numero1);
        printf("  2. Ingresar el 2do. numero (B=%.4f)\n", numero2);
        printf("  3. para SUMAR (A+B)\n");
        printf("  4. para RESTAR (A-B)\n");
        printf("  5. para DIVIDIR (A/B)\n");
        printf("  6. para MULTIPLICAR (A*B)\n");
        printf("  7. calcular el FACTORIAL (A!) \n");
        printf("  8. para realizar TODAS las operaciones \n");
        printf("  9. para SALIR \n");
        printf("  0. para LIMPIAR\n");
        printf("  Ingrese la opcion que desea realizar: ");

        opcionMenu = getche();
        opcionMenu = validarMenu (opcionMenu);
        system("cls");

        switch (opcionMenu)
        {
        case '1':
            numero1 = pedirNumero();
            break;
        case '2':
            numero2 = pedirNumero();
            break;
        case '3':
            resultado = sumar(numero1,numero2);
            printf("\n  El resultado de la suma es: %.4f\n", resultado);
            break;
        case '4':
            resultado = restar(numero1,numero2);
            printf("\n  El resultado de la resta es: %.4f\n", resultado);
            break;
        case '5':
            numero2 = validarCero (numero2);
            resultado = dividir(numero1,numero2);
            printf("\n  El cociente es: %.4f\n", resultado);
            break;
        case '6':
            resultado = multiplicar(numero1,numero2);
            printf("\n  El producto es: %.4f\n", resultado);
            break;
        case '7':
            numero1 = validarEntPos (numero1);
            elFactorial = factorial (numero1);
            printf("\n  El factorial de %.0f es: %lld\n",numero1, elFactorial);
            break;
        case '8':
            resultado = sumar (numero1,numero2);
            printf("\n  El resultado de la suma es: %.4f\n", resultado);
            resultado = restar(numero1,numero2);
            printf("  El resultado de la resta es: %.4f\n", resultado);
            resultado = dividir(numero1,numero2);
            printf("  El cociente es: %.4f\n", resultado);
            resultado = multiplicar(numero1,numero2);
            printf("  El producto es: %.4f\n", resultado);
            break;
        case '0':
            numero1 = 0;
            numero2 = 0;
            printf("\n");
            break;
        }



    }
    while(opcionMenu != '9');
    {
        printf("\n\n  ...ADIOS!!!\n");
    }

    return 0;
}
