#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"
#define MAX 20

int main()
{
    char seguir='s';
    char opcion;
    int i;
    long int dni;

    ePersona persona[MAX];

    for (i=0; i<MAX; i++)
       {
            persona[i].estado=0;
       }

    while(seguir=='s')
    {
        printf("  ------------MENU DE OPCIONES-------------\n");
        printf("  1- Agregar persona\n");
        printf("  2- Borrar persona\n");
        printf("  3- Imprimir lista ordenada por nombre\n");
        printf("  4- Imprimir grafico de edades\n");
        printf("  5- Salir\n");
        printf("  -----------------------------------------\n");
        printf("  Ingrese opcion elegida: ");

        fflush(stdin);
        opcion = getche();
        opcion = validarMenu (opcion);

        switch(opcion)
        {
        case '1':
            alta(persona, MAX);
            break;
        case '2':
            printf("  Ingrese el DNI del dato que desea eliminar: \n");
            scanf("%ld", dni);
            buscarPorDni(persona, dni, MAX);
            break;
        case '3':
            printf("\n----DATOS ORDENADOS ALFABETICAMENTE---\n");
                  printf("----Nombre-----DNI-----Edad---\n");
            mostrarPorNombre(persona,MAX);
            break;
        case '4':
//            graficar ();
            break;
        case '5':
            seguir = 'n';
            break;
        }

    }

    return 0;
}
