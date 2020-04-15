#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"
#define MAX 20

char validarMenu (char opcion)
{
   while ((int)opcion<49 || (int)opcion>53)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu ");
        opcion = getche();
    }

    return opcion;
}

