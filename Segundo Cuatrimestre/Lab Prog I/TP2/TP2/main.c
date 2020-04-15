#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"
#define MAX 20

int main()
{
    ePersona persona[MAX];
    ePersona auxPersona;

    char opcion;

    int indiceLugarLibre;
    int indiceResultadoBusqueda;
    char auxNombre [50];
    int auxEdad;
    long int auxDNI;
    char auxEdadStr [50];
    char auxDniStr [50];
    int i;
    int j;

    inicializar(persona,MAX,-1);

    do
    {
        printf("\n\n  -------------MENU DE OPCIONES-------------\n");
        printf("  1- Agregar persona\n");
        printf("  2- Borrar persona\n");
        printf("  3- Imprimir lista ordenada por nombre\n");
        printf("  4- Imprimir grafico de edades\n");
        printf("  5- Salir\n");
        printf("  ------------------------------------------\n");
        printf("  Ingrese opcion elegida: ");

        fflush(stdin);
        opcion = getche();
        opcion = validarMenu (opcion);

        switch (opcion)
        {
        case '1':
            indiceLugarLibre = buscar(persona,MAX,-1);
            if(indiceLugarLibre == -1)
            {
                printf("\n\nMemoria llena . . .\n");
                break;
            }

            printf("\n\n-------------ALTA-------------\n");
            if (!getStringLetras("\n  Ingrese el nombre: ",auxNombre))
            {
                printf ("  Ingreso un caracter no valido\n");
                break;
            }

            if (!getStringNumeros("\n  Ingrese el DNI: ",auxDniStr))
            {
                printf ("  Ingreso un caracter no valido\n");
                break;
            }
            if (!getStringNumeros("\n  Ingrese el edad: ",auxEdadStr))
            {
                printf ("  Ingreso un caracter no valido\n");
                break;
            }
            auxEdad = atoi(auxEdadStr);
            auxDNI = atoi(auxDniStr);

            if(buscar(persona,MAX,auxDNI) != -1)
            {
                printf("\n\n  El numero de DNI ingresado se encuentra en la base de datos\n");
                break;
            }

            strcpy(persona[indiceLugarLibre].nombre,auxNombre);
            persona[indiceLugarLibre].edad = auxEdad;
            persona[indiceLugarLibre].dni = auxDNI;
            persona[indiceLugarLibre].estado = 1;

            break;

        case '2':
            printf("\n\n-------------BAJA-------------\n");
            if (!getStringNumeros("  Ingrese el DNI a dar de baja: ",auxDniStr))
            {
                printf ("  El DNI debe ser numerico\n");
                break;
            }
            indiceResultadoBusqueda = buscarPorDni(persona,MAX,atoi(auxDniStr));

            if(indiceResultadoBusqueda == -1)
            {
                printf("\n\n  No se encuentra el No. de DNI\n");
                break;
            }

            persona[indiceResultadoBusqueda].estado = -1;

            break;
        case '3':
            printf("\n\n----DATOS ORDENADOS ALFABETICAMENTE---------\n");
            printf("-Nombre-\t\t-DNI-\t\t-Edad-\n");
            for(i=0; i<MAX-1; i++)
            {

                for(j=i+1; j<MAX; j++)
                {

                    if(strcmp(persona[i].nombre,persona[j].nombre) > 0)
                    {
                        auxPersona = persona[j];
                        persona[j] = persona[i];
                        persona[i] = auxPersona;
                    }
                }
                if (persona[i].estado != -1)
                {
                    printf(" %3s\t\t\t%8ld\t\t%5d",persona[i].nombre,persona[i].dni,persona[i].edad);
                }
            }
            break;
        case '4':
            imprimirGrafico(persona,MAX);
            break;
        case '5':

            break;
        }
        putchar('\n');
        system("pause");
        system("cls");

    }
    while (opcion != '5');

    return 0;
}
