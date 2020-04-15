#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"
#define MAX 20

void alta (ePersona persona[],int tam)
{
    int i;

    for (i=0; i<tam; i++)
    {

        if (persona[i].estado == 0)
        {
            persona[i].estado = 1;

            printf("  Ingrese nombre: \n");
            fflush(stdin);
            gets(persona[i].nombre);
            printf("  Ingrese edad: \n");
            scanf("%d", &persona[i].edad);
            printf("  Ingrese DNI: \n");
            scanf("%ld", &persona[i].dni);
            break;
        }
    }
    if (i==tam)
    {
        printf("  No queda memoria suficiente para mas datos");
    }
    else
        {
        printf("  El dato fue guardado");
        }
}

int obtenerEspacioLibre(ePersona lista[],int tam)
{
    int i;
    int aux;

    for (i=0; i<tam; i++)
    {
        if (lista[i].estado==1)
        {
            aux = i;
        }
        else
        {
            aux = 0;
        }
    }
    return aux;
}

void mostrar(ePersona persona)
{
    if (persona.estado == 1)
    {
        printf("%s \t%4ld\t%4d\n",persona.nombre,persona.dni,persona.edad);
    }
}

void mostrarPorNombre(ePersona lista[],int tam)
{
    int i;
    int j;
    ePersona auxPersona;

    for (i=0; i<tam-1; i++)
    {
        for (j=i+1; j<tam; j++)
        {
            if ((strcmp(lista[i].nombre,lista[j].nombre))<0 && lista[i].estado==1)
            {
                auxPersona = lista[j];
                lista[i] = lista[j];
                lista[j] = auxPersona;
            }
        }
        mostrar(lista[i]);
        /*      if (lista[i].estado==1)
              {

                  printf("%s, %s\t %ld\t %d\n",lista[i].apellido,lista[i].nombre,lista[i].dni,lista[i].edad);
              }*/
    }
}

int buscarPorDni(ePersona persona[], int dni, int tam)
{
    int flag =0;
    int i;
    char eliminar;

    for (i=0; i<tam; i++)
    {
        if (persona[i].dni == dni && persona[i].estado == 1)
        {
            flag =1;
            printf("  ENCONTRADO:\n");
            mostrar(persona[i]);

            printf(" Eliminar? S = SI");
            fflush(stdin);
            eliminar = getche();

            if (eliminar == 's')
            {
                baja(persona,tam);
            }
        }
    }
    if (flag == 0)
    {
        printf("  NO SE ENCONTRO EL No. DNI...\n");
        printf("  REVISE EL REGISTRO\n\n");
    }
    return flag;
}

void baja(ePersona persona[],int tam)
{
    int i;
    for (i=0; i<tam; i++)
    {
        persona[i].estado = 0;
    }
    if (i==tam)
    {
        printf(" Dato no encontrado");
    }
    else
    {
        printf("  Dato borrado exitosamente");
    }

}

/*void baja(ePersona persona[].estado)
{
    char confirma;
    int aux,i;

    if (aux == 0)
    {
        mostrar (eliminar);
        printf("  Confirma que desea eliminar el dato? S = SI  ");
        fflush(stdin);
        confirma = getche();

        if (confirma == 's')
        {

        }
    }
}

ePersona buscarPorDni(ePersona lista[],int tam, int dni)
{
    ePersona retorno;
    retorno.estado = 0;
    int i;

    for (i=0;i<tam;i++)
    {
        if(lista[i].dni==dni&&lista[i].estado==1)
        {
            baja(ePersona lista[i]);
            retorno = lista[i];
            break;
        }
    }
    return retorno;
}*/

