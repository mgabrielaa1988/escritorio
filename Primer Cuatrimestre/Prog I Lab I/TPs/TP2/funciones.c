#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"
#define MAX 20

void inicializar(ePersona persona[],int tam,int valor)
{
    int i;
    for(i=0; i<tam; i++)
    {
        persona[i].estado = valor;
        persona[i].dni = valor;
    }
}

int buscar(ePersona persona[],int tam,int valor)
{
    int i;

    for(i=0; i<tam; i++)
    {
        if(persona[i].estado == valor)
        {
            return i;
        }
    }
    return -1;
}

int buscarPorDni(ePersona persona[],int tam,int valor)
{
    int i;

    for(i=0; i<tam; i++)
    {
        if(persona[i].dni == valor)
        {
            return i;
        }
    }
    return -1;
}

void imprimirGrafico(ePersona valor[],int tam)
{
    int i;
    int joven=18;
    int adulto=35;
    int contNino=0;
    int contJoven=0;
    int contAdulto=0;
    int flag=0;

    putchar('\n');

    for (i=0; i<tam; i++)
    {
        if (valor[i].edad > adulto)
        {
            contAdulto ++;
        }
        if (valor[i].edad <= adulto && valor[i].edad > joven)
        {
            contJoven ++;
        }
        if (valor[i].edad <= joven)
        {
            contNino ++;
        }
    }

    int max;

    if(contNino >= contJoven && contNino >= contAdulto)
    {
        max = contNino;
    }
    else
    {
        if(contJoven >= contNino && contJoven >= contAdulto)
        {
            max = contJoven;
        }
        else
        {
            max = contAdulto;
        }
    }
    for(i=max; i>0; i--)
    {
        if(i<= contNino)
        {
            printf("  *");
        }
        if(i<= contJoven)
        {
            flag=1;
            printf("\t*");
        }
        if(i<= contAdulto)
        {
            if(flag==0)
                printf("\t\t *");
            if(flag==1)
                printf("\t  *");
        }
        putchar('\n');
    }
    printf("\n     <18         19-35         35<");
}
