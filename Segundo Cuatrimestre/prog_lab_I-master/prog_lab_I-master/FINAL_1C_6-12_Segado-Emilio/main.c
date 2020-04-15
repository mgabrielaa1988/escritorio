#include <stdio.h>
#include <stdlib.h>
#include "ArrayList.h"
#include "empleados.h"
#include "registros.h"
#include "multiple.h"
#include "generic.h"

int getOpcion();

int main()
{
    ArrayList* empleadosList = al_newArrayList();
    ArrayList* registrosList = al_newArrayList();
    int menuOpcion;
    if(loadEmpelados(empleadosList))
    {
        printf("Empleados cargados\n");
    }
    else
    {
        printf("Error en carga de empleados\n");
    }

    if(loadRegistros(registrosList))
    {
        printf("Registros cargados\n");
    }
    else
    {
        printf("Error en carga de registros\n");
    }

    do
    {
        menuOpcion=getOpcion();

        switch(menuOpcion)
        {
        case 1:
            if(addEmpleado(empleadosList)==1)
            {
                printf("Exitoso");
            }
            break;
        case 2:
            if(empleadosList->isEmpty(empleadosList)==0)
            {
                modificarEmpleado(empleadosList);
            }
            break;
        case 3:
            if(empleadosList->isEmpty(empleadosList)==0)
            {
                bajaFisica(empleadosList);
            }
            break;
        case 4:
            if(empleadosList->isEmpty(empleadosList)==0)
            {
                listarEmpleados(empleadosList);
            }
            else
            {
                printf("No hay empleados\n");
            }
            break;
        case 5:
            if(empleadosList->isEmpty(empleadosList)==0)
            {
                registrarDia(registrosList,empleadosList);
            }
            else
            {
                printf("No hay empleados\n");
            }
            break;
        case 6:
            if(registrosList->isEmpty(registrosList)==0)
            {
                eliminarRegistro(registrosList);
            }
            else
            {
                printf("No hay registros\n");
            }
        case 7:
            if(registrosList->isEmpty(registrosList)==0)
            {
                listarRegistros(registrosList);
            }
            else
            {
                printf("No hay registros\n");
            }
            break;
        }
    }
    while(menuOpcion != 12);

    return 0;
}

int getOpcion()
{
    int opcion=0;
    char mensaje[]="\nMenu\
    \n1.-Alta de Empleado\
    \n2.-Modificacion de Empleado\
    \n3.-Baja de Empleado\
    \n4.-Listar Empleado\
    \n5.-Registrar dia\
    \n6.-Anular registro\
    \n7.-Informar registro de dias\
    \n8.-Informar registro de dias por tipo de tarea\
    \n9.-Generar informe de registro de dias\
    \n10.-Informar cantidad de dias trabajados por empleado en cada tarea\
    \n11 Salir\n\
    \nIngrese: ";
    getInt(&opcion, mensaje, 50, 1, 11);

    return opcion;
}
