#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "generic.h"
#include "ArrayList.h"
#include "funciones.h"



int main()
{
    ArrayList* listaTareas=al_newArrayList();
    ArrayList* listaAlta=al_newArrayList();
    ArrayList* listaBaja=al_newArrayList();
    int opcion;
    char continuar= 's';

    do
    {
        cleanScreen();
        opcion = 0;
        opcion = getOpcion();

        switch(opcion)
        {
        case 1:
            printf("\nCargar\n");
            if(loadTareas(listaTareas)==-1)
            {
                printf("\nError en carga de archivos\n");
            }
            else
            {
                printf("\nDatos cargados\n");
            }
            break;
        case 2:
            printf("\nOrdenar\n");
            if(listaTareas->isEmpty(listaTareas)==0)
            {
                if(!ordenarTareas(listaTareas))
                {
                    printAll(listaTareas);
                    printf("\nOrdenamiento exitoso.\n");
                }
                else
                {
                    printf("\nError en ordenamiento.\n");
                }
            }
            else
            {
                printf("\nNo hay datos\n");
            }
            break;
        case 3:
            printf("\nParticionar por prioridad\n");
            if(listaTareas->isEmpty(listaTareas)==0)
            {
                if(particionar(listaTareas,listaAlta,listaBaja)==0)
                {
                    mostrarListas(listaAlta, listaBaja);
                    printf("\nParticion exitosa.\n");
                }
                else
                {
                    printf("\nError en Particion.\n");
                }
            }
            else
            {
                printf("\nNo hay datos\n");
            }
            break;
        case 4:
            printf("\nResolver Tarea\n");
            if(listaTareas->isEmpty(listaTareas)==0)
            {
                if(resolverTarea(listaTareas,listaAlta,listaBaja))
                {
                    mostrarListas(listaAlta, listaBaja);
                    printf("\nResolver tarea exitosa.\n");
                }
                else
                {
                    printf("\nError en resolver.\n");
                }
            }
            else
            {
                printf("\nNo hay datos\n");
            }
            break;
        case 5:
            printf("\nGenerar Archivos Alta y Baja Prioridad\n");
            if(listaTareas->isEmpty(listaAlta)==0)
            {
                if(saveFile("pAlta.csv",listaAlta))
                {
                    mostrarListas(listaAlta, listaBaja);
                    printf("\nGuardado de lista de Alta exitoso.\n");
                }
                else
                {
                    printf("\nError en guardado de lista de Alta.\n");
                }
            }
            else
            {
                printf("\nNo hay datos de Alta prioridad\n");
            }

            if(listaTareas->isEmpty(listaBaja)==0)
            {
                if(saveFile("pBaja.csv",listaBaja))
                {
                    printAll(listaBaja);
                    printf("\nGuardado de lista de Baja exitoso.\n");
                }
                else
                {
                    printf("\nError en guardado de lista de Baja.\n");
                }
            }
            else
            {
                printf("\nNo hay datos de baja prioridad\n");
            }
            break;
        case 6:
            printf("\nSalir\n");
            continuar='N';
            break;
        default:
            printf("\nReingrese un numero valido del menu.\n");
            break;
        }

        pauseSystem();
    }
    while(continuar=='s');

    return 0;
}

